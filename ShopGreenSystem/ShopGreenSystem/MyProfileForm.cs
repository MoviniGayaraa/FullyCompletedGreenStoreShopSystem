using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ShopGreenSystem
{
    public partial class MyProfileForm : Form
    {
        // Database connection string
        private string connectionString = "Server=localhost;Port=3306;Database=shopGreen;Uid=root;Pwd=1234;";
        private int customerId;
        private string customerName;

        public MyProfileForm(int userId, string userName)
        {
            InitializeComponent();
            this.customerId = userId;
            this.customerName = userName;
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadProfileData();
        }

        // Load customer profile data
        private void LoadProfileData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT 
                                    name,
                                    email,
                                    contact,
                                    username,
                                    created_at
                                   FROM users 
                                   WHERE user_id = @userId";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", customerId);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Display basic info
                                lblName.Text = reader["name"].ToString();
                                lblEmail.Text = reader["email"].ToString();
                                lblContact.Text = reader["contact"].ToString();
                                lblUsername.Text = reader["username"].ToString();
                                lblMemberSince.Text = $"Member since: {Convert.ToDateTime(reader["created_at"]):MMMM yyyy}";

                                // Set values in edit fields
                                txtName.Text = reader["name"].ToString();
                                txtEmail.Text = reader["email"].ToString();
                                txtContact.Text = reader["contact"].ToString();
                                txtUsername.Text = reader["username"].ToString();
                            }
                        }
                    }

                    // Load order history summary
                    LoadOrderHistory();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading profile: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Load order history summary
        private void LoadOrderHistory()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT 
                                    COUNT(*) as total_orders,
                                    COALESCE(SUM(CASE WHEN status = 'DELIVERED' THEN total_amount ELSE 0 END), 0) as total_spent,
                                    COALESCE(SUM(CASE WHEN status = 'PENDING' THEN 1 ELSE 0 END), 0) as pending_orders,
                                    COALESCE(SUM(CASE WHEN status = 'SHIPPED' THEN 1 ELSE 0 END), 0) as shipped_orders
                                   FROM orders 
                                   WHERE user_id = @userId";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", customerId);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblTotalOrders.Text = reader["total_orders"].ToString();
                                lblTotalSpent.Text = $"Rs. {Convert.ToDecimal(reader["total_spent"]):N2}";
                                lblPendingOrders.Text = reader["pending_orders"].ToString();
                                lblShippedOrders.Text = reader["shipped_orders"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading order history: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Enable edit mode
        private void EnableEditMode()
        {
            txtName.Enabled = true;
            txtEmail.Enabled = true;
            txtContact.Enabled = true;
            txtUsername.Enabled = true;
            txtPassword.Enabled = true;
            txtConfirmPassword.Enabled = true;

            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnEditProfile.Enabled = false;

            txtName.Focus();
        }

        // Disable edit mode
        private void DisableEditMode()
        {
            txtName.Enabled = false;
            txtEmail.Enabled = false;
            txtContact.Enabled = false;
            txtUsername.Enabled = false;
            txtPassword.Enabled = false;
            txtConfirmPassword.Enabled = false;

            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnEditProfile.Enabled = true;

            // Clear password fields
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
        }

        // Validate email format
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        // Validate contact number
        private bool IsValidContact(string contact)
        {
            return Regex.IsMatch(contact, @"^[0-9]{10}$");
        }

        // Validate form data
        private bool ValidateForm()
        {
            // Validate name
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter your name.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }

            // Validate email
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please enter your email address.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            // Validate contact
            if (string.IsNullOrWhiteSpace(txtContact.Text))
            {
                MessageBox.Show("Please enter your contact number.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContact.Focus();
                return false;
            }

            if (!IsValidContact(txtContact.Text))
            {
                MessageBox.Show("Please enter a valid 10-digit contact number.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContact.Focus();
                return false;
            }

            // Validate username
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Please enter a username.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return false;
            }

            // Check if passwords match (only if entered)
            if (!string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                if (txtPassword.Text != txtConfirmPassword.Text)
                {
                    MessageBox.Show("Passwords do not match.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Focus();
                    return false;
                }

                if (txtPassword.Text.Length < 6)
                {
                    MessageBox.Show("Password must be at least 6 characters long.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Focus();
                    return false;
                }
            }

            return true;
        }

        // Save profile changes
        private void SaveProfile()
        {
            try
            {
                if (!ValidateForm())
                    return;

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Check if email already exists (excluding current user)
                    string checkEmailQuery = "SELECT COUNT(*) FROM users WHERE email = @email AND user_id != @userId";
                    using (MySqlCommand checkEmailCmd = new MySqlCommand(checkEmailQuery, conn))
                    {
                        checkEmailCmd.Parameters.AddWithValue("@email", txtEmail.Text);
                        checkEmailCmd.Parameters.AddWithValue("@userId", customerId);
                        int emailCount = Convert.ToInt32(checkEmailCmd.ExecuteScalar());

                        if (emailCount > 0)
                        {
                            MessageBox.Show("This email is already registered by another user.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtEmail.Focus();
                            return;
                        }
                    }

                    // Check if username already exists (excluding current user)
                    string checkUserQuery = "SELECT COUNT(*) FROM users WHERE username = @username AND user_id != @userId";
                    using (MySqlCommand checkUserCmd = new MySqlCommand(checkUserQuery, conn))
                    {
                        checkUserCmd.Parameters.AddWithValue("@username", txtUsername.Text);
                        checkUserCmd.Parameters.AddWithValue("@userId", customerId);
                        int userCount = Convert.ToInt32(checkUserCmd.ExecuteScalar());

                        if (userCount > 0)
                        {
                            MessageBox.Show("This username is already taken.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtUsername.Focus();
                            return;
                        }
                    }

                    // Update profile
                    string updateQuery;
                    if (!string.IsNullOrWhiteSpace(txtPassword.Text))
                    {
                        // Update with password
                        updateQuery = @"UPDATE users SET 
                                       name = @name,
                                       email = @email,
                                       contact = @contact,
                                       username = @username,
                                       password = @password
                                       WHERE user_id = @userId";
                    }
                    else
                    {
                        // Update without password
                        updateQuery = @"UPDATE users SET 
                                       name = @name,
                                       email = @email,
                                       contact = @contact,
                                       username = @username
                                       WHERE user_id = @userId";
                    }

                    using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn))
                    {
                        updateCmd.Parameters.AddWithValue("@name", txtName.Text);
                        updateCmd.Parameters.AddWithValue("@email", txtEmail.Text);
                        updateCmd.Parameters.AddWithValue("@contact", txtContact.Text);
                        updateCmd.Parameters.AddWithValue("@username", txtUsername.Text);
                        updateCmd.Parameters.AddWithValue("@userId", customerId);

                        if (!string.IsNullOrWhiteSpace(txtPassword.Text))
                        {
                            updateCmd.Parameters.AddWithValue("@password", txtPassword.Text); // In production, encrypt this
                        }

                        int rowsAffected = updateCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Update displayed name
                            customerName = txtName.Text;

                            MessageBox.Show("Profile updated successfully! ✅", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Reload profile data and disable edit mode
                            LoadProfileData();
                            DisableEditMode();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update profile.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving profile: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Navigation Menu Buttons
        private void btnStore_Click(object sender, EventArgs e)
        {
            CustomerDashboardForm dashboardForm = new CustomerDashboardForm(customerId, customerName);
            dashboardForm.Show();
            this.Hide();
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
            // Already on this form
            LoadProfileData();
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

        // Profile management buttons
        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            EnableEditMode();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveProfile();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Discard all changes?", "Confirm Cancel",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LoadProfileData();
                DisableEditMode();
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            EnableEditMode();
            txtPassword.Focus();
        }

        private void btnViewOrderHistory_Click(object sender, EventArgs e)
        {
            TrackOrdersForm trackForm = new TrackOrdersForm(customerId, customerName);
            trackForm.Show();
            this.Hide();
        }

        // Hover effects for menu buttons
        private void MenuButton_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.FromArgb(37, 99, 41);
        }

        private void MenuButton_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != btnMyProfile) // Keep current page highlighted
            {
                btn.BackColor = Color.FromArgb(46, 125, 50);
            }
        }

        // Form closing
        private void MyProfileForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        // View password checkbox
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
                txtConfirmPassword.PasswordChar = '•';
            }
        }

        // Refresh profile
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadProfileData();
            MessageBox.Show("Profile refreshed! 👤", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}