using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ShopGreenSystem
{
    public partial class CustomerDashboardForm : Form
    {
        // Database connection string
        private string connectionString = "Server=localhost;Port=3306;Database=shopGreen;Uid=root;Pwd=1234;";
        private int customerId;
        private string customerName;

        public CustomerDashboardForm(int userId, string userName)
        {
            InitializeComponent();
            this.customerId = userId;
            this.customerName = userName;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // Form Load Event Handler
        private void CustomerDashboardForm_Load(object sender, EventArgs e)
        {
            LoadDashboardData();

            // Ensure the label has a default value on form load
            if (string.IsNullOrEmpty(lblTotalSpentValue.Text))
            {
                lblTotalSpentValue.Text = "Rs. 0.00";
            }
        }

        // Load Dashboard Data
        private void LoadDashboardData()
        {
            try
            {
                lblWelcome.Text = $"Welcome, {customerName}! 🌱";

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Get Total Orders
                    string ordersQuery = "SELECT COUNT(*) FROM orders WHERE user_id = @userId";
                    using (MySqlCommand cmd = new MySqlCommand(ordersQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", customerId);
                        int totalOrders = Convert.ToInt32(cmd.ExecuteScalar());
                        lblTotalOrdersValue.Text = totalOrders.ToString();
                    }

                    // Get Pending Orders
                    string pendingQuery = "SELECT COUNT(*) FROM orders WHERE user_id = @userId AND status IN ('PENDING', 'SHIPPED')";
                    using (MySqlCommand cmd = new MySqlCommand(pendingQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", customerId);
                        int pendingOrders = Convert.ToInt32(cmd.ExecuteScalar());
                        lblPendingOrdersValue.Text = pendingOrders.ToString();
                    }

                    // Get Cart Items
                    string cartQuery = "SELECT COUNT(*) FROM cart WHERE user_id = @userId";
                    using (MySqlCommand cmd = new MySqlCommand(cartQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", customerId);
                        int cartItems = Convert.ToInt32(cmd.ExecuteScalar());
                        lblCartItemsValue.Text = cartItems.ToString();
                    }

                    // FIXED: Get Total Spent - IMPROVED VERSION
                    decimal totalSpent = GetTotalSpent(conn);
                    lblTotalSpentValue.Text = $"Rs. {totalSpent:N2}";

                    // Debug output
                    Console.WriteLine($"DEBUG: Customer ID: {customerId}, Total Spent: {totalSpent}");

                    // Check database for debugging
                    CheckOrdersData(conn);
                }

                // Load Featured Products
                LoadFeaturedProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading dashboard data: {ex.Message}\n\nPlease check your database connection and try again.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"ERROR: {ex.Message}\n{ex.StackTrace}");

                // Set default values on error
                SetDefaultValues();
            }
        }

        // Set default values when there's an error
        private void SetDefaultValues()
        {
            lblTotalOrdersValue.Text = "0";
            lblPendingOrdersValue.Text = "0";
            lblCartItemsValue.Text = "0";
            lblTotalSpentValue.Text = "Rs. 0.00";
        }

        // Method to get total spent with multiple approaches
        private decimal GetTotalSpent(MySqlConnection conn)
        {
            decimal totalSpent = 0;

            try
            {
                // FIRST APPROACH: Try from orders table with DELIVERED status
                string query1 = @"SELECT COALESCE(SUM(total_amount), 0) 
                                FROM orders 
                                WHERE user_id = @userId 
                                AND status = 'DELIVERED'";

                using (MySqlCommand cmd = new MySqlCommand(query1, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", customerId);
                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        totalSpent = Convert.ToDecimal(result);
                        Console.WriteLine($"DEBUG Approach 1 (orders table): {totalSpent}");
                    }
                }

                // If first approach returns 0, try second approach
                if (totalSpent == 0)
                {
                    // SECOND APPROACH: Calculate from order_items table
                    string query2 = @"SELECT COALESCE(SUM(oi.price * oi.quantity), 0)
                                    FROM order_items oi
                                    INNER JOIN orders o ON oi.order_id = o.order_id
                                    WHERE o.user_id = @userId 
                                    AND o.status = 'DELIVERED'";

                    using (MySqlCommand cmd = new MySqlCommand(query2, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@userId", customerId);
                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            decimal calculatedTotal = Convert.ToDecimal(result);
                            Console.WriteLine($"DEBUG Approach 2 (order_items table): {calculatedTotal}");
                            totalSpent = calculatedTotal;
                        }
                    }
                }

                // If still 0, try third approach (all orders regardless of status)
                if (totalSpent == 0)
                {
                    string query3 = @"SELECT COALESCE(SUM(total_amount), 0) 
                                    FROM orders 
                                    WHERE user_id = @userId";

                    using (MySqlCommand cmd = new MySqlCommand(query3, conn))
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@userId", customerId);
                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            decimal allOrdersTotal = Convert.ToDecimal(result);
                            Console.WriteLine($"DEBUG Approach 3 (all orders): {allOrdersTotal}");
                            totalSpent = allOrdersTotal;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR in GetTotalSpent: {ex.Message}");
                totalSpent = 0;
            }

            return totalSpent;
        }

        // Debug method to check orders data
        private void CheckOrdersData(MySqlConnection conn)
        {
            try
            {
                // Check all order statuses for this user
                string debugQuery = @"SELECT 
                                    status, 
                                    COUNT(*) as order_count,
                                    COALESCE(SUM(total_amount), 0) as total_amount
                                    FROM orders 
                                    WHERE user_id = @userId
                                    GROUP BY status";

                using (MySqlCommand cmd = new MySqlCommand(debugQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", customerId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        Console.WriteLine("\n=== DEBUG ORDER DATA ===");
                        Console.WriteLine($"User ID: {customerId}");
                        Console.WriteLine("Status\t\tCount\tTotal Amount");
                        Console.WriteLine("----------------------------------");

                        bool hasData = false;
                        while (reader.Read())
                        {
                            hasData = true;
                            string status = reader.GetString("status");
                            int count = reader.GetInt32("order_count");
                            decimal total = reader.GetDecimal("total_amount");
                            Console.WriteLine($"{status}\t{count}\tRs. {total:N2}");
                        }

                        if (!hasData)
                        {
                            Console.WriteLine("No orders found for this user!");
                        }
                        Console.WriteLine("=== END DEBUG ===\n");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"DEBUG Error: {ex.Message}");
            }
        }

        // Load Featured Products (Available products)
        private void LoadFeaturedProducts()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT product_id AS 'Product ID', product_name AS 'Product Name', 
                                   category AS 'Category', price AS 'Price', stock AS 'Stock', 
                                   discount AS 'Discount'
                                   FROM products 
                                   WHERE status = 'AVAILABLE' AND stock > 0
                                   ORDER BY created_at DESC
                                   LIMIT 10";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvFeaturedProducts.DataSource = dt;

                        // Style DataGridView
                        StyleDataGridView();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StyleDataGridView()
        {
            dgvFeaturedProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFeaturedProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFeaturedProducts.MultiSelect = false;
            dgvFeaturedProducts.ReadOnly = true;
            dgvFeaturedProducts.AllowUserToAddRows = false;
            dgvFeaturedProducts.RowHeadersVisible = false;
            dgvFeaturedProducts.BackgroundColor = Color.White;
            dgvFeaturedProducts.BorderStyle = BorderStyle.None;
            dgvFeaturedProducts.DefaultCellStyle.SelectionBackColor = Color.FromArgb(46, 125, 50);
            dgvFeaturedProducts.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvFeaturedProducts.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 125, 50);
            dgvFeaturedProducts.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvFeaturedProducts.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvFeaturedProducts.EnableHeadersVisualStyles = false;

            // Hide Product ID column
            if (dgvFeaturedProducts.Columns["Product ID"] != null)
            {
                dgvFeaturedProducts.Columns["Product ID"].Visible = false;
            }

            // Highlight discounted products
            foreach (DataGridViewRow row in dgvFeaturedProducts.Rows)
            {
                if (row.Cells["Discount"].Value != null && Convert.ToBoolean(row.Cells["Discount"].Value))
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 243, 224);
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(230, 81, 0);
                }
            }
        }

        // Navigation Menu Buttons
        private void btnStore_Click(object sender, EventArgs e)
        {
            // Already on this form
            LoadDashboardData();
        }

        private void btnBrowseProducts_Click(object sender, EventArgs e)
        {
            BrowseProductsForm browseForm = new BrowseProductsForm(customerId, customerName);
            browseForm.Show();
            this.Hide();
        }

        private void btnMyCart_Click(object sender, EventArgs e)
        {
            MyCartForm cartForm = new MyCartForm(customerId, customerName);
            cartForm.Show();
            this.Hide();
        }

        private void btnTrackOrders_Click(object sender, EventArgs e)
        {
            TrackOrdersForm trackForm = new TrackOrdersForm(customerId, customerName);
            trackForm.Show();
            this.Hide();
        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            MyProfileForm profileForm = new MyProfileForm(customerId, customerName);
            profileForm.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
        }

        // Hover effects
        private void MenuButton_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.FromArgb(37, 99, 41);
        }

        private void MenuButton_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.FromArgb(46, 125, 50);
        }

        // Card hover effects
        private void Card_MouseEnter(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            panel.BackColor = Color.FromArgb(240, 240, 240);
        }

        private void Card_MouseLeave(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            panel.BackColor = Color.White;
        }

        private void CustomerDashboardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        // View Product Details from Featured Products
        private void dgvFeaturedProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                MessageBox.Show("Double-click to view product details.\n\n" +
                    "Go to 'Browse Products' to add items to cart!", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Refresh Dashboard
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDashboardData();
            MessageBox.Show("Dashboard refreshed! 🌱", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Debug button (optional - add if needed)
        private void btnDebug_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                CheckOrdersData(conn);
            }
        }

        private void lblFeaturedProductsTitle_Click(object sender, EventArgs e)
        {
            // Optional: Add functionality here if needed
        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {
            // Optional: Add custom painting if needed
        }

        private void panelCard4_Paint(object sender, PaintEventArgs e)
        {
            // Optional: Add custom painting if needed
        }
    }
}