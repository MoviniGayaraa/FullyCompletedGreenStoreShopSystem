using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ShopGreenSystem
{
    public partial class RegisterForm : Form
    {
        // Database connection string
        private string connectionString = "Server=localhost;Port=3306;Database=shopGreen;Uid=root;Pwd=1234;";

        public RegisterForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // Register Button Click Event
        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                // Clear previous errors
                errorProvider1.Clear();

                // Validation
                bool isValid = true;

                // Validate Name
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    errorProvider1.SetError(txtName, "Name is required");
                    isValid = false;
                }

                // Validate Email
                if (string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    errorProvider1.SetError(txtEmail, "Email is required");
                    isValid = false;
                }
                else if (!IsValidEmail(txtEmail.Text))
                {
                    errorProvider1.SetError(txtEmail, "Invalid email format");
                    isValid = false;
                }

                // Validate Contact
                if (string.IsNullOrWhiteSpace(txtContact.Text))
                {
                    errorProvider1.SetError(txtContact, "Contact number is required");
                    isValid = false;
                }
                else if (!IsValidContact(txtContact.Text))
                {
                    errorProvider1.SetError(txtContact, "Contact must be 10 digits");
                    isValid = false;
                }

                // Validate Username
                if (string.IsNullOrWhiteSpace(txtUsername.Text))
                {
                    errorProvider1.SetError(txtUsername, "Username is required");
                    isValid = false;
                }
                else if (txtUsername.Text.Length < 4)
                {
                    errorProvider1.SetError(txtUsername, "Username must be at least 4 characters");
                    isValid = false;
                }

                // Validate Password
                if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    errorProvider1.SetError(txtPassword, "Password is required");
                    isValid = false;
                }
                else if (txtPassword.Text.Length < 6)
                {
                    errorProvider1.SetError(txtPassword, "Password must be at least 6 characters");
                    isValid = false;
                }

                // Validate Confirm Password
                if (string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
                {
                    errorProvider1.SetError(txtConfirmPassword, "Confirm password is required");
                    isValid = false;
                }
                else if (txtPassword.Text != txtConfirmPassword.Text)
                {
                    errorProvider1.SetError(txtConfirmPassword, "Passwords do not match");
                    isValid = false;
                }

                if (!isValid)
                {
                    MessageBox.Show("Please fix all errors before registering.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Check if username or email already exists
                if (CheckUserExists(txtUsername.Text, txtEmail.Text))
                {
                    MessageBox.Show("Username or Email already exists!", "Registration Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Insert into database
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"INSERT INTO users (name, email, contact, username, password, role) 
                                   VALUES (@name, @email, @contact, @username, @password, 'CUSTOMER')";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@contact", txtContact.Text.Trim());
                        cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", txtPassword.Text); // In production, hash this!

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Registration successful! 🌱\nYou can now login.", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                            // Navigate to login
                            LoginForm loginForm = new LoginForm();
                            loginForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Registration failed. Please try again.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Check if user already exists
        private bool CheckUserExists(string username, string email)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM users WHERE username = @username OR email = @email";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@email", email);

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

        // Email validation
        private bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }

        // Contact validation
        private bool IsValidContact(string contact)
        {
            string pattern = @"^\d{10}$";
            return Regex.IsMatch(contact, pattern);
        }

        // Clear Button
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtEmail.Clear();
            txtContact.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            chkShowPassword.Checked = false;
            errorProvider1.Clear();
            txtName.Focus();
        }

        // Show/Hide Password
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
            txtConfirmPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        // Back to Login
        private void lblBackToLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        // Hover effects
        private void btnRegister_MouseEnter(object sender, EventArgs e)
        {
            btnRegister.BackColor = Color.FromArgb(37, 99, 41);
        }

        private void btnRegister_MouseLeave(object sender, EventArgs e)
        {
            btnRegister.BackColor = Color.FromArgb(46, 125, 50);
        }

        // Only allow numbers in contact field
        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void panelRight_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}