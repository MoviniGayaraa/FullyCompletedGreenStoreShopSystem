using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ShopGreenSystem
{
    public partial class LoginForm : Form
    {
        // Database connection string
        private string connectionString = "Server=localhost;Port=3306;Database=shopGreen;Uid=root;Pwd=1234;";

        public LoginForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // Login Button Click Event
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                // Validation
                if (string.IsNullOrWhiteSpace(txtUsername.Text))
                {
                    errorProvider1.SetError(txtUsername, "Username is required");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    errorProvider1.SetError(txtPassword, "Password is required");
                    return;
                }

                // Clear errors
                errorProvider1.Clear();

                // Database authentication
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT user_id, name, role FROM users WHERE username = @username AND password = @password";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", txtPassword.Text); // In production, use hashed password

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Login successful
                                int userId = Convert.ToInt32(reader["user_id"]);
                                string userName = reader["name"].ToString();
                                string role = reader["role"].ToString();

                                MessageBox.Show($"Welcome, {userName}! 🌱", "Login Successful",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Navigate based on role
                                if (role == "ADMIN")
                                {
                                    AdminDashboardForm adminForm = new AdminDashboardForm(userId, userName);
                                    adminForm.Show();
                                }
                                else if (role == "CUSTOMER")
                                {
                                    CustomerDashboardForm customerForm = new CustomerDashboardForm(userId, userName);
                                    customerForm.Show();
                                }

                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password!", "Login Failed",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
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

        // Show/Hide Password
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        // Navigate to Register Form
        private void lblRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        // Navigate to Forgot Password Form
        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            ForgetPasswordForm forgotForm = new ForgetPasswordForm();
            forgotForm.Show();
            this.Hide();
        }

        // Clear fields
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            chkShowPassword.Checked = false;
            errorProvider1.Clear();
            txtUsername.Focus();
        }

        // Hover effects for modern UI
        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.FromArgb(37, 99, 41); // Darker green
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.FromArgb(46, 125, 50); // Original green
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void panelRight_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}