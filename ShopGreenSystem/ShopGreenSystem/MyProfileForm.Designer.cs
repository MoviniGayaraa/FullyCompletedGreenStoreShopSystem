namespace ShopGreenSystem
{
    partial class MyProfileForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button btnStore;
        private System.Windows.Forms.Button btnBrowseProducts;
        private System.Windows.Forms.Button btnMyCart;
        private System.Windows.Forms.Button btnTrackOrders;
        private System.Windows.Forms.Button btnMyProfile;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panelProfileInfo;
        private System.Windows.Forms.Label lblProfileTitle;
        private System.Windows.Forms.Label lblNameLabel;
        private System.Windows.Forms.Label lblEmailLabel;
        private System.Windows.Forms.Label lblContactLabel;
        private System.Windows.Forms.Label lblUsernameLabel;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblMemberSince;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnViewOrderHistory;
        private System.Windows.Forms.Panel panelEditProfile;
        private System.Windows.Forms.Label lblEditTitle;
        private System.Windows.Forms.Label lblEditName;
        private System.Windows.Forms.Label lblEditEmail;
        private System.Windows.Forms.Label lblEditContact;
        private System.Windows.Forms.Label lblEditUsername;
        private System.Windows.Forms.Label lblEditPassword;
        private System.Windows.Forms.Label lblEditConfirmPassword;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.Panel panelOrderStats;
        private System.Windows.Forms.Label lblOrderStatsTitle;
        private System.Windows.Forms.Label lblTotalOrdersLabel;
        private System.Windows.Forms.Label lblTotalSpentLabel;
        private System.Windows.Forms.Label lblPendingOrdersLabel;
        private System.Windows.Forms.Label lblShippedOrdersLabel;
        private System.Windows.Forms.Label lblTotalOrders;
        private System.Windows.Forms.Label lblTotalSpent;
        private System.Windows.Forms.Label lblPendingOrders;
        private System.Windows.Forms.Label lblShippedOrders;

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
            panelMenu = new Panel();
            pictureBoxLogo = new PictureBox();
            btnLogout = new Button();
            btnMyProfile = new Button();
            btnTrackOrders = new Button();
            btnMyCart = new Button();
            btnBrowseProducts = new Button();
            btnStore = new Button();
            panelTop = new Panel();
            btnRefresh = new Button();
            lblWelcome = new Label();
            lblTitle = new Label();
            panelMain = new Panel();
            panelOrderStats = new Panel();
            lblShippedOrders = new Label();
            lblPendingOrders = new Label();
            lblTotalSpent = new Label();
            lblTotalOrders = new Label();
            lblShippedOrdersLabel = new Label();
            lblPendingOrdersLabel = new Label();
            lblTotalSpentLabel = new Label();
            lblTotalOrdersLabel = new Label();
            lblOrderStatsTitle = new Label();
            panelEditProfile = new Panel();
            chkShowPassword = new CheckBox();
            btnCancel = new Button();
            btnSave = new Button();
            txtConfirmPassword = new TextBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            txtContact = new TextBox();
            txtEmail = new TextBox();
            txtName = new TextBox();
            lblEditConfirmPassword = new Label();
            lblEditPassword = new Label();
            lblEditUsername = new Label();
            lblEditContact = new Label();
            lblEditEmail = new Label();
            lblEditName = new Label();
            lblEditTitle = new Label();
            panelProfileInfo = new Panel();
            btnViewOrderHistory = new Button();
            btnChangePassword = new Button();
            btnEditProfile = new Button();
            lblMemberSince = new Label();
            lblUsername = new Label();
            lblContact = new Label();
            lblEmail = new Label();
            lblName = new Label();
            lblUsernameLabel = new Label();
            lblContactLabel = new Label();
            lblEmailLabel = new Label();
            lblNameLabel = new Label();
            lblProfileTitle = new Label();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelTop.SuspendLayout();
            panelMain.SuspendLayout();
            panelOrderStats.SuspendLayout();
            panelEditProfile.SuspendLayout();
            panelProfileInfo.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(46, 125, 50);
            panelMenu.Controls.Add(pictureBoxLogo);
            panelMenu.Controls.Add(btnLogout);
            panelMenu.Controls.Add(btnMyProfile);
            panelMenu.Controls.Add(btnTrackOrders);
            panelMenu.Controls.Add(btnMyCart);
            panelMenu.Controls.Add(btnBrowseProducts);
            panelMenu.Controls.Add(btnStore);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(3, 4, 3, 4);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(250, 875);
            panelMenu.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackColor = Color.Transparent;
            pictureBoxLogo.Location = new Point(50, 25);
            pictureBoxLogo.Margin = new Padding(3, 4, 3, 4);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(150, 188);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 6;
            pictureBoxLogo.TabStop = false;
            // 
            // btnLogout
            // 
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(0, 800);
            btnLogout.Margin = new Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(250, 62);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "🚪 Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnMyProfile
            // 
            btnMyProfile.BackColor = Color.FromArgb(37, 99, 41);
            btnMyProfile.Cursor = Cursors.Hand;
            btnMyProfile.FlatAppearance.BorderSize = 0;
            btnMyProfile.FlatStyle = FlatStyle.Flat;
            btnMyProfile.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnMyProfile.ForeColor = Color.White;
            btnMyProfile.Location = new Point(0, 500);
            btnMyProfile.Margin = new Padding(3, 4, 3, 4);
            btnMyProfile.Name = "btnMyProfile";
            btnMyProfile.Size = new Size(250, 62);
            btnMyProfile.TabIndex = 4;
            btnMyProfile.Text = "👤 My Profile";
            btnMyProfile.TextAlign = ContentAlignment.MiddleLeft;
            btnMyProfile.UseVisualStyleBackColor = false;
            btnMyProfile.Click += btnMyProfile_Click;
            // 
            // btnTrackOrders
            // 
            btnTrackOrders.Cursor = Cursors.Hand;
            btnTrackOrders.FlatAppearance.BorderSize = 0;
            btnTrackOrders.FlatStyle = FlatStyle.Flat;
            btnTrackOrders.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnTrackOrders.ForeColor = Color.White;
            btnTrackOrders.Location = new Point(0, 425);
            btnTrackOrders.Margin = new Padding(3, 4, 3, 4);
            btnTrackOrders.Name = "btnTrackOrders";
            btnTrackOrders.Size = new Size(250, 62);
            btnTrackOrders.TabIndex = 3;
            btnTrackOrders.Text = "📦 Track Orders";
            btnTrackOrders.TextAlign = ContentAlignment.MiddleLeft;
            btnTrackOrders.UseVisualStyleBackColor = true;
            btnTrackOrders.Click += btnTrackOrders_Click;
            btnTrackOrders.MouseEnter += MenuButton_MouseEnter;
            btnTrackOrders.MouseLeave += MenuButton_MouseLeave;
            // 
            // btnMyCart
            // 
            btnMyCart.Cursor = Cursors.Hand;
            btnMyCart.FlatAppearance.BorderSize = 0;
            btnMyCart.FlatStyle = FlatStyle.Flat;
            btnMyCart.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnMyCart.ForeColor = Color.White;
            btnMyCart.Location = new Point(0, 350);
            btnMyCart.Margin = new Padding(3, 4, 3, 4);
            btnMyCart.Name = "btnMyCart";
            btnMyCart.Size = new Size(250, 62);
            btnMyCart.TabIndex = 2;
            btnMyCart.Text = "\U0001f6d2 My Cart";
            btnMyCart.TextAlign = ContentAlignment.MiddleLeft;
            btnMyCart.UseVisualStyleBackColor = true;
            btnMyCart.Click += btnMyCart_Click;
            btnMyCart.MouseEnter += MenuButton_MouseEnter;
            btnMyCart.MouseLeave += MenuButton_MouseLeave;
            // 
            // btnBrowseProducts
            // 
            btnBrowseProducts.Cursor = Cursors.Hand;
            btnBrowseProducts.FlatAppearance.BorderSize = 0;
            btnBrowseProducts.FlatStyle = FlatStyle.Flat;
            btnBrowseProducts.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnBrowseProducts.ForeColor = Color.White;
            btnBrowseProducts.Location = new Point(0, 275);
            btnBrowseProducts.Margin = new Padding(3, 4, 3, 4);
            btnBrowseProducts.Name = "btnBrowseProducts";
            btnBrowseProducts.Size = new Size(250, 62);
            btnBrowseProducts.TabIndex = 1;
            btnBrowseProducts.Text = "🔍 Browse Products";
            btnBrowseProducts.TextAlign = ContentAlignment.MiddleLeft;
            btnBrowseProducts.UseVisualStyleBackColor = true;
            btnBrowseProducts.Click += btnBrowseProducts_Click;
            btnBrowseProducts.MouseEnter += MenuButton_MouseEnter;
            btnBrowseProducts.MouseLeave += MenuButton_MouseLeave;
            // 
            // btnStore
            // 
            btnStore.Cursor = Cursors.Hand;
            btnStore.FlatAppearance.BorderSize = 0;
            btnStore.FlatStyle = FlatStyle.Flat;
            btnStore.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnStore.ForeColor = Color.White;
            btnStore.Location = new Point(0, 200);
            btnStore.Margin = new Padding(3, 4, 3, 4);
            btnStore.Name = "btnStore";
            btnStore.Size = new Size(250, 62);
            btnStore.TabIndex = 0;
            btnStore.Text = "🏪 Store";
            btnStore.TextAlign = ContentAlignment.MiddleLeft;
            btnStore.UseVisualStyleBackColor = true;
            btnStore.Click += btnStore_Click;
            btnStore.MouseEnter += MenuButton_MouseEnter;
            btnStore.MouseLeave += MenuButton_MouseLeave;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.White;
            panelTop.Controls.Add(btnRefresh);
            panelTop.Controls.Add(lblWelcome);
            panelTop.Controls.Add(lblTitle);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(250, 0);
            panelTop.Margin = new Padding(3, 4, 3, 4);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(950, 125);
            panelTop.TabIndex = 1;
            panelTop.Paint += panelTop_Paint;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(46, 125, 50);
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(800, 38);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(120, 50);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "🔄 Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 12F);
            lblWelcome.ForeColor = Color.Gray;
            lblWelcome.Location = new Point(30, 75);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(192, 28);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome, Customer!";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(46, 125, 50);
            lblTitle.Location = new Point(25, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(223, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ShopGreen 🌱";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(245, 245, 245);
            panelMain.Controls.Add(panelOrderStats);
            panelMain.Controls.Add(panelEditProfile);
            panelMain.Controls.Add(panelProfileInfo);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(250, 125);
            panelMain.Margin = new Padding(3, 4, 3, 4);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(20, 25, 20, 25);
            panelMain.Size = new Size(950, 750);
            panelMain.TabIndex = 2;
            // 
            // panelOrderStats
            // 
            panelOrderStats.BackColor = Color.White;
            panelOrderStats.Controls.Add(lblShippedOrders);
            panelOrderStats.Controls.Add(lblPendingOrders);
            panelOrderStats.Controls.Add(lblTotalSpent);
            panelOrderStats.Controls.Add(lblTotalOrders);
            panelOrderStats.Controls.Add(lblShippedOrdersLabel);
            panelOrderStats.Controls.Add(lblPendingOrdersLabel);
            panelOrderStats.Controls.Add(lblTotalSpentLabel);
            panelOrderStats.Controls.Add(lblTotalOrdersLabel);
            panelOrderStats.Controls.Add(lblOrderStatsTitle);
            panelOrderStats.Location = new Point(480, 25);
            panelOrderStats.Margin = new Padding(3, 4, 3, 4);
            panelOrderStats.Name = "panelOrderStats";
            panelOrderStats.Size = new Size(450, 700);
            panelOrderStats.TabIndex = 2;
            // 
            // lblShippedOrders
            // 
            lblShippedOrders.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblShippedOrders.ForeColor = Color.FromArgb(33, 150, 243);
            lblShippedOrders.Location = new Point(20, 450);
            lblShippedOrders.Name = "lblShippedOrders";
            lblShippedOrders.Size = new Size(410, 80);
            lblShippedOrders.TabIndex = 8;
            lblShippedOrders.Text = "0";
            lblShippedOrders.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPendingOrders
            // 
            lblPendingOrders.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblPendingOrders.ForeColor = Color.FromArgb(255, 152, 0);
            lblPendingOrders.Location = new Point(20, 320);
            lblPendingOrders.Name = "lblPendingOrders";
            lblPendingOrders.Size = new Size(410, 80);
            lblPendingOrders.TabIndex = 7;
            lblPendingOrders.Text = "0";
            lblPendingOrders.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalSpent
            // 
            lblTotalSpent.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTotalSpent.ForeColor = Color.FromArgb(156, 39, 176);
            lblTotalSpent.Location = new Point(20, 190);
            lblTotalSpent.Name = "lblTotalSpent";
            lblTotalSpent.Size = new Size(410, 80);
            lblTotalSpent.TabIndex = 6;
            lblTotalSpent.Text = "Rs. 0.00";
            lblTotalSpent.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalOrders
            // 
            lblTotalOrders.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblTotalOrders.ForeColor = Color.FromArgb(46, 125, 50);
            lblTotalOrders.Location = new Point(20, 60);
            lblTotalOrders.Name = "lblTotalOrders";
            lblTotalOrders.Size = new Size(410, 80);
            lblTotalOrders.TabIndex = 5;
            lblTotalOrders.Text = "0";
            lblTotalOrders.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblShippedOrdersLabel
            // 
            lblShippedOrdersLabel.AutoSize = true;
            lblShippedOrdersLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblShippedOrdersLabel.ForeColor = Color.FromArgb(38, 50, 56);
            lblShippedOrdersLabel.Location = new Point(20, 420);
            lblShippedOrdersLabel.Name = "lblShippedOrdersLabel";
            lblShippedOrdersLabel.Size = new Size(191, 28);
            lblShippedOrdersLabel.TabIndex = 4;
            lblShippedOrdersLabel.Text = "🚚 Shipped Orders";
            // 
            // lblPendingOrdersLabel
            // 
            lblPendingOrdersLabel.AutoSize = true;
            lblPendingOrdersLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPendingOrdersLabel.ForeColor = Color.FromArgb(38, 50, 56);
            lblPendingOrdersLabel.Location = new Point(20, 290);
            lblPendingOrdersLabel.Name = "lblPendingOrdersLabel";
            lblPendingOrdersLabel.Size = new Size(191, 28);
            lblPendingOrdersLabel.TabIndex = 3;
            lblPendingOrdersLabel.Text = "⏳ Pending Orders";
            // 
            // lblTotalSpentLabel
            // 
            lblTotalSpentLabel.AutoSize = true;
            lblTotalSpentLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalSpentLabel.ForeColor = Color.FromArgb(38, 50, 56);
            lblTotalSpentLabel.Location = new Point(20, 160);
            lblTotalSpentLabel.Name = "lblTotalSpentLabel";
            lblTotalSpentLabel.Size = new Size(153, 28);
            lblTotalSpentLabel.TabIndex = 2;
            lblTotalSpentLabel.Text = "💰 Total Spent";
            // 
            // lblTotalOrdersLabel
            // 
            lblTotalOrdersLabel.AutoSize = true;
            lblTotalOrdersLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalOrdersLabel.ForeColor = Color.FromArgb(38, 50, 56);
            lblTotalOrdersLabel.Location = new Point(20, 30);
            lblTotalOrdersLabel.Name = "lblTotalOrdersLabel";
            lblTotalOrdersLabel.Size = new Size(162, 28);
            lblTotalOrdersLabel.TabIndex = 1;
            lblTotalOrdersLabel.Text = "📋 Total Orders";
            // 
            // lblOrderStatsTitle
            // 
            lblOrderStatsTitle.AutoSize = true;
            lblOrderStatsTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblOrderStatsTitle.ForeColor = Color.FromArgb(46, 125, 50);
            lblOrderStatsTitle.Location = new Point(20, 580);
            lblOrderStatsTitle.Name = "lblOrderStatsTitle";
            lblOrderStatsTitle.Size = new Size(331, 32);
            lblOrderStatsTitle.TabIndex = 0;
            lblOrderStatsTitle.Text = "📊 Your Shopping Statistics";
            lblOrderStatsTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelEditProfile
            // 
            panelEditProfile.BackColor = Color.White;
            panelEditProfile.Controls.Add(chkShowPassword);
            panelEditProfile.Controls.Add(btnCancel);
            panelEditProfile.Controls.Add(btnSave);
            panelEditProfile.Controls.Add(txtConfirmPassword);
            panelEditProfile.Controls.Add(txtPassword);
            panelEditProfile.Controls.Add(txtUsername);
            panelEditProfile.Controls.Add(txtContact);
            panelEditProfile.Controls.Add(txtEmail);
            panelEditProfile.Controls.Add(txtName);
            panelEditProfile.Controls.Add(lblEditConfirmPassword);
            panelEditProfile.Controls.Add(lblEditPassword);
            panelEditProfile.Controls.Add(lblEditUsername);
            panelEditProfile.Controls.Add(lblEditContact);
            panelEditProfile.Controls.Add(lblEditEmail);
            panelEditProfile.Controls.Add(lblEditName);
            panelEditProfile.Controls.Add(lblEditTitle);
            panelEditProfile.Location = new Point(20, 275);
            panelEditProfile.Margin = new Padding(3, 4, 3, 4);
            panelEditProfile.Name = "panelEditProfile";
            panelEditProfile.Size = new Size(450, 450);
            panelEditProfile.TabIndex = 1;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Font = new Font("Segoe UI", 9F);
            chkShowPassword.Location = new Point(20, 360);
            chkShowPassword.Margin = new Padding(3, 4, 3, 4);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(132, 24);
            chkShowPassword.TabIndex = 15;
            chkShowPassword.Text = "Show Password";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(189, 189, 189);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(230, 400);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(200, 35);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "❌ Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(46, 125, 50);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(20, 400);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(200, 35);
            btnSave.TabIndex = 13;
            btnSave.Text = "💾 Save Changes";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Enabled = false;
            txtConfirmPassword.Font = new Font("Segoe UI", 10F);
            txtConfirmPassword.Location = new Point(20, 320);
            txtConfirmPassword.Margin = new Padding(3, 4, 3, 4);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '•';
            txtConfirmPassword.Size = new Size(410, 30);
            txtConfirmPassword.TabIndex = 12;
            // 
            // txtPassword
            // 
            txtPassword.Enabled = false;
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.Location = new Point(20, 260);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new Size(410, 30);
            txtPassword.TabIndex = 11;
            // 
            // txtUsername
            // 
            txtUsername.Enabled = false;
            txtUsername.Font = new Font("Segoe UI", 10F);
            txtUsername.Location = new Point(20, 200);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(410, 30);
            txtUsername.TabIndex = 10;
            // 
            // txtContact
            // 
            txtContact.Enabled = false;
            txtContact.Font = new Font("Segoe UI", 10F);
            txtContact.Location = new Point(20, 140);
            txtContact.Margin = new Padding(3, 4, 3, 4);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(410, 30);
            txtContact.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Enabled = false;
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(20, 80);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(410, 30);
            txtEmail.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.Enabled = false;
            txtName.Font = new Font("Segoe UI", 10F);
            txtName.Location = new Point(20, 20);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(410, 30);
            txtName.TabIndex = 7;
            // 
            // lblEditConfirmPassword
            // 
            lblEditConfirmPassword.AutoSize = true;
            lblEditConfirmPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEditConfirmPassword.ForeColor = Color.FromArgb(46, 125, 50);
            lblEditConfirmPassword.Location = new Point(20, 295);
            lblEditConfirmPassword.Name = "lblEditConfirmPassword";
            lblEditConfirmPassword.Size = new Size(141, 20);
            lblEditConfirmPassword.TabIndex = 6;
            lblEditConfirmPassword.Text = "Confirm Password:";
            // 
            // lblEditPassword
            // 
            lblEditPassword.AutoSize = true;
            lblEditPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEditPassword.ForeColor = Color.FromArgb(46, 125, 50);
            lblEditPassword.Location = new Point(20, 235);
            lblEditPassword.Name = "lblEditPassword";
            lblEditPassword.Size = new Size(116, 20);
            lblEditPassword.TabIndex = 5;
            lblEditPassword.Text = "New Password:";
            // 
            // lblEditUsername
            // 
            lblEditUsername.AutoSize = true;
            lblEditUsername.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEditUsername.ForeColor = Color.FromArgb(46, 125, 50);
            lblEditUsername.Location = new Point(20, 175);
            lblEditUsername.Name = "lblEditUsername";
            lblEditUsername.Size = new Size(84, 20);
            lblEditUsername.TabIndex = 4;
            lblEditUsername.Text = "Username:";
            // 
            // lblEditContact
            // 
            lblEditContact.AutoSize = true;
            lblEditContact.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEditContact.ForeColor = Color.FromArgb(46, 125, 50);
            lblEditContact.Location = new Point(20, 115);
            lblEditContact.Name = "lblEditContact";
            lblEditContact.Size = new Size(115, 20);
            lblEditContact.TabIndex = 3;
            lblEditContact.Text = "Contact Phone:";
            // 
            // lblEditEmail
            // 
            lblEditEmail.AutoSize = true;
            lblEditEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEditEmail.ForeColor = Color.FromArgb(46, 125, 50);
            lblEditEmail.Location = new Point(20, 55);
            lblEditEmail.Name = "lblEditEmail";
            lblEditEmail.Size = new Size(112, 20);
            lblEditEmail.TabIndex = 2;
            lblEditEmail.Text = "Email Address:";
            // 
            // lblEditName
            // 
            lblEditName.AutoSize = true;
            lblEditName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEditName.ForeColor = Color.FromArgb(46, 125, 50);
            lblEditName.Location = new Point(20, 0);
            lblEditName.Name = "lblEditName";
            lblEditName.Size = new Size(55, 20);
            lblEditName.TabIndex = 1;
            lblEditName.Text = "Name:";
            // 
            // lblEditTitle
            // 
            lblEditTitle.AutoSize = true;
            lblEditTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblEditTitle.ForeColor = Color.FromArgb(46, 125, 50);
            lblEditTitle.Location = new Point(20, 0);
            lblEditTitle.Name = "lblEditTitle";
            lblEditTitle.Size = new Size(242, 32);
            lblEditTitle.TabIndex = 0;
            lblEditTitle.Text = "✏️ Edit Your Profile";
            lblEditTitle.Visible = false;
            // 
            // panelProfileInfo
            // 
            panelProfileInfo.BackColor = Color.White;
            panelProfileInfo.Controls.Add(btnViewOrderHistory);
            panelProfileInfo.Controls.Add(btnChangePassword);
            panelProfileInfo.Controls.Add(btnEditProfile);
            panelProfileInfo.Controls.Add(lblMemberSince);
            panelProfileInfo.Controls.Add(lblUsername);
            panelProfileInfo.Controls.Add(lblContact);
            panelProfileInfo.Controls.Add(lblEmail);
            panelProfileInfo.Controls.Add(lblName);
            panelProfileInfo.Controls.Add(lblUsernameLabel);
            panelProfileInfo.Controls.Add(lblContactLabel);
            panelProfileInfo.Controls.Add(lblEmailLabel);
            panelProfileInfo.Controls.Add(lblNameLabel);
            panelProfileInfo.Controls.Add(lblProfileTitle);
            panelProfileInfo.Location = new Point(20, 25);
            panelProfileInfo.Margin = new Padding(3, 4, 3, 4);
            panelProfileInfo.Name = "panelProfileInfo";
            panelProfileInfo.Size = new Size(450, 225);
            panelProfileInfo.TabIndex = 0;
            // 
            // btnViewOrderHistory
            // 
            btnViewOrderHistory.BackColor = Color.FromArgb(33, 150, 243);
            btnViewOrderHistory.Cursor = Cursors.Hand;
            btnViewOrderHistory.FlatStyle = FlatStyle.Flat;
            btnViewOrderHistory.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnViewOrderHistory.ForeColor = Color.White;
            btnViewOrderHistory.Location = new Point(150, 175);
            btnViewOrderHistory.Margin = new Padding(3, 4, 3, 4);
            btnViewOrderHistory.Name = "btnViewOrderHistory";
            btnViewOrderHistory.Size = new Size(130, 35);
            btnViewOrderHistory.TabIndex = 12;
            btnViewOrderHistory.Text = "📦 Orders";
            btnViewOrderHistory.UseVisualStyleBackColor = false;
            btnViewOrderHistory.Click += btnViewOrderHistory_Click;
            // 
            // btnChangePassword
            // 
            btnChangePassword.BackColor = Color.FromArgb(255, 152, 0);
            btnChangePassword.Cursor = Cursors.Hand;
            btnChangePassword.FlatStyle = FlatStyle.Flat;
            btnChangePassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnChangePassword.ForeColor = Color.White;
            btnChangePassword.Location = new Point(290, 175);
            btnChangePassword.Margin = new Padding(3, 4, 3, 4);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(140, 35);
            btnChangePassword.TabIndex = 11;
            btnChangePassword.Text = "🔑 Password";
            btnChangePassword.UseVisualStyleBackColor = false;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // btnEditProfile
            // 
            btnEditProfile.BackColor = Color.FromArgb(46, 125, 50);
            btnEditProfile.Cursor = Cursors.Hand;
            btnEditProfile.FlatStyle = FlatStyle.Flat;
            btnEditProfile.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEditProfile.ForeColor = Color.White;
            btnEditProfile.Location = new Point(20, 175);
            btnEditProfile.Margin = new Padding(3, 4, 3, 4);
            btnEditProfile.Name = "btnEditProfile";
            btnEditProfile.Size = new Size(120, 35);
            btnEditProfile.TabIndex = 10;
            btnEditProfile.Text = "✏️ Edit Profile";
            btnEditProfile.UseVisualStyleBackColor = false;
            btnEditProfile.Click += btnEditProfile_Click;
            // 
            // lblMemberSince
            // 
            lblMemberSince.AutoSize = true;
            lblMemberSince.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblMemberSince.ForeColor = Color.Gray;
            lblMemberSince.Location = new Point(20, 150);
            lblMemberSince.Name = "lblMemberSince";
            lblMemberSince.Size = new Size(189, 20);
            lblMemberSince.TabIndex = 9;
            lblMemberSince.Text = "Member since: January 2024";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUsername.ForeColor = Color.FromArgb(38, 50, 56);
            lblUsername.Location = new Point(120, 120);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(87, 23);
            lblUsername.TabIndex = 8;
            lblUsername.Text = "username";
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblContact.ForeColor = Color.FromArgb(38, 50, 56);
            lblContact.Location = new Point(120, 90);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(110, 23);
            lblContact.TabIndex = 7;
            lblContact.Text = "0770000000";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(38, 50, 56);
            lblEmail.Location = new Point(120, 60);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(183, 23);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "customer@email.com";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblName.ForeColor = Color.FromArgb(38, 50, 56);
            lblName.Location = new Point(120, 30);
            lblName.Name = "lblName";
            lblName.Size = new Size(101, 23);
            lblName.TabIndex = 5;
            lblName.Text = "John Smith";
            // 
            // lblUsernameLabel
            // 
            lblUsernameLabel.AutoSize = true;
            lblUsernameLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUsernameLabel.ForeColor = Color.FromArgb(46, 125, 50);
            lblUsernameLabel.Location = new Point(20, 120);
            lblUsernameLabel.Name = "lblUsernameLabel";
            lblUsernameLabel.Size = new Size(94, 23);
            lblUsernameLabel.TabIndex = 4;
            lblUsernameLabel.Text = "Username:";
            // 
            // lblContactLabel
            // 
            lblContactLabel.AutoSize = true;
            lblContactLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblContactLabel.ForeColor = Color.FromArgb(46, 125, 50);
            lblContactLabel.Location = new Point(20, 90);
            lblContactLabel.Name = "lblContactLabel";
            lblContactLabel.Size = new Size(77, 23);
            lblContactLabel.TabIndex = 3;
            lblContactLabel.Text = "Contact:";
            // 
            // lblEmailLabel
            // 
            lblEmailLabel.AutoSize = true;
            lblEmailLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEmailLabel.ForeColor = Color.FromArgb(46, 125, 50);
            lblEmailLabel.Location = new Point(20, 60);
            lblEmailLabel.Name = "lblEmailLabel";
            lblEmailLabel.Size = new Size(59, 23);
            lblEmailLabel.TabIndex = 2;
            lblEmailLabel.Text = "Email:";
            // 
            // lblNameLabel
            // 
            lblNameLabel.AutoSize = true;
            lblNameLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNameLabel.ForeColor = Color.FromArgb(46, 125, 50);
            lblNameLabel.Location = new Point(20, 30);
            lblNameLabel.Name = "lblNameLabel";
            lblNameLabel.Size = new Size(62, 23);
            lblNameLabel.TabIndex = 1;
            lblNameLabel.Text = "Name:";
            // 
            // lblProfileTitle
            // 
            lblProfileTitle.AutoSize = true;
            lblProfileTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblProfileTitle.ForeColor = Color.FromArgb(46, 125, 50);
            lblProfileTitle.Location = new Point(20, 0);
            lblProfileTitle.Name = "lblProfileTitle";
            lblProfileTitle.Size = new Size(191, 32);
            lblProfileTitle.TabIndex = 0;
            lblProfileTitle.Text = "👤 Your Profile";
            // 
            // MyProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 875);
            Controls.Add(panelMain);
            Controls.Add(panelTop);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MyProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "My Profile - ShopGreen";
            FormClosing += MyProfileForm_FormClosing;
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelMain.ResumeLayout(false);
            panelOrderStats.ResumeLayout(false);
            panelOrderStats.PerformLayout();
            panelEditProfile.ResumeLayout(false);
            panelEditProfile.PerformLayout();
            panelProfileInfo.ResumeLayout(false);
            panelProfileInfo.PerformLayout();
            ResumeLayout(false);
        }
    }
}