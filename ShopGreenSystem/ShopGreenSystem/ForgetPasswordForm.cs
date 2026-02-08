using System;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ShopGreenSystem
{
    public partial class ForgetPasswordForm : Form
    {
        // Database connection string
        private string connectionString = "Server=localhost;Port=3306;Database=shopGreen;Uid=root;Pwd=1234;";
        private string generatedCode = "";

        public ForgetPasswordForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // Send Reset Code Button Click
        private void btnSendCode_Click(object sender, EventArgs e)
        {
            try
            {
                // Clear previous errors
                errorProvider1.Clear();

                // Validation
                if (string.IsNullOrWhiteSpace(txtUsername.Text))
                {
                    errorProvider1.SetError(txtUsername, "Username is required");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    errorProvider1.SetError(txtEmail, "Email is required");
                    return;
                }

                if (!IsValidEmail(txtEmail.Text))
                {
                    errorProvider1.SetError(txtEmail, "Invalid email format");
                    return;
                }

                // Check if username and email match in database
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT user_id FROM users WHERE username = @username AND email = @email";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());

                        object result = cmd.ExecuteScalar();

                        if (result == null)
                        {
                            MessageBox.Show("Username and Email do not match!", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Generate 6-digit reset code
                        Random random = new Random();
                        generatedCode = random.Next(100000, 999999).ToString();

                        // In a real application, you would send this code via email
                        // For this demo, we'll show it in a message box
                        MessageBox.Show($"Your password reset code is: {generatedCode}\n\n" +
                            "In a production system, this would be sent to your email.\n" +
                            "Please enter this code in the verification field.",
                            "Reset Code Generated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Enable code input section
                        txtResetCode.Enabled = true;
                        btnVerifyCode.Enabled = true;
                        lblResetCode.Enabled = true;

                        // Optionally disable send button to prevent multiple codes
                        btnSendCode.Enabled = false;
                        btnSendCode.Text = "Code Sent";

                        /* 
                        // UNCOMMENT THIS SECTION IF YOU WANT TO SEND REAL EMAILS
                        // You'll need to configure your SMTP settings
                        
                        SendResetCodeEmail(txtEmail.Text.Trim(), generatedCode);
                        
                        MessageBox.Show("Reset code has been sent to your email!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        */
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Verify Code and Reset Password Button Click
        private void btnVerifyCode_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();

                // Validation
                if (string.IsNullOrWhiteSpace(txtResetCode.Text))
                {
                    errorProvider1.SetError(txtResetCode, "Reset code is required");
                    return;
                }

                // Verify the code
                if (txtResetCode.Text.Trim() != generatedCode)
                {
                    MessageBox.Show("Invalid reset code!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Generate new temporary password
                string newPassword = GenerateTemporaryPassword();

                // Update password in database
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE users SET password = @password WHERE username = @username AND email = @email";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@password", newPassword);
                        cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show($"Password reset successful! 🌱\n\n" +
                                $"Your new temporary password is: {newPassword}\n\n" +
                                "Please login with this password and change it in your profile.",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;

                            // Navigate to login
                            LoginForm loginForm = new LoginForm();
                            loginForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Password reset failed. Please try again.", "Error",
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

        // Generate temporary password
        private string GenerateTemporaryPassword()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, 8)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        // Email validation
        private bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }

        // Send email with reset code (Optional - requires SMTP configuration)
        private void SendResetCodeEmail(string toEmail, string code)
        {
            try
            {
                // Configure your SMTP settings here
                string fromEmail = "your-email@gmail.com"; // Replace with your email
                string fromPassword = "your-app-password"; // Replace with your app password

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(fromEmail);
                mail.To.Add(toEmail);
                mail.Subject = "ShopGreen - Password Reset Code";
                mail.Body = $"Your password reset code is: {code}\n\n" +
                           "This code will expire in 10 minutes.\n\n" +
                           "If you didn't request this, please ignore this email.";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential(fromEmail, fromPassword);
                smtp.EnableSsl = true;

                smtp.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Email sending failed: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Back to Login
        private void lblBackToLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        // Clear Button
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtEmail.Clear();
            txtResetCode.Clear();
            txtResetCode.Enabled = false;
            btnVerifyCode.Enabled = false;
            lblResetCode.Enabled = false;
            btnSendCode.Enabled = true;
            btnSendCode.Text = "Send Reset Code";
            generatedCode = "";
            errorProvider1.Clear();
            txtUsername.Focus();
        }

        // Hover effects
        private void btnSendCode_MouseEnter(object sender, EventArgs e)
        {
            if (btnSendCode.Enabled)
                btnSendCode.BackColor = Color.FromArgb(37, 99, 41);
        }

        private void btnSendCode_MouseLeave(object sender, EventArgs e)
        {
            if (btnSendCode.Enabled)
                btnSendCode.BackColor = Color.FromArgb(46, 125, 50);
        }

        private void btnVerifyCode_MouseEnter(object sender, EventArgs e)
        {
            if (btnVerifyCode.Enabled)
                btnVerifyCode.BackColor = Color.FromArgb(37, 99, 41);
        }

        private void btnVerifyCode_MouseLeave(object sender, EventArgs e)
        {
            if (btnVerifyCode.Enabled)
                btnVerifyCode.BackColor = Color.FromArgb(46, 125, 50);
        }

        private void ForgetPasswordForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void panelRight_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}