namespace ShopGreenSystem
{
    partial class ForgetPasswordForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnSendCode;
        private System.Windows.Forms.Label lblResetCode;
        private System.Windows.Forms.TextBox txtResetCode;
        private System.Windows.Forms.Button btnVerifyCode;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblBackToLogin;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblInstructions;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panelLeft = new Panel();
            pictureBoxLogo = new PictureBox();
            panelRight = new Panel();
            lblInstructions = new Label();
            lblBackToLogin = new Label();
            btnClear = new Button();
            btnVerifyCode = new Button();
            txtResetCode = new TextBox();
            lblResetCode = new Label();
            btnSendCode = new Button();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtUsername = new TextBox();
            lblUsername = new Label();
            lblSubtitle = new Label();
            lblTitle = new Label();
            errorProvider1 = new ErrorProvider(components);
            panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(46, 125, 50);
            panelLeft.Controls.Add(pictureBoxLogo);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Margin = new Padding(3, 4, 3, 4);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(400, 812);
            panelLeft.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackColor = Color.Transparent;
            pictureBoxLogo.Location = new Point(50, 219);
            pictureBoxLogo.Margin = new Padding(3, 4, 3, 4);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(300, 375);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // panelRight
            // 
            panelRight.BackColor = Color.White;
            panelRight.Controls.Add(lblInstructions);
            panelRight.Controls.Add(lblBackToLogin);
            panelRight.Controls.Add(btnClear);
            panelRight.Controls.Add(btnVerifyCode);
            panelRight.Controls.Add(txtResetCode);
            panelRight.Controls.Add(lblResetCode);
            panelRight.Controls.Add(btnSendCode);
            panelRight.Controls.Add(txtEmail);
            panelRight.Controls.Add(lblEmail);
            panelRight.Controls.Add(txtUsername);
            panelRight.Controls.Add(lblUsername);
            panelRight.Controls.Add(lblSubtitle);
            panelRight.Controls.Add(lblTitle);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(400, 0);
            panelRight.Margin = new Padding(3, 4, 3, 4);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(500, 812);
            panelRight.TabIndex = 1;
            panelRight.Paint += panelRight_Paint;
            // 
            // lblInstructions
            // 
            lblInstructions.Font = new Font("Segoe UI", 9F);
            lblInstructions.ForeColor = Color.Gray;
            lblInstructions.Location = new Point(65, 150);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(370, 75);
            lblInstructions.TabIndex = 12;
            lblInstructions.Text = "Enter your username and email address. We will send you a reset code to verify your identity and create a new password.";
            // 
            // lblBackToLogin
            // 
            lblBackToLogin.AutoSize = true;
            lblBackToLogin.Cursor = Cursors.Hand;
            lblBackToLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBackToLogin.ForeColor = Color.FromArgb(46, 125, 50);
            lblBackToLogin.Location = new Point(170, 756);
            lblBackToLogin.Name = "lblBackToLogin";
            lblBackToLogin.Size = new Size(159, 20);
            lblBackToLogin.TabIndex = 11;
            lblBackToLogin.Text = "← Back to Login Page";
            lblBackToLogin.Click += lblBackToLogin_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(245, 245, 245);
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClear.ForeColor = Color.FromArgb(38, 50, 56);
            btnClear.Location = new Point(260, 669);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(150, 56);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnVerifyCode
            // 
            btnVerifyCode.BackColor = Color.FromArgb(46, 125, 50);
            btnVerifyCode.Cursor = Cursors.Hand;
            btnVerifyCode.Enabled = false;
            btnVerifyCode.FlatAppearance.BorderSize = 0;
            btnVerifyCode.FlatStyle = FlatStyle.Flat;
            btnVerifyCode.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnVerifyCode.ForeColor = Color.White;
            btnVerifyCode.Location = new Point(90, 669);
            btnVerifyCode.Margin = new Padding(3, 4, 3, 4);
            btnVerifyCode.Name = "btnVerifyCode";
            btnVerifyCode.Size = new Size(150, 56);
            btnVerifyCode.TabIndex = 9;
            btnVerifyCode.Text = "Verify Code";
            btnVerifyCode.UseVisualStyleBackColor = false;
            btnVerifyCode.Click += btnVerifyCode_Click;
            btnVerifyCode.MouseEnter += btnVerifyCode_MouseEnter;
            btnVerifyCode.MouseLeave += btnVerifyCode_MouseLeave;
            // 
            // txtResetCode
            // 
            txtResetCode.BorderStyle = BorderStyle.FixedSingle;
            txtResetCode.Enabled = false;
            txtResetCode.Font = new Font("Segoe UI", 11F);
            txtResetCode.Location = new Point(90, 569);
            txtResetCode.Margin = new Padding(3, 4, 3, 4);
            txtResetCode.MaxLength = 6;
            txtResetCode.Name = "txtResetCode";
            txtResetCode.Size = new Size(320, 32);
            txtResetCode.TabIndex = 8;
            txtResetCode.TextAlign = HorizontalAlignment.Center;
            // 
            // lblResetCode
            // 
            lblResetCode.AutoSize = true;
            lblResetCode.Enabled = false;
            lblResetCode.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblResetCode.ForeColor = Color.FromArgb(38, 50, 56);
            lblResetCode.Location = new Point(85, 531);
            lblResetCode.Name = "lblResetCode";
            lblResetCode.Size = new Size(209, 23);
            lblResetCode.TabIndex = 7;
            lblResetCode.Text = "Enter 6-Digit Reset Code";
            // 
            // btnSendCode
            // 
            btnSendCode.BackColor = Color.FromArgb(46, 125, 50);
            btnSendCode.Cursor = Cursors.Hand;
            btnSendCode.FlatAppearance.BorderSize = 0;
            btnSendCode.FlatStyle = FlatStyle.Flat;
            btnSendCode.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSendCode.ForeColor = Color.White;
            btnSendCode.Location = new Point(90, 438);
            btnSendCode.Margin = new Padding(3, 4, 3, 4);
            btnSendCode.Name = "btnSendCode";
            btnSendCode.Size = new Size(320, 56);
            btnSendCode.TabIndex = 6;
            btnSendCode.Text = "Send Reset Code";
            btnSendCode.UseVisualStyleBackColor = false;
            btnSendCode.Click += btnSendCode_Click;
            btnSendCode.MouseEnter += btnSendCode_MouseEnter;
            btnSendCode.MouseLeave += btnSendCode_MouseLeave;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.Location = new Point(90, 362);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(320, 32);
            txtEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(38, 50, 56);
            lblEmail.Location = new Point(85, 325);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(123, 23);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email Address";
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 11F);
            txtUsername.Location = new Point(90, 269);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(320, 32);
            txtUsername.TabIndex = 3;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUsername.ForeColor = Color.FromArgb(38, 50, 56);
            lblUsername.Location = new Point(85, 231);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(89, 23);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.Gray;
            lblSubtitle.Location = new Point(140, 112);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(232, 23);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Reset your account password";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(46, 125, 50);
            lblTitle.Location = new Point(125, 50);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(253, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Forgot Password";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ForgetPasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 812);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ForgetPasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Forgot Password - ShopGreen";
            FormClosing += ForgetPasswordForm_FormClosing;
            panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelRight.ResumeLayout(false);
            panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }
    }
}