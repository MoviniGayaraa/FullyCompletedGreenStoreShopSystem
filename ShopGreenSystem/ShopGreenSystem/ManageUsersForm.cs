using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ShopGreenSystem
{
    public partial class ManageUsersForm : Form
    {
        // Database connection string
        private string connectionString = "Server=localhost;Port=3306;Database=shopGreen;Uid=root;Pwd=1234;";
        private int adminId;
        private string adminName;
        private int selectedUserId = -1;

        public ManageUsersForm(int userId, string userName)
        {
            InitializeComponent();
            this.adminId = userId;
            this.adminName = userName;
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadUsers();
        }

        // Load all users into DataGridView
        private void LoadUsers()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT user_id AS 'User ID', name AS 'Name', email AS 'Email', " +
                                 "contact AS 'Contact', username AS 'Username', role AS 'Role', " +
                                 "created_at AS 'Created At' FROM users ORDER BY user_id DESC";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvUsers.DataSource = dt;

                        // Style DataGridView
                        dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        dgvUsers.MultiSelect = false;
                        dgvUsers.ReadOnly = true;
                        dgvUsers.AllowUserToAddRows = false;
                        dgvUsers.RowHeadersVisible = false;
                        dgvUsers.BackgroundColor = Color.White;
                        dgvUsers.BorderStyle = BorderStyle.None;
                        dgvUsers.DefaultCellStyle.SelectionBackColor = Color.FromArgb(46, 125, 50);
                        dgvUsers.DefaultCellStyle.SelectionForeColor = Color.White;
                        dgvUsers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 125, 50);
                        dgvUsers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                        dgvUsers.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                        dgvUsers.EnableHeadersVisualStyles = false;

                        lblTotalUsers.Text = $"Total Users: {dt.Rows.Count}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading users: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Add User Button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
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

                if (string.IsNullOrWhiteSpace(txtUsername.Text))
                {
                    errorProvider1.SetError(txtUsername, "Username is required");
                    isValid = false;
                }

                if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    errorProvider1.SetError(txtPassword, "Password is required");
                    isValid = false;
                }

                if (cmbRole.SelectedIndex == -1)
                {
                    errorProvider1.SetError(cmbRole, "Role is required");
                    isValid = false;
                }

                if (!isValid)
                {
                    MessageBox.Show("Please fill all required fields!", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Check if username or email already exists
                if (CheckUserExists(txtUsername.Text, txtEmail.Text))
                {
                    MessageBox.Show("Username or Email already exists!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Insert user
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"INSERT INTO users (name, email, contact, username, password, role) 
                                   VALUES (@name, @email, @contact, @username, @password, @role)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@contact", txtContact.Text.Trim());
                        cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                        cmd.Parameters.AddWithValue("@role", cmbRole.SelectedItem.ToString());

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("User added successfully! 🌱", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadUsers();
                            ClearFields();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding user: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Update User Button
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedUserId == -1)
                {
                    MessageBox.Show("Please select a user to update!", "Warning",
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

                if (cmbRole.SelectedIndex == -1)
                {
                    errorProvider1.SetError(cmbRole, "Role is required");
                    isValid = false;
                }

                if (!isValid)
                {
                    MessageBox.Show("Please fill all required fields!", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Update user
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"UPDATE users SET name = @name, email = @email, contact = @contact, 
                                   role = @role WHERE user_id = @userId";

                    // If password is provided, update it too
                    if (!string.IsNullOrWhiteSpace(txtPassword.Text))
                    {
                        query = @"UPDATE users SET name = @name, email = @email, contact = @contact, 
                                password = @password, role = @role WHERE user_id = @userId";
                    }

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@contact", txtContact.Text.Trim());
                        cmd.Parameters.AddWithValue("@role", cmbRole.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@userId", selectedUserId);

                        if (!string.IsNullOrWhiteSpace(txtPassword.Text))
                        {
                            cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                        }

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("User updated successfully! 🌱", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadUsers();
                            ClearFields();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating user: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Delete User Button
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedUserId == -1)
                {
                    MessageBox.Show("Please select a user to delete!", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (selectedUserId == adminId)
                {
                    MessageBox.Show("You cannot delete your own account!", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure you want to delete this user?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM users WHERE user_id = @userId";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@userId", selectedUserId);

                            int deleteResult = cmd.ExecuteNonQuery();

                            if (deleteResult > 0)
                            {
                                MessageBox.Show("User deleted successfully! 🌱", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadUsers();
                                ClearFields();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting user: {ex.Message}", "Error",
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
            txtPassword.Clear();
            cmbRole.SelectedIndex = -1;
            selectedUserId = -1;
            errorProvider1.Clear();
            txtName.Focus();
        }

        // DataGridView cell click - populate fields
        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvUsers.Rows[e.RowIndex];

                    selectedUserId = Convert.ToInt32(row.Cells["User ID"].Value);
                    txtName.Text = row.Cells["Name"].Value.ToString();
                    txtEmail.Text = row.Cells["Email"].Value.ToString();
                    txtContact.Text = row.Cells["Contact"].Value?.ToString() ?? "";
                    txtUsername.Text = row.Cells["Username"].Value.ToString();
                    txtUsername.ReadOnly = true; // Username cannot be changed
                    txtPassword.Clear(); // Don't show password
                    cmbRole.SelectedItem = row.Cells["Role"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error selecting user: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Check if user exists
        private bool CheckUserExists(string username, string email)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM users WHERE (username = @username OR email = @email) AND user_id != @userId";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@userId", selectedUserId);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        // Search functionality
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    LoadUsers();
                    return;
                }

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT user_id AS 'User ID', name AS 'Name', email AS 'Email', 
                                   contact AS 'Contact', username AS 'Username', role AS 'Role', 
                                   created_at AS 'Created At' FROM users 
                                   WHERE name LIKE @search OR email LIKE @search OR username LIKE @search 
                                   ORDER BY user_id DESC";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@search", "%" + txtSearch.Text + "%");
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvUsers.DataSource = dt;
                        lblTotalUsers.Text = $"Total Users: {dt.Rows.Count}";
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
            // Already on this form
            LoadUsers();
        }

        private void btnManageProducts_Click(object sender, EventArgs e)
        {
            ProductManagementForm productForm = new ProductManagementForm(adminId, adminName);
            productForm.Show();
            this.Hide();
        }

        private void btnManageCustomers_Click(object sender, EventArgs e)
        {
            CustomerManagementForm customerForm = new CustomerManagementForm(adminId, adminName);
            customerForm.Show();
            this.Hide();
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

        private void ManageUsersForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}