using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ShopGreenSystem
{
    public partial class TrackOrdersForm : Form
    {
        private string connectionString = "Server=localhost;Port=3306;Database=shopGreen;Uid=root;Pwd=1234;";
        private int customerId;
        private string customerName;
        private DataTable originalDataTable;
        private int selectedOrderId = -1;

        public TrackOrdersForm(int userId, string userName)
        {
            InitializeComponent();
            this.customerId = userId;
            this.customerName = userName;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void TrackOrdersForm_Load(object sender, EventArgs e)
        {
            InitializeUI();
            LoadOrders();
            LoadCartCount();
        }

        private void InitializeUI()
        {
            lblWelcome.Text = $"Welcome, {customerName}!";
            btnTrackOrders.BackColor = Color.FromArgb(37, 99, 41);
        }

        private void LoadCartCount()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM cart WHERE user_id = @userId";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", customerId);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        lblCartCount.Text = $"🛒 Cart ({count})";
                    }
                }
            }
            catch (Exception ex)
            {
                lblCartCount.Text = "🛒 Cart (Error)";
                Console.WriteLine("Error loading cart count: " + ex.Message);
            }
        }

        private void LoadOrders()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"SELECT 
                                    o.order_id AS 'OrderID',
                                    DATE_FORMAT(o.order_date, '%Y-%m-%d %H:%i') AS 'OrderDate',
                                    o.total_amount AS 'TotalAmount',
                                    o.status AS 'Status',
                                    GROUP_CONCAT(CONCAT(p.product_name, ' (x', oi.quantity, ')') SEPARATOR ', ') AS 'Products'
                                   FROM orders o
                                   LEFT JOIN order_items oi ON o.order_id = oi.order_id
                                   LEFT JOIN products p ON oi.product_id = p.product_id
                                   WHERE o.user_id = @userId
                                   GROUP BY o.order_id, o.order_date, o.total_amount, o.status
                                   ORDER BY o.order_date DESC";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@userId", customerId);
                        originalDataTable = new DataTable();
                        adapter.Fill(originalDataTable);

                        dgvOrders.DataSource = null;

                        if (originalDataTable.Rows.Count > 0)
                        {
                            // Create a display DataTable with formatted values
                            DataTable displayTable = CreateDisplayTable(originalDataTable);
                            dgvOrders.DataSource = displayTable;
                            StyleOrdersGridView();
                            lblOrderCount.Text = $"{originalDataTable.Rows.Count} Order(s) Found";
                            lblOrderCount.ForeColor = Color.FromArgb(46, 125, 50);

                            // Select first row by default
                            if (dgvOrders.Rows.Count > 0)
                            {
                                dgvOrders.Rows[0].Selected = true;
                                selectedOrderId = Convert.ToInt32(dgvOrders.Rows[0].Cells["Order ID"].Value);
                            }
                        }
                        else
                        {
                            ShowNoOrdersMessage("No orders found. Start shopping!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ShowNoOrdersMessage("Cannot connect to database. Please check your connection.");
                Console.WriteLine("Database error: " + ex.Message);
            }
        }

        private DataTable CreateDisplayTable(DataTable sourceTable)
        {
            DataTable displayTable = new DataTable();

            // Add columns with proper display names
            displayTable.Columns.Add("Order ID", typeof(int));
            displayTable.Columns.Add("Order Date", typeof(string));
            displayTable.Columns.Add("Total Amount", typeof(string));
            displayTable.Columns.Add("Status", typeof(string));
            displayTable.Columns.Add("Products", typeof(string));

            // Copy and format data
            foreach (DataRow row in sourceTable.Rows)
            {
                DataRow newRow = displayTable.NewRow();
                newRow["Order ID"] = row["OrderID"];
                newRow["Order Date"] = row["OrderDate"];

                // Format the amount as string for display
                if (row["TotalAmount"] != DBNull.Value)
                {
                    decimal amount = Convert.ToDecimal(row["TotalAmount"]);
                    newRow["Total Amount"] = $"Rs. {amount:N2}";
                }
                else
                {
                    newRow["Total Amount"] = "Rs. 0.00";
                }

                newRow["Status"] = row["Status"];

                // Truncate products if too long
                string products = row["Products"].ToString();
                if (products.Length > 100)
                {
                    products = products.Substring(0, 97) + "...";
                }
                newRow["Products"] = products;

                displayTable.Rows.Add(newRow);
            }

            return displayTable;
        }

        private void ShowNoOrdersMessage(string message)
        {
            lblOrderCount.Text = message;
            lblOrderCount.ForeColor = Color.FromArgb(255, 87, 87);
            selectedOrderId = -1;

            // Clear DataGridView and show message
            dgvOrders.DataSource = null;
            dgvOrders.Rows.Clear();
            dgvOrders.Columns.Clear();

            DataGridViewColumn col = new DataGridViewTextBoxColumn();
            col.HeaderText = "Information";
            col.Name = "Info";
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvOrders.Columns.Add(col);

            dgvOrders.Rows.Add(message);
            dgvOrders.Rows[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvOrders.Rows[0].DefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Italic);
            dgvOrders.Rows[0].DefaultCellStyle.ForeColor = Color.Gray;
        }

        private void StyleOrdersGridView()
        {
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.ReadOnly = true;
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.RowHeadersVisible = false;
            dgvOrders.BackgroundColor = Color.White;
            dgvOrders.BorderStyle = BorderStyle.None;
            dgvOrders.DefaultCellStyle.SelectionBackColor = Color.FromArgb(46, 125, 50);
            dgvOrders.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvOrders.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 125, 50);
            dgvOrders.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvOrders.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvOrders.EnableHeadersVisualStyles = false;
            dgvOrders.RowTemplate.Height = 60;

            // Style status column
            if (dgvOrders.Columns.Contains("Status"))
            {
                foreach (DataGridViewRow row in dgvOrders.Rows)
                {
                    if (row.Cells["Status"] != null && row.Cells["Status"].Value != null)
                    {
                        string status = row.Cells["Status"].Value.ToString();
                        row.Cells["Status"].Style.ForeColor = GetStatusColor(status);
                        row.Cells["Status"].Style.Font = new Font(dgvOrders.Font, FontStyle.Bold);
                    }
                }
            }

            // Style total amount column
            if (dgvOrders.Columns.Contains("Total Amount"))
            {
                dgvOrders.Columns["Total Amount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvOrders.Columns["Total Amount"].DefaultCellStyle.Font = new Font(dgvOrders.Font, FontStyle.Bold);
            }

            // Style order ID column
            if (dgvOrders.Columns.Contains("Order ID"))
            {
                dgvOrders.Columns["Order ID"].DefaultCellStyle.Font = new Font(dgvOrders.Font, FontStyle.Bold);
            }

            // Add alternating row colors
            dgvOrders.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 248);
        }

        private Color GetStatusColor(string status)
        {
            switch (status.ToUpper())
            {
                case "PENDING": return Color.FromArgb(255, 152, 0);
                case "SHIPPED": return Color.FromArgb(33, 150, 243);
                case "DELIVERED": return Color.FromArgb(46, 125, 50);
                default: return Color.Gray;
            }
        }

        private void FilterOrdersByStatus(string status)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT 
                                    o.order_id AS 'OrderID',
                                    DATE_FORMAT(o.order_date, '%Y-%m-%d %H:%i') AS 'OrderDate',
                                    o.total_amount AS 'TotalAmount',
                                    o.status AS 'Status',
                                    GROUP_CONCAT(CONCAT(p.product_name, ' (x', oi.quantity, ')') SEPARATOR ', ') AS 'Products'
                                   FROM orders o
                                   LEFT JOIN order_items oi ON o.order_id = oi.order_id
                                   LEFT JOIN products p ON oi.product_id = p.product_id
                                   WHERE o.user_id = @userId AND o.status = @status
                                   GROUP BY o.order_id, o.order_date, o.total_amount, o.status
                                   ORDER BY o.order_date DESC";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@userId", customerId);
                        adapter.SelectCommand.Parameters.AddWithValue("@status", status);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            // Create display table
                            DataTable displayTable = CreateDisplayTable(dt);
                            dgvOrders.DataSource = displayTable;
                            StyleOrdersGridView();
                            lblOrderCount.Text = $"{dt.Rows.Count} {status} Order(s)";
                            lblOrderCount.ForeColor = GetStatusColor(status);

                            // Select first row
                            if (dgvOrders.Rows.Count > 0)
                            {
                                dgvOrders.Rows[0].Selected = true;
                                selectedOrderId = Convert.ToInt32(dgvOrders.Rows[0].Cells["Order ID"].Value);
                            }
                        }
                        else
                        {
                            ShowNoOrdersMessage($"No {status.ToLower()} orders found");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ShowNoOrdersMessage("Error filtering orders");
                Console.WriteLine("Filter error: " + ex.Message);
            }
        }

        private void UpdateFilterButtonStyle(Button activeButton)
        {
            // Reset all buttons
            btnAllOrders.BackColor = Color.White;
            btnAllOrders.ForeColor = Color.FromArgb(46, 125, 50);
            btnPendingOrders.BackColor = Color.White;
            btnPendingOrders.ForeColor = Color.FromArgb(255, 152, 0);
            btnShippedOrders.BackColor = Color.White;
            btnShippedOrders.ForeColor = Color.FromArgb(33, 150, 243);
            btnDeliveredOrders.BackColor = Color.White;
            btnDeliveredOrders.ForeColor = Color.FromArgb(46, 125, 50);

            // Set active button
            activeButton.BackColor = Color.FromArgb(46, 125, 50);
            activeButton.ForeColor = Color.White;
        }

        private void dgvOrders_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Suppress the error dialog
            e.ThrowException = false;
            e.Cancel = false;
        }

        // Selection changed event
        private void dgvOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count > 0 && dgvOrders.SelectedRows[0].Cells["Order ID"].Value != null)
            {
                selectedOrderId = Convert.ToInt32(dgvOrders.SelectedRows[0].Cells["Order ID"].Value);
            }
        }

        // Button Click Events
        private void btnAllOrders_Click(object sender, EventArgs e)
        {
            UpdateFilterButtonStyle(btnAllOrders);
            LoadOrders();
        }

        private void btnPendingOrders_Click(object sender, EventArgs e)
        {
            UpdateFilterButtonStyle(btnPendingOrders);
            FilterOrdersByStatus("PENDING");
        }

        private void btnShippedOrders_Click(object sender, EventArgs e)
        {
            UpdateFilterButtonStyle(btnShippedOrders);
            FilterOrdersByStatus("SHIPPED");
        }

        private void btnDeliveredOrders_Click(object sender, EventArgs e)
        {
            UpdateFilterButtonStyle(btnDeliveredOrders);
            FilterOrdersByStatus("DELIVERED");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadOrders();
            LoadCartCount();
            UpdateFilterButtonStyle(btnAllOrders);
        }

        // Quick Actions
        private void btnViewOrderDetails_Click(object sender, EventArgs e)
        {
            if (selectedOrderId > 0)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = @"SELECT 
                                        o.order_id,
                                        DATE_FORMAT(o.order_date, '%Y-%m-%d %H:%i:%s') as order_date,
                                        o.total_amount,
                                        o.status,
                                        u.email as customer_email
                                       FROM orders o
                                       LEFT JOIN users u ON o.user_id = u.user_id
                                       WHERE o.order_id = @orderId AND o.user_id = @userId";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@orderId", selectedOrderId);
                            cmd.Parameters.AddWithValue("@userId", customerId);

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    string orderDate = reader["order_date"].ToString();
                                    decimal totalAmount = Convert.ToDecimal(reader["total_amount"]);
                                    string status = reader["status"].ToString();
                                    string customerEmail = reader["customer_email"].ToString();

                                    // Get order items
                                    string items = GetOrderItems(selectedOrderId);

                                    string message = $"📦 ORDER DETAILS\n" +
                                                    $"════════════════════════════════════════\n\n" +
                                                    $"🔢 Order Number: #{selectedOrderId}\n" +
                                                    $"📅 Order Date: {orderDate}\n" +
                                                    $"👤 Customer: {customerName}\n" +
                                                    $"📧 Email: {customerEmail}\n" +
                                                    $"💰 Total Amount: Rs. {totalAmount:N2}\n" +
                                                    $"📊 Status: {status}\n\n" +
                                                    $"🛍️ ITEMS ORDERED:\n" +
                                                    $"════════════════════════════════════════\n" +
                                                    $"Product Name                     | Qty | Price   | Total\n" +
                                                    $"────────────────────────────────────────────────────────\n" +
                                                    $"{items}\n\n" +
                                                    $"════════════════════════════════════════\n" +
                                                    $"💡 Note: You can save an invoice using the 'Save Invoice' button.\n" +
                                                    $"📞 Contact support for any questions.";

                                    MessageBox.Show(message, $"Order #{selectedOrderId} Details",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Order details not found!", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading order details: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select an order first!", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSaveInvoice_Click(object sender, EventArgs e)
        {
            if (selectedOrderId > 0)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = @"SELECT 
                                        o.order_id,
                                        DATE_FORMAT(o.order_date, '%Y-%m-%d %H:%i:%s') as order_date,
                                        o.total_amount,
                                        o.status,
                                        u.email as customer_email
                                       FROM orders o
                                       LEFT JOIN users u ON o.user_id = u.user_id
                                       WHERE o.order_id = @orderId AND o.user_id = @userId";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@orderId", selectedOrderId);
                            cmd.Parameters.AddWithValue("@userId", customerId);

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    string orderDate = reader["order_date"].ToString();
                                    decimal totalAmount = Convert.ToDecimal(reader["total_amount"]);
                                    string status = reader["status"].ToString();
                                    string customerEmail = reader["customer_email"].ToString();

                                    // Get order items
                                    string items = GetOrderItems(selectedOrderId);

                                    // Create invoice content with available data
                                    string invoice = GenerateInvoiceContent(selectedOrderId, orderDate, totalAmount,
                                        status, items, customerName, customerEmail);

                                    // Show Save File dialog
                                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                                    saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                                    saveFileDialog.FileName = $"ShopGreen_Invoice_{selectedOrderId}_{DateTime.Now:yyyyMMdd}.txt";
                                    saveFileDialog.DefaultExt = "txt";
                                    saveFileDialog.Title = "Save Invoice As";

                                    // Set default location to user's Documents folder
                                    string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                                    string invoicesFolder = Path.Combine(documentsPath, "ShopGreen Invoices");

                                    // Create folder if it doesn't exist
                                    if (!Directory.Exists(invoicesFolder))
                                    {
                                        Directory.CreateDirectory(invoicesFolder);
                                    }

                                    saveFileDialog.InitialDirectory = invoicesFolder;

                                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                                    {
                                        // Save the file
                                        File.WriteAllText(saveFileDialog.FileName, invoice);

                                        // Show success message with file path
                                        MessageBox.Show($"✅ Invoice saved successfully!\n\n" +
                                                      $"📁 Location: {saveFileDialog.FileName}\n" +
                                                      $"📄 File: {Path.GetFileName(saveFileDialog.FileName)}\n\n" +
                                                      $"You can now print or share this invoice.",
                                                      "Invoice Saved",
                                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        // User cancelled
                                        MessageBox.Show("Invoice save cancelled.", "Save Cancelled",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Order not found for invoice generation!", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving invoice: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select an order first!", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private string GetOrderItems(int orderId)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT 
                                    p.product_name,
                                    oi.quantity,
                                    p.price,
                                    (p.price * oi.quantity) as item_total
                                   FROM order_items oi
                                   LEFT JOIN products p ON oi.product_id = p.product_id
                                   WHERE oi.order_id = @orderId";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@orderId", orderId);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            StringBuilder items = new StringBuilder();
                            while (reader.Read())
                            {
                                string productName = reader["product_name"].ToString();
                                int quantity = Convert.ToInt32(reader["quantity"]);
                                decimal price = Convert.ToDecimal(reader["price"]);
                                decimal itemTotal = Convert.ToDecimal(reader["item_total"]);

                                items.AppendLine($"{productName,-30} | {quantity,3} | Rs. {price,8:N2} | Rs. {itemTotal,8:N2}");
                            }

                            return items.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error loading items: {ex.Message}";
            }
        }

        private string GenerateInvoiceContent(int orderId, string orderDate, decimal totalAmount,
                                            string status, string items, string customerName, string customerEmail)
        {
            return $"════════════════════════════════════════════════════════════════════════════════\n" +
                   $"                           SHOPGREEN - ECO-FRIENDLY STORE                       \n" +
                   $"════════════════════════════════════════════════════════════════════════════════\n" +
                   $"                                                                                \n" +
                   $"                                 INVOICE                                        \n" +
                   $"                                                                                \n" +
                   $"════════════════════════════════════════════════════════════════════════════════\n" +
                   $"INVOICE #: INV-{orderId:D6}                                                     \n" +
                   $"ORDER #: {orderId}                                                              \n" +
                   $"DATE: {orderDate}                                                               \n" +
                   $"STATUS: {status}                                                                \n" +
                   $"                                                                                \n" +
                   $"════════════════════════════════════════════════════════════════════════════════\n" +
                   $"                            CUSTOMER INFORMATION                               \n" +
                   $"════════════════════════════════════════════════════════════════════════════════\n" +
                   $"NAME: {customerName}                                                            \n" +
                   $"EMAIL: {customerEmail}                                                          \n" +
                   $"                                                                                \n" +
                   $"════════════════════════════════════════════════════════════════════════════════\n" +
                   $"                                 ORDER ITEMS                                   \n" +
                   $"════════════════════════════════════════════════════════════════════════════════\n" +
                   $"Product Name                     | Qty | Unit Price  | Item Total              \n" +
                   $"────────────────────────────────────────────────────────────────────────────────\n" +
                   $"{items}                                                                       \n" +
                   $"                                                                                \n" +
                   $"════════════════════════════════════════════════════════════════════════════════\n" +
                   $"                            PAYMENT SUMMARY                                    \n" +
                   $"════════════════════════════════════════════════════════════════════════════════\n" +
                   $"                                                                                \n" +
                   $"SUBTOTAL:                   Rs. {totalAmount:N2}                                \n" +
                   $"TAX (0%):                   Rs. 0.00                                            \n" +
                   $"SHIPPING:                   Rs. 0.00                                            \n" +
                   $"DISCOUNT:                   Rs. 0.00                                            \n" +
                   $"────────────────────────────────────────────────────────────────────────────────\n" +
                   $"TOTAL AMOUNT:              Rs. {totalAmount:N2}                                 \n" +
                   $"                                                                                \n" +
                   $"════════════════════════════════════════════════════════════════════════════════\n" +
                   $"                              THANK YOU!                                       \n" +
                   $"════════════════════════════════════════════════════════════════════════════════\n" +
                   $"Thank you for shopping with ShopGreen! Your support helps us promote           \n" +
                   $"eco-friendly living and sustainable products.                                  \n" +
                   $"                                                                                \n" +
                   $"📞 Customer Support: +94 11 234 5678                                            \n" +
                   $"📧 Email: support@shopgreen.com                                                 \n" +
                   $"🌐 Website: www.shopgreen.com                                                   \n" +
                   $"📍 Address: 123 Green Street, Colombo 05, Sri Lanka                            \n" +
                   $"                                                                                \n" +
                   $"════════════════════════════════════════════════════════════════════════════════\n" +
                   $"INVOICE GENERATED ON: {DateTime.Now:yyyy-MM-dd HH:mm:ss}                        \n" +
                   $"════════════════════════════════════════════════════════════════════════════════\n";
        }

        private void btnContactSupport_Click(object sender, EventArgs e)
        {
            string supportMessage = $"📞 SHOPGREEN CUSTOMER SUPPORT\n\n" +
                                   $"════════════════════════════════════════\n\n" +
                                   $"We're here to help you!\n\n" +
                                   $"📧 Email: support@shopgreen.com\n" +
                                   $"📱 Phone: +94 11 234 5678\n" +
                                   $"💬 WhatsApp: +94 77 890 1234\n\n" +
                                   $"🕒 Business Hours:\n" +
                                   $"   Monday - Friday: 9:00 AM - 6:00 PM\n" +
                                   $"   Saturday: 10:00 AM - 4:00 PM\n" +
                                   $"   Sunday: Closed\n\n" +
                                   $"📍 Store Address:\n" +
                                   $"   123 Green Street\n" +
                                   $"   Colombo 05\n" +
                                   $"   Sri Lanka\n\n" +
                                   $"🌐 Website: www.shopgreen.com\n\n" +
                                   $"{(selectedOrderId > 0 ? $"📦 Reference your Order #: {selectedOrderId} when contacting us.\n\n" : "")}" +
                                   $"════════════════════════════════════════\n" +
                                   $"Thank you for choosing ShopGreen!";

            MessageBox.Show(supportMessage, "Contact Support",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Navigation Events
        private void btnStore_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CustomerDashboardForm(customerId, customerName).Show();
        }

        private void btnBrowseProducts_Click(object sender, EventArgs e)
        {
            this.Hide();
            new BrowseProductsForm(customerId, customerName).Show();
        }

        private void btnMyCart_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MyCartForm(customerId, customerName).Show();
        }

        private void btnTrackOrders_Click(object sender, EventArgs e)
        {
            // Already here - no action needed
        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MyProfileForm(customerId, customerName).Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Confirm Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                new LoginForm().Show();
            }
        }

        // Mouse Events
        private void MenuButton_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != btnTrackOrders && btn != null)
                btn.BackColor = Color.FromArgb(37, 99, 41);
        }

        private void MenuButton_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != btnTrackOrders && btn != null)
                btn.BackColor = Color.FromArgb(46, 125, 50);
        }

        private void FilterButton_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.BackColor != Color.FromArgb(46, 125, 50))
                btn.BackColor = Color.FromArgb(230, 245, 233);
        }

        private void FilterButton_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != btnAllOrders && btn.BackColor != Color.FromArgb(46, 125, 50))
                btn.BackColor = Color.White;
        }

        private void TrackOrdersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dgvOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvOrders.Rows[e.RowIndex].Cells["Order ID"].Value != null)
            {
                selectedOrderId = Convert.ToInt32(dgvOrders.Rows[e.RowIndex].Cells["Order ID"].Value);
                btnViewOrderDetails_Click(sender, e); // Show details when double-clicked
            }
        }
    }
}