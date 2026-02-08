using MySql.Data.MySqlClient;
//using ShopGreen;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ShopGreenSystem
{
    public partial class MyCartForm : Form
    {
        // Database connection string
        private string connectionString = "Server=localhost;Port=3306;Database=shopGreen;Uid=root;Pwd=1234;";
        private int customerId;
        private string customerName;
        private DataTable cartItems;

        public MyCartForm(int userId, string userName)
        {
            InitializeComponent();
            this.customerId = userId;
            this.customerName = userName;
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadCartItems();
            CalculateTotals();
        }

        // Load Cart Items
        private void LoadCartItems()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT 
                                    c.cart_id AS 'Cart ID',
                                    p.product_id AS 'Product ID',
                                    p.product_name AS 'Product Name',
                                    p.category AS 'Category',
                                    p.price AS 'Price',
                                    c.quantity AS 'Quantity',
                                    (p.price * c.quantity) AS 'Subtotal',
                                    p.stock AS 'Available Stock',
                                    p.discount AS 'Discount'
                                   FROM cart c
                                   JOIN products p ON c.product_id = p.product_id
                                   WHERE c.user_id = @userId
                                   AND p.status = 'AVAILABLE'
                                   ORDER BY c.cart_id DESC";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@userId", customerId);
                        cartItems = new DataTable();
                        adapter.Fill(cartItems);
                        dgvCartItems.DataSource = cartItems;

                        // Style DataGridView
                        StyleCartDataGridView();
                    }
                }

                UpdateCartSummary();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading cart items: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Style Cart DataGridView
        private void StyleCartDataGridView()
        {
            dgvCartItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCartItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCartItems.MultiSelect = false;
            dgvCartItems.ReadOnly = false;
            dgvCartItems.AllowUserToAddRows = false;
            dgvCartItems.RowHeadersVisible = false;
            dgvCartItems.BackgroundColor = Color.White;
            dgvCartItems.BorderStyle = BorderStyle.None;
            dgvCartItems.DefaultCellStyle.SelectionBackColor = Color.FromArgb(46, 125, 50);
            dgvCartItems.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvCartItems.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 125, 50);
            dgvCartItems.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvCartItems.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvCartItems.EnableHeadersVisualStyles = false;

            // Hide unnecessary columns
            if (dgvCartItems.Columns["Cart ID"] != null)
                dgvCartItems.Columns["Cart ID"].Visible = false;
            if (dgvCartItems.Columns["Product ID"] != null)
                dgvCartItems.Columns["Product ID"].Visible = false;
            if (dgvCartItems.Columns["Available Stock"] != null)
                dgvCartItems.Columns["Available Stock"].Visible = false;
            if (dgvCartItems.Columns["Discount"] != null)
                dgvCartItems.Columns["Discount"].Visible = false;

            // Format columns
            if (dgvCartItems.Columns["Price"] != null)
                dgvCartItems.Columns["Price"].DefaultCellStyle.Format = "C2";
            if (dgvCartItems.Columns["Subtotal"] != null)
                dgvCartItems.Columns["Subtotal"].DefaultCellStyle.Format = "C2";

            // Set column widths
            dgvCartItems.Columns["Product Name"].FillWeight = 30;
            dgvCartItems.Columns["Category"].FillWeight = 20;
            dgvCartItems.Columns["Price"].FillWeight = 15;
            dgvCartItems.Columns["Quantity"].FillWeight = 15;
            dgvCartItems.Columns["Subtotal"].FillWeight = 20;

            // Make Quantity column editable
            if (dgvCartItems.Columns["Quantity"] != null)
            {
                dgvCartItems.Columns["Quantity"].ReadOnly = false;
            }
        }

        // Update Cart Summary
        private void UpdateCartSummary()
        {
            int itemCount = dgvCartItems.Rows.Count;
            lblCartSummary.Text = $"You have {itemCount} item{(itemCount != 1 ? "s" : "")} in your cart";

            if (itemCount == 0)
            {
                btnCheckout.Enabled = false;
                btnClearCart.Enabled = false;
                lblSubtotalValue.Text = "Rs. 0.00";
                lblShippingValue.Text = "Rs. 0.00";
                lblTotalValue.Text = "Rs. 0.00";
            }
            else
            {
                btnCheckout.Enabled = true;
                btnClearCart.Enabled = true;
            }
        }

        // Calculate Totals
        private void CalculateTotals()
        {
            decimal subtotal = 0;

            foreach (DataGridViewRow row in dgvCartItems.Rows)
            {
                if (row.Cells["Subtotal"].Value != null)
                {
                    subtotal += Convert.ToDecimal(row.Cells["Subtotal"].Value);
                }
            }

            // Shipping calculation (example: free shipping above Rs. 500)
            decimal shipping = subtotal > 500 || subtotal == 0 ? 0 : 100;
            decimal total = subtotal + shipping;

            lblSubtotalValue.Text = $"Rs. {subtotal:N2}";
            lblShippingValue.Text = $"Rs. {shipping:N2}";
            lblTotalValue.Text = $"Rs. {total:N2}";
        }

        // Update Quantity in Database
        private void UpdateQuantity(int cartId, int newQuantity)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE cart SET quantity = @quantity WHERE cart_id = @cartId";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@quantity", newQuantity);
                        cmd.Parameters.AddWithValue("@cartId", cartId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating quantity: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Remove Item from Cart
        private void RemoveCartItem(int cartId)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM cart WHERE cart_id = @cartId";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@cartId", cartId);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Item removed from cart!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error removing item: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Clear Entire Cart
        private void ClearCart()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM cart WHERE user_id = @userId";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", customerId);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Cleared {rowsAffected} item{(rowsAffected != 1 ? "s" : "")} from cart!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadCartItems();
                            CalculateTotals();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error clearing cart: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Checkout
        private void Checkout()
        {
            if (dgvCartItems.Rows.Count == 0)
            {
                MessageBox.Show("Your cart is empty!", "Cart Empty",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Proceed to checkout?\n\nTotal: {lblTotalValue.Text}\nItems: {dgvCartItems.Rows.Count}",
                "Confirm Checkout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();

                        // Calculate total amount
                        decimal totalAmount = 0;
                        foreach (DataGridViewRow row in dgvCartItems.Rows)
                        {
                            if (row.Cells["Subtotal"].Value != null)
                            {
                                totalAmount += Convert.ToDecimal(row.Cells["Subtotal"].Value);
                            }
                        }

                        // Create order
                        string orderQuery = @"INSERT INTO orders (user_id, total_amount, status) 
                                            VALUES (@userId, @totalAmount, 'PENDING');
                                            SELECT LAST_INSERT_ID();";

                        int orderId = 0;
                        using (MySqlCommand cmd = new MySqlCommand(orderQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@userId", customerId);
                            cmd.Parameters.AddWithValue("@totalAmount", totalAmount);
                            orderId = Convert.ToInt32(cmd.ExecuteScalar());
                        }

                        // Add order items
                        foreach (DataGridViewRow row in dgvCartItems.Rows)
                        {
                            if (row.Cells["Product ID"].Value != null)
                            {
                                string itemQuery = @"INSERT INTO order_items 
                                                   (order_id, product_id, quantity, price) 
                                                   VALUES (@orderId, @productId, @quantity, @price)";

                                using (MySqlCommand cmd = new MySqlCommand(itemQuery, conn))
                                {
                                    cmd.Parameters.AddWithValue("@orderId", orderId);
                                    cmd.Parameters.AddWithValue("@productId", Convert.ToInt32(row.Cells["Product ID"].Value));
                                    cmd.Parameters.AddWithValue("@quantity", Convert.ToInt32(row.Cells["Quantity"].Value));
                                    cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(row.Cells["Price"].Value));
                                    cmd.ExecuteNonQuery();
                                }
                            }
                        }

                        // Clear cart after successful checkout
                        ClearCart();

                        MessageBox.Show($"Order placed successfully!\nOrder ID: #{orderId}\nTotal: {lblTotalValue.Text}",
                            "Order Placed",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        // Navigate to track orders
                        TrackOrdersForm trackForm = new TrackOrdersForm(customerId, customerName);
                        trackForm.Show();
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error during checkout: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Navigation Menu Buttons
        private void btnStore_Click(object sender, EventArgs e)
        {
            CustomerDashboardForm dashboard = new CustomerDashboardForm(customerId, customerName);
            dashboard.Show();
            this.Hide();
        }

        private void btnBrowseProducts_Click(object sender, EventArgs e)
        {
            BrowseProductsForm browseForm = new BrowseProductsForm(customerId, customerName);
            browseForm.Show();
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

        // Control Events
        private void dgvCartItems_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvCartItems.Columns["Quantity"].Index)
            {
                try
                {
                    DataGridViewRow row = dgvCartItems.Rows[e.RowIndex];
                    int cartId = Convert.ToInt32(row.Cells["Cart ID"].Value);
                    int newQuantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                    int availableStock = Convert.ToInt32(row.Cells["Available Stock"].Value);
                    decimal price = Convert.ToDecimal(row.Cells["Price"].Value);

                    // Validate quantity
                    if (newQuantity <= 0)
                    {
                        MessageBox.Show("Quantity must be at least 1", "Invalid Quantity",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        row.Cells["Quantity"].Value = 1;
                        return;
                    }

                    if (newQuantity > availableStock)
                    {
                        MessageBox.Show($"Only {availableStock} items available in stock", "Insufficient Stock",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        row.Cells["Quantity"].Value = availableStock;
                        newQuantity = availableStock;
                    }

                    // Update subtotal
                    row.Cells["Subtotal"].Value = price * newQuantity;

                    // Update in database
                    UpdateQuantity(cartId, newQuantity);

                    // Recalculate totals
                    CalculateTotals();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating quantity: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            if (dgvCartItems.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvCartItems.SelectedRows[0];
                int cartId = Convert.ToInt32(row.Cells["Cart ID"].Value);

                DialogResult result = MessageBox.Show("Remove this item from cart?", "Confirm Removal",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    RemoveCartItem(cartId);
                    LoadCartItems();
                    CalculateTotals();
                }
            }
            else
            {
                MessageBox.Show("Please select an item to remove", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            if (dgvCartItems.Rows.Count == 0)
            {
                MessageBox.Show("Your cart is already empty!", "Cart Empty",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show("Clear all items from cart?", "Confirm Clear Cart",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            return;

            if (result == DialogResult.Yes)
            {
                ClearCart();
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            Checkout();
        }

        private void btnContinueShopping_Click(object sender, EventArgs e)
        {
            BrowseProductsForm browseForm = new BrowseProductsForm(customerId, customerName);
            browseForm.Show();
            this.Hide();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadCartItems();
            CalculateTotals();
            MessageBox.Show("Cart refreshed!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void MyCartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void lblCartTitle_Click(object sender, EventArgs e)
        {

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}