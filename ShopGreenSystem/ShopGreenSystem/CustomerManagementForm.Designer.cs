namespace ShopGreenSystem
{
    partial class CustomerManagementForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Button btnManageProducts;
        private System.Windows.Forms.Button btnManageCustomers;
        private System.Windows.Forms.Button btnManageOrders;
        private System.Windows.Forms.Button btnGenerateReports;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTotalCustomers;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnViewOrders;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblSelectedCustomer;
        private System.Windows.Forms.Panel panelCard1;
        private System.Windows.Forms.Panel panelCard2;
        private System.Windows.Forms.Panel panelCard3;
        private System.Windows.Forms.Label lblTotalCustomersTitle;
        private System.Windows.Forms.Label lblTotalCustomersCount;
        private System.Windows.Forms.Label lblActiveCustomersTitle;
        private System.Windows.Forms.Label lblActiveCustomersCount;
        private System.Windows.Forms.Label lblNewCustomersTitle;
        private System.Windows.Forms.Label lblNewCustomersCount;

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
            panelMenu = new Panel();
            pictureBoxLogo = new PictureBox();
            btnLogout = new Button();
            btnGenerateReports = new Button();
            btnManageOrders = new Button();
            btnManageCustomers = new Button();
            btnManageProducts = new Button();
            btnManageUsers = new Button();
            btnHome = new Button();
            panelTop = new Panel();
            btnRefresh = new Button();
            lblTotalCustomers = new Label();
            txtSearch = new TextBox();
            lblSearch = new Label();
            lblTitle = new Label();
            panelMain = new Panel();
            panelRight = new Panel();
            dgvCustomers = new DataGridView();
            panelStats = new Panel();
            panelCard3 = new Panel();
            lblNewCustomersCount = new Label();
            lblNewCustomersTitle = new Label();
            panelCard2 = new Panel();
            lblActiveCustomersCount = new Label();
            lblActiveCustomersTitle = new Label();
            panelCard1 = new Panel();
            lblTotalCustomersCount = new Label();
            lblTotalCustomersTitle = new Label();
            panelLeft = new Panel();
            lblSelectedCustomer = new Label();
            btnClear = new Button();
            btnViewOrders = new Button();
            btnUpdate = new Button();
            txtUsername = new TextBox();
            lblUsername = new Label();
            txtContact = new TextBox();
            lblContact = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtName = new TextBox();
            lblName = new Label();
            errorProvider1 = new ErrorProvider(components);
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelTop.SuspendLayout();
            panelMain.SuspendLayout();
            panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            panelStats.SuspendLayout();
            panelCard3.SuspendLayout();
            panelCard2.SuspendLayout();
            panelCard1.SuspendLayout();
            panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(46, 125, 50);
            panelMenu.Controls.Add(pictureBoxLogo);
            panelMenu.Controls.Add(btnLogout);
            panelMenu.Controls.Add(btnGenerateReports);
            panelMenu.Controls.Add(btnManageOrders);
            panelMenu.Controls.Add(btnManageCustomers);
            panelMenu.Controls.Add(btnManageProducts);
            panelMenu.Controls.Add(btnManageUsers);
            panelMenu.Controls.Add(btnHome);
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
            pictureBoxLogo.TabIndex = 7;
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
            btnLogout.TabIndex = 6;
            btnLogout.Text = "🚪 Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnGenerateReports
            // 
            btnGenerateReports.Cursor = Cursors.Hand;
            btnGenerateReports.FlatAppearance.BorderSize = 0;
            btnGenerateReports.FlatStyle = FlatStyle.Flat;
            btnGenerateReports.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnGenerateReports.ForeColor = Color.White;
            btnGenerateReports.Location = new Point(0, 650);
            btnGenerateReports.Margin = new Padding(3, 4, 3, 4);
            btnGenerateReports.Name = "btnGenerateReports";
            btnGenerateReports.Size = new Size(250, 62);
            btnGenerateReports.TabIndex = 5;
            btnGenerateReports.Text = "📊 Generate Reports";
            btnGenerateReports.TextAlign = ContentAlignment.MiddleLeft;
            btnGenerateReports.UseVisualStyleBackColor = true;
            btnGenerateReports.Click += btnGenerateReports_Click;
            btnGenerateReports.MouseEnter += MenuButton_MouseEnter;
            btnGenerateReports.MouseLeave += MenuButton_MouseLeave;
            // 
            // btnManageOrders
            // 
            btnManageOrders.Cursor = Cursors.Hand;
            btnManageOrders.FlatAppearance.BorderSize = 0;
            btnManageOrders.FlatStyle = FlatStyle.Flat;
            btnManageOrders.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnManageOrders.ForeColor = Color.White;
            btnManageOrders.Location = new Point(0, 575);
            btnManageOrders.Margin = new Padding(3, 4, 3, 4);
            btnManageOrders.Name = "btnManageOrders";
            btnManageOrders.Size = new Size(250, 62);
            btnManageOrders.TabIndex = 4;
            btnManageOrders.Text = "📦 Manage Orders";
            btnManageOrders.TextAlign = ContentAlignment.MiddleLeft;
            btnManageOrders.UseVisualStyleBackColor = true;
            btnManageOrders.Click += btnManageOrders_Click;
            btnManageOrders.MouseEnter += MenuButton_MouseEnter;
            btnManageOrders.MouseLeave += MenuButton_MouseLeave;
            // 
            // btnManageCustomers
            // 
            btnManageCustomers.BackColor = Color.FromArgb(37, 99, 41);
            btnManageCustomers.Cursor = Cursors.Hand;
            btnManageCustomers.FlatAppearance.BorderSize = 0;
            btnManageCustomers.FlatStyle = FlatStyle.Flat;
            btnManageCustomers.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnManageCustomers.ForeColor = Color.White;
            btnManageCustomers.Location = new Point(0, 500);
            btnManageCustomers.Margin = new Padding(3, 4, 3, 4);
            btnManageCustomers.Name = "btnManageCustomers";
            btnManageCustomers.Size = new Size(250, 62);
            btnManageCustomers.TabIndex = 3;
            btnManageCustomers.Text = "👥 Manage Customers";
            btnManageCustomers.TextAlign = ContentAlignment.MiddleLeft;
            btnManageCustomers.UseVisualStyleBackColor = false;
            btnManageCustomers.Click += btnManageCustomers_Click;
            // 
            // btnManageProducts
            // 
            btnManageProducts.Cursor = Cursors.Hand;
            btnManageProducts.FlatAppearance.BorderSize = 0;
            btnManageProducts.FlatStyle = FlatStyle.Flat;
            btnManageProducts.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnManageProducts.ForeColor = Color.White;
            btnManageProducts.Location = new Point(0, 425);
            btnManageProducts.Margin = new Padding(3, 4, 3, 4);
            btnManageProducts.Name = "btnManageProducts";
            btnManageProducts.Size = new Size(250, 62);
            btnManageProducts.TabIndex = 2;
            btnManageProducts.Text = "\U0001f6d2 Manage Products";
            btnManageProducts.TextAlign = ContentAlignment.MiddleLeft;
            btnManageProducts.UseVisualStyleBackColor = true;
            btnManageProducts.Click += btnManageProducts_Click;
            btnManageProducts.MouseEnter += MenuButton_MouseEnter;
            btnManageProducts.MouseLeave += MenuButton_MouseLeave;
            // 
            // btnManageUsers
            // 
            btnManageUsers.Cursor = Cursors.Hand;
            btnManageUsers.FlatAppearance.BorderSize = 0;
            btnManageUsers.FlatStyle = FlatStyle.Flat;
            btnManageUsers.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnManageUsers.ForeColor = Color.White;
            btnManageUsers.Location = new Point(0, 350);
            btnManageUsers.Margin = new Padding(3, 4, 3, 4);
            btnManageUsers.Name = "btnManageUsers";
            btnManageUsers.Size = new Size(250, 62);
            btnManageUsers.TabIndex = 1;
            btnManageUsers.Text = "👤 Manage Users";
            btnManageUsers.TextAlign = ContentAlignment.MiddleLeft;
            btnManageUsers.UseVisualStyleBackColor = true;
            btnManageUsers.Click += btnManageUsers_Click;
            btnManageUsers.MouseEnter += MenuButton_MouseEnter;
            btnManageUsers.MouseLeave += MenuButton_MouseLeave;
            // 
            // btnHome
            // 
            btnHome.Cursor = Cursors.Hand;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(0, 275);
            btnHome.Margin = new Padding(3, 4, 3, 4);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(250, 62);
            btnHome.TabIndex = 0;
            btnHome.Text = "🏠 Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            btnHome.MouseEnter += MenuButton_MouseEnter;
            btnHome.MouseLeave += MenuButton_MouseLeave;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.White;
            panelTop.Controls.Add(btnRefresh);
            panelTop.Controls.Add(lblTotalCustomers);
            panelTop.Controls.Add(txtSearch);
            panelTop.Controls.Add(lblSearch);
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
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(820, 25);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(100, 38);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "🔄 Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // lblTotalCustomers
            // 
            lblTotalCustomers.AutoSize = true;
            lblTotalCustomers.Font = new Font("Segoe UI", 11F);
            lblTotalCustomers.ForeColor = Color.Gray;
            lblTotalCustomers.Location = new Point(30, 75);
            lblTotalCustomers.Name = "lblTotalCustomers";
            lblTotalCustomers.Size = new Size(165, 25);
            lblTotalCustomers.TabIndex = 3;
            lblTotalCustomers.Text = "Total Customers: 0";
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(610, 69);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(310, 30);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10F);
            lblSearch.ForeColor = Color.Gray;
            lblSearch.Location = new Point(530, 72);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(89, 23);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "🔍 Search";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(46, 125, 50);
            lblTitle.Location = new Point(25, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(288, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Manage Customers";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(245, 245, 245);
            panelMain.Controls.Add(panelRight);
            panelMain.Controls.Add(panelLeft);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(250, 125);
            panelMain.Margin = new Padding(3, 4, 3, 4);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(20, 25, 20, 25);
            panelMain.Size = new Size(950, 750);
            panelMain.TabIndex = 2;
            // 
            // panelRight
            // 
            panelRight.BackColor = Color.White;
            panelRight.Controls.Add(dgvCustomers);
            panelRight.Controls.Add(panelStats);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(370, 25);
            panelRight.Margin = new Padding(3, 4, 3, 4);
            panelRight.Name = "panelRight";
            panelRight.Padding = new Padding(10, 12, 10, 12);
            panelRight.Size = new Size(560, 700);
            panelRight.TabIndex = 1;
            // 
            // dgvCustomers
            // 
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Dock = DockStyle.Fill;
            dgvCustomers.Location = new Point(10, 137);
            dgvCustomers.Margin = new Padding(3, 4, 3, 4);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.RowHeadersWidth = 51;
            dgvCustomers.RowTemplate.Height = 24;
            dgvCustomers.Size = new Size(540, 551);
            dgvCustomers.TabIndex = 1;
            dgvCustomers.CellClick += dgvCustomers_CellClick;
            dgvCustomers.CellContentClick += dgvCustomers_CellContentClick;
            // 
            // panelStats
            // 
            panelStats.Controls.Add(panelCard3);
            panelStats.Controls.Add(panelCard2);
            panelStats.Controls.Add(panelCard1);
            panelStats.Dock = DockStyle.Top;
            panelStats.Location = new Point(10, 12);
            panelStats.Margin = new Padding(3, 4, 3, 4);
            panelStats.Name = "panelStats";
            panelStats.Size = new Size(540, 125);
            panelStats.TabIndex = 0;
            // 
            // panelCard3
            // 
            panelCard3.BackColor = Color.FromArgb(156, 39, 176);
            panelCard3.Controls.Add(lblNewCustomersCount);
            panelCard3.Controls.Add(lblNewCustomersTitle);
            panelCard3.Location = new Point(370, 12);
            panelCard3.Margin = new Padding(3, 4, 3, 4);
            panelCard3.Name = "panelCard3";
            panelCard3.Size = new Size(160, 100);
            panelCard3.TabIndex = 2;
            // 
            // lblNewCustomersCount
            // 
            lblNewCustomersCount.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblNewCustomersCount.ForeColor = Color.White;
            lblNewCustomersCount.Location = new Point(10, 44);
            lblNewCustomersCount.Name = "lblNewCustomersCount";
            lblNewCustomersCount.Size = new Size(140, 50);
            lblNewCustomersCount.TabIndex = 1;
            lblNewCustomersCount.Text = "0";
            lblNewCustomersCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNewCustomersTitle
            // 
            lblNewCustomersTitle.AutoSize = true;
            lblNewCustomersTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNewCustomersTitle.ForeColor = Color.White;
            lblNewCustomersTitle.Location = new Point(10, 12);
            lblNewCustomersTitle.Name = "lblNewCustomersTitle";
            lblNewCustomersTitle.Size = new Size(125, 20);
            lblNewCustomersTitle.TabIndex = 0;
            lblNewCustomersTitle.Text = "New This Month";
            // 
            // panelCard2
            // 
            panelCard2.BackColor = Color.FromArgb(255, 152, 0);
            panelCard2.Controls.Add(lblActiveCustomersCount);
            panelCard2.Controls.Add(lblActiveCustomersTitle);
            panelCard2.Location = new Point(190, 12);
            panelCard2.Margin = new Padding(3, 4, 3, 4);
            panelCard2.Name = "panelCard2";
            panelCard2.Size = new Size(160, 100);
            panelCard2.TabIndex = 1;
            // 
            // lblActiveCustomersCount
            // 
            lblActiveCustomersCount.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblActiveCustomersCount.ForeColor = Color.White;
            lblActiveCustomersCount.Location = new Point(10, 44);
            lblActiveCustomersCount.Name = "lblActiveCustomersCount";
            lblActiveCustomersCount.Size = new Size(140, 50);
            lblActiveCustomersCount.TabIndex = 1;
            lblActiveCustomersCount.Text = "0";
            lblActiveCustomersCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblActiveCustomersTitle
            // 
            lblActiveCustomersTitle.AutoSize = true;
            lblActiveCustomersTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblActiveCustomersTitle.ForeColor = Color.White;
            lblActiveCustomersTitle.Location = new Point(10, 12);
            lblActiveCustomersTitle.Name = "lblActiveCustomersTitle";
            lblActiveCustomersTitle.Size = new Size(132, 20);
            lblActiveCustomersTitle.TabIndex = 0;
            lblActiveCustomersTitle.Text = "Active Customers";
            // 
            // panelCard1
            // 
            panelCard1.BackColor = Color.FromArgb(46, 125, 50);
            panelCard1.Controls.Add(lblTotalCustomersCount);
            panelCard1.Controls.Add(lblTotalCustomersTitle);
            panelCard1.Location = new Point(10, 12);
            panelCard1.Margin = new Padding(3, 4, 3, 4);
            panelCard1.Name = "panelCard1";
            panelCard1.Size = new Size(160, 100);
            panelCard1.TabIndex = 0;
            // 
            // lblTotalCustomersCount
            // 
            lblTotalCustomersCount.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTotalCustomersCount.ForeColor = Color.White;
            lblTotalCustomersCount.Location = new Point(10, 44);
            lblTotalCustomersCount.Name = "lblTotalCustomersCount";
            lblTotalCustomersCount.Size = new Size(140, 50);
            lblTotalCustomersCount.TabIndex = 1;
            lblTotalCustomersCount.Text = "0";
            lblTotalCustomersCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalCustomersTitle
            // 
            lblTotalCustomersTitle.AutoSize = true;
            lblTotalCustomersTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTotalCustomersTitle.ForeColor = Color.White;
            lblTotalCustomersTitle.Location = new Point(10, 12);
            lblTotalCustomersTitle.Name = "lblTotalCustomersTitle";
            lblTotalCustomersTitle.Size = new Size(123, 20);
            lblTotalCustomersTitle.TabIndex = 0;
            lblTotalCustomersTitle.Text = "Total Customers";
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.White;
            panelLeft.Controls.Add(lblSelectedCustomer);
            panelLeft.Controls.Add(btnClear);
            panelLeft.Controls.Add(btnViewOrders);
            panelLeft.Controls.Add(btnUpdate);
            panelLeft.Controls.Add(txtUsername);
            panelLeft.Controls.Add(lblUsername);
            panelLeft.Controls.Add(txtContact);
            panelLeft.Controls.Add(lblContact);
            panelLeft.Controls.Add(txtEmail);
            panelLeft.Controls.Add(lblEmail);
            panelLeft.Controls.Add(txtName);
            panelLeft.Controls.Add(lblName);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(20, 25);
            panelLeft.Margin = new Padding(3, 4, 3, 4);
            panelLeft.Name = "panelLeft";
            panelLeft.Padding = new Padding(15, 19, 15, 19);
            panelLeft.Size = new Size(350, 700);
            panelLeft.TabIndex = 0;
            // 
            // lblSelectedCustomer
            // 
            lblSelectedCustomer.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblSelectedCustomer.ForeColor = Color.Gray;
            lblSelectedCustomer.Location = new Point(20, 19);
            lblSelectedCustomer.Name = "lblSelectedCustomer";
            lblSelectedCustomer.Size = new Size(310, 31);
            lblSelectedCustomer.TabIndex = 11;
            lblSelectedCustomer.Text = "No customer selected";
            lblSelectedCustomer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(245, 245, 245);
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClear.ForeColor = Color.FromArgb(38, 50, 56);
            btnClear.Location = new Point(20, 538);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(310, 50);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnViewOrders
            // 
            btnViewOrders.BackColor = Color.FromArgb(33, 150, 243);
            btnViewOrders.Cursor = Cursors.Hand;
            btnViewOrders.FlatAppearance.BorderSize = 0;
            btnViewOrders.FlatStyle = FlatStyle.Flat;
            btnViewOrders.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnViewOrders.ForeColor = Color.White;
            btnViewOrders.Location = new Point(20, 469);
            btnViewOrders.Margin = new Padding(3, 4, 3, 4);
            btnViewOrders.Name = "btnViewOrders";
            btnViewOrders.Size = new Size(310, 50);
            btnViewOrders.TabIndex = 9;
            btnViewOrders.Text = "View Orders";
            btnViewOrders.UseVisualStyleBackColor = false;
            btnViewOrders.Click += btnViewOrders_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(46, 125, 50);
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(20, 400);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(310, 50);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 10F);
            txtUsername.Location = new Point(20, 338);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(310, 30);
            txtUsername.TabIndex = 7;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUsername.ForeColor = Color.FromArgb(38, 50, 56);
            lblUsername.Location = new Point(15, 306);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(80, 20);
            lblUsername.TabIndex = 6;
            lblUsername.Text = "Username";
            // 
            // txtContact
            // 
            txtContact.BorderStyle = BorderStyle.FixedSingle;
            txtContact.Font = new Font("Segoe UI", 10F);
            txtContact.Location = new Point(20, 250);
            txtContact.Margin = new Padding(3, 4, 3, 4);
            txtContact.MaxLength = 10;
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(310, 30);
            txtContact.TabIndex = 5;
            txtContact.KeyPress += txtContact_KeyPress;
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblContact.ForeColor = Color.FromArgb(38, 50, 56);
            lblContact.Location = new Point(15, 219);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(63, 20);
            lblContact.TabIndex = 4;
            lblContact.Text = "Contact";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(20, 162);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(310, 30);
            txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(38, 50, 56);
            lblEmail.Location = new Point(15, 131);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(108, 20);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email Address";
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI", 10F);
            txtName.Location = new Point(20, 75);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(310, 30);
            txtName.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblName.ForeColor = Color.FromArgb(38, 50, 56);
            lblName.Location = new Point(15, 44);
            lblName.Name = "lblName";
            lblName.Size = new Size(80, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Full Name";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // CustomerManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 875);
            Controls.Add(panelMain);
            Controls.Add(panelTop);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "CustomerManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Customers - ShopGreen";
            FormClosing += CustomerManagementForm_FormClosing;
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelMain.ResumeLayout(false);
            panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            panelStats.ResumeLayout(false);
            panelCard3.ResumeLayout(false);
            panelCard3.PerformLayout();
            panelCard2.ResumeLayout(false);
            panelCard2.PerformLayout();
            panelCard1.ResumeLayout(false);
            panelCard1.PerformLayout();
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }
    }
}