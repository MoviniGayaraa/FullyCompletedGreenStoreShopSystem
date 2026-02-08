using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ShopGreenSystem
{
    public partial class CustomerManagementForm : Form
    {
        // Database connection string
        private string connectionString = "Server=localhost;Port=3306;Database=shopGreen;Uid=root;Pwd=1234;";
        private int adminId;
        private string adminName;
        private int selectedCustomerId = -1;

        public CustomerManagementForm(int userId, string userName)
        {
            InitializeComponent();
            this.adminId = userId;
            this.adminName = userName;
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadCustomers();
        }

        // Load all customers into DataGridView
        private void LoadCustomers()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT user_id AS 'Customer ID', name AS 'Name', email AS 'Email', 
                                   contact AS 'Contact', username AS 'Username', 
                                   created_at AS 'Registered Date' 
                                   FROM users WHERE role = 'CUSTOMER' 
                                   ORDER BY user_id DESC";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvCustomers.DataSource = dt;

                        // Style DataGridView
                        dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        dgvCustomers.MultiSelect = false;
                        dgvCustomers.ReadOnly = true;
                        dgvCustomers.AllowUserToAddRows = false;
                        dgvCustomers.RowHeadersVisible = false;
                        dgvCustomers.BackgroundColor = Color.White;
                        dgvCustomers.BorderStyle = BorderStyle.None;
                        dgvCustomers.DefaultCellStyle.SelectionBackColor = Color.FromArgb(46, 125, 50);
                        dgvCustomers.DefaultCellStyle.SelectionForeColor = Color.White;
                        dgvCustomers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 125, 50);
                        dgvCustomers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                        dgvCustomers.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                        dgvCustomers.EnableHeadersVisualStyles = false;

                        lblTotalCustomers.Text = $"Total Customers: {dt.Rows.Count}";
                    }
                }

                // Load customer statistics
                LoadCustomerStats();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading customers: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Load customer statistics
        private void LoadCustomerStats()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Total Customers
                    string totalQuery = "SELECT COUNT(*) FROM users WHERE role = 'CUSTOMER'";
                    using (MySqlCommand cmd = new MySqlCommand(totalQuery, conn))
                    {
                        int total = Convert.ToInt32(cmd.ExecuteScalar());
                        lblTotalCustomersCount.Text = total.ToString();
                    }

                    // Active Customers (with orders)
                    string activeQuery = @"SELECT COUNT(DISTINCT user_id) FROM orders 
                                         WHERE user_id IN (SELECT user_id FROM users WHERE role = 'CUSTOMER')";
                    using (MySqlCommand cmd = new MySqlCommand(activeQuery, conn))
                    {
                        int active = Convert.ToInt32(cmd.ExecuteScalar());
                        lblActiveCustomersCount.Text = active.ToString();
                    }

                    // New Customers This Month
                    string newQuery = @"SELECT COUNT(*) FROM users 
                                      WHERE role = 'CUSTOMER' 
                                      AND MONTH(created_at) = MONTH(CURRENT_DATE()) 
                                      AND YEAR(created_at) = YEAR(CURRENT_DATE())";
                    using (MySqlCommand cmd = new MySqlCommand(newQuery, conn))
                    {
                        int newCustomers = Convert.ToInt32(cmd.ExecuteScalar());
                        lblNewCustomersCount.Text = newCustomers.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading statistics: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Update Customer Button
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedCustomerId == -1)
                {
                    MessageBox.Show("Please select a customer to update!", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validation
                errorProvider1.Clear();
                bool isValid = true;

                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    errorProvider1.SetError(txtName, "Name is required");
                    isValid = false;
                }

                if (string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    errorProvider1.SetError(txtEmail, "Email is required");
                    isValid = false;
                }

                if (string.IsNullOrWhiteSpace(txtContact.Text))
                {
                    errorProvider1.SetError(txtContact, "Contact is required");
                    isValid = false;
                }

                if (!isValid)
                {
                    MessageBox.Show("Please fill all required fields!", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Update customer
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"UPDATE users SET name = @name, email = @email, contact = @contact 
                                   WHERE user_id = @customerId";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@contact", txtContact.Text.Trim());
                        cmd.Parameters.AddWithValue("@customerId", selectedCustomerId);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Customer updated successfully! 🌱", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadCustomers();
                            ClearFields();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating customer: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // View Orders Button
        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedCustomerId == -1)
                {
                    MessageBox.Show("Please select a customer to view orders!", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Load customer orders
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT order_id AS 'Order ID', order_date AS 'Order Date', 
                                   total_amount AS 'Total Amount', status AS 'Status' 
                                   FROM orders WHERE user_id = @customerId 
                                   ORDER BY order_id DESC";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@customerId", selectedCustomerId);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("This customer has no orders yet.", "No Orders",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        // Show orders in a new form or message box
                        string ordersList = $"Orders for {txtName.Text}:\n\n";
                        foreach (DataRow row in dt.Rows)
                        {
                            ordersList += $"Order ID: {row["Order ID"]}, " +
                                        $"Date: {Convert.ToDateTime(row["Order Date"]):yyyy-MM-dd}, " +
                                        $"Amount: Rs. {row["Total Amount"]}, " +
                                        $"Status: {row["Status"]}\n";
                        }

                        MessageBox.Show(ordersList, "Customer Orders",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading orders: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Clear Button
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        // Clear all input fields
        private void ClearFields()
        {
            txtName.Clear();
            txtEmail.Clear();
            txtContact.Clear();
            txtUsername.Clear();
            selectedCustomerId = -1;
            errorProvider1.Clear();
            lblSelectedCustomer.Text = "No customer selected";
        }

        // DataGridView cell click - populate fields
        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvCustomers.Rows[e.RowIndex];

                    selectedCustomerId = Convert.ToInt32(row.Cells["Customer ID"].Value);
                    txtName.Text = row.Cells["Name"].Value.ToString();
                    txtEmail.Text = row.Cells["Email"].Value.ToString();
                    txtContact.Text = row.Cells["Contact"].Value?.ToString() ?? "";
                    txtUsername.Text = row.Cells["Username"].Value.ToString();

                    lblSelectedCustomer.Text = $"Selected: {txtName.Text}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error selecting customer: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Search functionality
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    LoadCustomers();
                    return;
                }

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT user_id AS 'Customer ID', name AS 'Name', email AS 'Email', 
                                   contact AS 'Contact', username AS 'Username', 
                                   created_at AS 'Registered Date' 
                                   FROM users 
                                   WHERE role = 'CUSTOMER' AND 
                                   (name LIKE @search OR email LIKE @search OR username LIKE @search) 
                                   ORDER BY user_id DESC";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@search", "%" + txtSearch.Text + "%");
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvCustomers.DataSource = dt;
                        lblTotalCustomers.Text = $"Total Customers: {dt.Rows.Count}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Navigation Menu Buttons
        private void btnHome_Click(object sender, EventArgs e)
        {
            AdminDashboardForm adminDashboard = new AdminDashboardForm(adminId, adminName);
            adminDashboard.Show();
            this.Hide();
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            ManageUsersForm manageUsersForm = new ManageUsersForm(adminId, adminName);
            manageUsersForm.Show();
            this.Hide();
        }

        private void btnManageProducts_Click(object sender, EventArgs e)
        {
            ProductManagementForm productForm = new ProductManagementForm(adminId, adminName);
            productForm.Show();
            this.Hide();
        }

        private void btnManageCustomers_Click(object sender, EventArgs e)
        {
            // Already on this form
            LoadCustomers();
        }

        private void btnManageOrders_Click(object sender, EventArgs e)
        {
            OrderManagementForm orderForm = new OrderManagementForm(adminId, adminName);
            orderForm.Show();
            this.Hide();
        }

        private void btnGenerateReports_Click(object sender, EventArgs e)
        {
            ReportsForm reportsForm = new ReportsForm(adminId, adminName);
            reportsForm.Show();
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

        private void CustomerManagementForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        // Only allow numbers in contact field
        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Refresh Button
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadCustomers();
            ClearFields();
            MessageBox.Show("Customer data refreshed! 🌱", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}