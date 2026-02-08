namespace ShopGreenSystem
{
    partial class OrderManagementForm
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
        private System.Windows.Forms.Label lblTotalOrders;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ComboBox cmbFilterStatus;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnUpdateStatus;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.DataGridView dgvOrderDetails;
        private System.Windows.Forms.Label lblOrderDetailsTitle;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblSelectedOrder;
        private System.Windows.Forms.Panel panelCard1;
        private System.Windows.Forms.Panel panelCard2;
        private System.Windows.Forms.Panel panelCard3;
        private System.Windows.Forms.Panel panelCard4;
        private System.Windows.Forms.Label lblPendingTitle;
        private System.Windows.Forms.Label lblPendingCount;
        private System.Windows.Forms.Label lblShippedTitle;
        private System.Windows.Forms.Label lblShippedCount;
        private System.Windows.Forms.Label lblDeliveredTitle;
        private System.Windows.Forms.Label lblDeliveredCount;
        private System.Windows.Forms.Label lblRevenueTitle;
        private System.Windows.Forms.Label lblRevenueCount;

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
            cmbFilterStatus = new ComboBox();
            lblFilter = new Label();
            lblTotalOrders = new Label();
            txtSearch = new TextBox();
            lblSearch = new Label();
            lblTitle = new Label();
            panelMain = new Panel();
            panelRight = new Panel();
            dgvOrderDetails = new DataGridView();
            lblOrderDetailsTitle = new Label();
            dgvOrders = new DataGridView();
            panelStats = new Panel();
            panelCard4 = new Panel();
            lblRevenueCount = new Label();
            lblRevenueTitle = new Label();
            panelCard3 = new Panel();
            lblDeliveredCount = new Label();
            lblDeliveredTitle = new Label();
            panelCard2 = new Panel();
            lblShippedCount = new Label();
            lblShippedTitle = new Label();
            panelCard1 = new Panel();
            lblPendingCount = new Label();
            lblPendingTitle = new Label();
            panelLeft = new Panel();
            lblSelectedOrder = new Label();
            btnClear = new Button();
            btnViewDetails = new Button();
            btnUpdateStatus = new Button();
            cmbStatus = new ComboBox();
            lblStatus = new Label();
            txtTotalAmount = new TextBox();
            lblTotalAmount = new Label();
            txtOrderDate = new TextBox();
            lblOrderDate = new Label();
            txtCustomerName = new TextBox();
            lblCustomerName = new Label();
            txtOrderId = new TextBox();
            lblOrderId = new Label();
            errorProvider1 = new ErrorProvider(components);
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelTop.SuspendLayout();
            panelMain.SuspendLayout();
            panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            panelStats.SuspendLayout();
            panelCard4.SuspendLayout();
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
            btnManageOrders.BackColor = Color.FromArgb(37, 99, 41);
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
            btnManageOrders.UseVisualStyleBackColor = false;
            btnManageOrders.Click += btnManageOrders_Click;
            // 
            // btnManageCustomers
            // 
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
            btnManageCustomers.UseVisualStyleBackColor = true;
            btnManageCustomers.Click += btnManageCustomers_Click;
            btnManageCustomers.MouseEnter += MenuButton_MouseEnter;
            btnManageCustomers.MouseLeave += MenuButton_MouseLeave;
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
            panelTop.Controls.Add(cmbFilterStatus);
            panelTop.Controls.Add(lblFilter);
            panelTop.Controls.Add(lblTotalOrders);
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
            btnRefresh.TabIndex = 6;
            btnRefresh.Text = "🔄 Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // cmbFilterStatus
            // 
            cmbFilterStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilterStatus.Font = new Font("Segoe UI", 9F);
            cmbFilterStatus.FormattingEnabled = true;
            cmbFilterStatus.Items.AddRange(new object[] { "All Orders", "PENDING", "SHIPPED", "DELIVERED" });
            cmbFilterStatus.Location = new Point(460, 72);
            cmbFilterStatus.Margin = new Padding(3, 4, 3, 4);
            cmbFilterStatus.Name = "cmbFilterStatus";
            cmbFilterStatus.Size = new Size(150, 28);
            cmbFilterStatus.TabIndex = 5;
            cmbFilterStatus.SelectedIndexChanged += cmbFilterStatus_SelectedIndexChanged;
            // 
            // lblFilter
            // 
            lblFilter.AutoSize = true;
            lblFilter.Font = new Font("Segoe UI", 10F);
            lblFilter.ForeColor = Color.Gray;
            lblFilter.Location = new Point(390, 75);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(74, 23);
            lblFilter.TabIndex = 4;
            lblFilter.Text = "Filter by:";
            // 
            // lblTotalOrders
            // 
            lblTotalOrders.AutoSize = true;
            lblTotalOrders.Font = new Font("Segoe UI", 11F);
            lblTotalOrders.ForeColor = Color.Gray;
            lblTotalOrders.Location = new Point(30, 75);
            lblTotalOrders.Name = "lblTotalOrders";
            lblTotalOrders.Size = new Size(133, 25);
            lblTotalOrders.TabIndex = 3;
            lblTotalOrders.Text = "Total Orders: 0";
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(690, 71);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search by ID or Name";
            txtSearch.Size = new Size(230, 30);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10F);
            lblSearch.ForeColor = Color.Gray;
            lblSearch.Location = new Point(630, 75);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(59, 23);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "🔍 ID:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(46, 125, 50);
            lblTitle.Location = new Point(25, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(235, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Manage Orders";
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
            panelRight.Controls.Add(dgvOrderDetails);
            panelRight.Controls.Add(lblOrderDetailsTitle);
            panelRight.Controls.Add(dgvOrders);
            panelRight.Controls.Add(panelStats);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(370, 25);
            panelRight.Margin = new Padding(3, 4, 3, 4);
            panelRight.Name = "panelRight";
            panelRight.Padding = new Padding(10, 12, 10, 12);
            panelRight.Size = new Size(560, 700);
            panelRight.TabIndex = 1;
            // 
            // dgvOrderDetails
            // 
            dgvOrderDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderDetails.Dock = DockStyle.Fill;
            dgvOrderDetails.Location = new Point(10, 376);
            dgvOrderDetails.Margin = new Padding(3, 4, 3, 4);
            dgvOrderDetails.Name = "dgvOrderDetails";
            dgvOrderDetails.RowHeadersWidth = 51;
            dgvOrderDetails.RowTemplate.Height = 24;
            dgvOrderDetails.Size = new Size(540, 312);
            dgvOrderDetails.TabIndex = 3;
            // 
            // lblOrderDetailsTitle
            // 
            lblOrderDetailsTitle.BackColor = Color.FromArgb(46, 125, 50);
            lblOrderDetailsTitle.Dock = DockStyle.Top;
            lblOrderDetailsTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblOrderDetailsTitle.ForeColor = Color.White;
            lblOrderDetailsTitle.Location = new Point(10, 332);
            lblOrderDetailsTitle.Name = "lblOrderDetailsTitle";
            lblOrderDetailsTitle.Padding = new Padding(5, 6, 5, 6);
            lblOrderDetailsTitle.Size = new Size(540, 44);
            lblOrderDetailsTitle.TabIndex = 2;
            lblOrderDetailsTitle.Text = "📦 Order Items";
            lblOrderDetailsTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvOrders
            // 
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Dock = DockStyle.Top;
            dgvOrders.Location = new Point(10, 137);
            dgvOrders.Margin = new Padding(3, 4, 3, 4);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.RowHeadersWidth = 51;
            dgvOrders.RowTemplate.Height = 24;
            dgvOrders.Size = new Size(540, 195);
            dgvOrders.TabIndex = 1;
            dgvOrders.CellClick += dgvOrders_CellClick;
            // 
            // panelStats
            // 
            panelStats.Controls.Add(panelCard4);
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
            // panelCard4
            // 
            panelCard4.BackColor = Color.FromArgb(76, 175, 80);
            panelCard4.Controls.Add(lblRevenueCount);
            panelCard4.Controls.Add(lblRevenueTitle);
            panelCard4.Location = new Point(10, 12);
            panelCard4.Margin = new Padding(3, 4, 3, 4);
            panelCard4.Name = "panelCard4";
            panelCard4.Size = new Size(250, 100);
            panelCard4.TabIndex = 3;
            // 
            // lblRevenueCount
            // 
            lblRevenueCount.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblRevenueCount.ForeColor = Color.White;
            lblRevenueCount.Location = new Point(10, 44);
            lblRevenueCount.Name = "lblRevenueCount";
            lblRevenueCount.Size = new Size(230, 50);
            lblRevenueCount.TabIndex = 1;
            lblRevenueCount.Text = "Rs. 0.00";
            lblRevenueCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRevenueTitle
            // 
            lblRevenueTitle.AutoSize = true;
            lblRevenueTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRevenueTitle.ForeColor = Color.White;
            lblRevenueTitle.Location = new Point(10, 12);
            lblRevenueTitle.Name = "lblRevenueTitle";
            lblRevenueTitle.Size = new Size(108, 20);
            lblRevenueTitle.TabIndex = 0;
            lblRevenueTitle.Text = "Total Revenue";
            // 
            // panelCard3
            // 
            panelCard3.BackColor = Color.FromArgb(76, 175, 80);
            panelCard3.Controls.Add(lblDeliveredCount);
            panelCard3.Controls.Add(lblDeliveredTitle);
            panelCard3.Location = new Point(400, 12);
            panelCard3.Margin = new Padding(3, 4, 3, 4);
            panelCard3.Name = "panelCard3";
            panelCard3.Size = new Size(130, 100);
            panelCard3.TabIndex = 2;
            // 
            // lblDeliveredCount
            // 
            lblDeliveredCount.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblDeliveredCount.ForeColor = Color.White;
            lblDeliveredCount.Location = new Point(10, 44);
            lblDeliveredCount.Name = "lblDeliveredCount";
            lblDeliveredCount.Size = new Size(110, 50);
            lblDeliveredCount.TabIndex = 1;
            lblDeliveredCount.Text = "0";
            lblDeliveredCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDeliveredTitle
            // 
            lblDeliveredTitle.AutoSize = true;
            lblDeliveredTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDeliveredTitle.ForeColor = Color.White;
            lblDeliveredTitle.Location = new Point(10, 12);
            lblDeliveredTitle.Name = "lblDeliveredTitle";
            lblDeliveredTitle.Size = new Size(75, 20);
            lblDeliveredTitle.TabIndex = 0;
            lblDeliveredTitle.Text = "Delivered";
            // 
            // panelCard2
            // 
            panelCard2.BackColor = Color.FromArgb(33, 150, 243);
            panelCard2.Controls.Add(lblShippedCount);
            panelCard2.Controls.Add(lblShippedTitle);
            panelCard2.Location = new Point(330, 12);
            panelCard2.Margin = new Padding(3, 4, 3, 4);
            panelCard2.Name = "panelCard2";
            panelCard2.Size = new Size(60, 100);
            panelCard2.TabIndex = 1;
            // 
            // lblShippedCount
            // 
            lblShippedCount.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblShippedCount.ForeColor = Color.White;
            lblShippedCount.Location = new Point(5, 44);
            lblShippedCount.Name = "lblShippedCount";
            lblShippedCount.Size = new Size(50, 50);
            lblShippedCount.TabIndex = 1;
            lblShippedCount.Text = "0";
            lblShippedCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblShippedTitle
            // 
            lblShippedTitle.AutoSize = true;
            lblShippedTitle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblShippedTitle.ForeColor = Color.White;
            lblShippedTitle.Location = new Point(5, 12);
            lblShippedTitle.Name = "lblShippedTitle";
            lblShippedTitle.Size = new Size(52, 19);
            lblShippedTitle.TabIndex = 0;
            lblShippedTitle.Text = "Ship'd";
            // 
            // panelCard1
            // 
            panelCard1.BackColor = Color.FromArgb(255, 152, 0);
            panelCard1.Controls.Add(lblPendingCount);
            panelCard1.Controls.Add(lblPendingTitle);
            panelCard1.Location = new Point(270, 12);
            panelCard1.Margin = new Padding(3, 4, 3, 4);
            panelCard1.Name = "panelCard1";
            panelCard1.Size = new Size(50, 100);
            panelCard1.TabIndex = 0;
            // 
            // lblPendingCount
            // 
            lblPendingCount.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblPendingCount.ForeColor = Color.White;
            lblPendingCount.Location = new Point(0, 44);
            lblPendingCount.Name = "lblPendingCount";
            lblPendingCount.Size = new Size(50, 50);
            lblPendingCount.TabIndex = 1;
            lblPendingCount.Text = "0";
            lblPendingCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPendingTitle
            // 
            lblPendingTitle.AutoSize = true;
            lblPendingTitle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblPendingTitle.ForeColor = Color.White;
            lblPendingTitle.Location = new Point(0, 12);
            lblPendingTitle.Name = "lblPendingTitle";
            lblPendingTitle.Size = new Size(64, 19);
            lblPendingTitle.TabIndex = 0;
            lblPendingTitle.Text = "Pend'ng";
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.White;
            panelLeft.Controls.Add(lblSelectedOrder);
            panelLeft.Controls.Add(btnClear);
            panelLeft.Controls.Add(btnViewDetails);
            panelLeft.Controls.Add(btnUpdateStatus);
            panelLeft.Controls.Add(cmbStatus);
            panelLeft.Controls.Add(lblStatus);
            panelLeft.Controls.Add(txtTotalAmount);
            panelLeft.Controls.Add(lblTotalAmount);
            panelLeft.Controls.Add(txtOrderDate);
            panelLeft.Controls.Add(lblOrderDate);
            panelLeft.Controls.Add(txtCustomerName);
            panelLeft.Controls.Add(lblCustomerName);
            panelLeft.Controls.Add(txtOrderId);
            panelLeft.Controls.Add(lblOrderId);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(20, 25);
            panelLeft.Margin = new Padding(3, 4, 3, 4);
            panelLeft.Name = "panelLeft";
            panelLeft.Padding = new Padding(15, 19, 15, 19);
            panelLeft.Size = new Size(350, 700);
            panelLeft.TabIndex = 0;
            // 
            // lblSelectedOrder
            // 
            lblSelectedOrder.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSelectedOrder.ForeColor = Color.Gray;
            lblSelectedOrder.Location = new Point(20, 10);
            lblSelectedOrder.Name = "lblSelectedOrder";
            lblSelectedOrder.Size = new Size(310, 35);
            lblSelectedOrder.TabIndex = 13;
            lblSelectedOrder.Text = "No order selected";
            lblSelectedOrder.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(245, 245, 245);
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClear.ForeColor = Color.FromArgb(38, 50, 56);
            btnClear.Location = new Point(20, 588);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(310, 50);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnViewDetails
            // 
            btnViewDetails.BackColor = Color.FromArgb(33, 150, 243);
            btnViewDetails.Cursor = Cursors.Hand;
            btnViewDetails.FlatAppearance.BorderSize = 0;
            btnViewDetails.FlatStyle = FlatStyle.Flat;
            btnViewDetails.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnViewDetails.ForeColor = Color.White;
            btnViewDetails.Location = new Point(20, 519);
            btnViewDetails.Margin = new Padding(3, 4, 3, 4);
            btnViewDetails.Name = "btnViewDetails";
            btnViewDetails.Size = new Size(310, 50);
            btnViewDetails.TabIndex = 11;
            btnViewDetails.Text = "View Order Details";
            btnViewDetails.UseVisualStyleBackColor = false;
            btnViewDetails.Click += btnViewDetails_Click;
            // 
            // btnUpdateStatus
            // 
            btnUpdateStatus.BackColor = Color.FromArgb(46, 125, 50);
            btnUpdateStatus.Cursor = Cursors.Hand;
            btnUpdateStatus.FlatAppearance.BorderSize = 0;
            btnUpdateStatus.FlatStyle = FlatStyle.Flat;
            btnUpdateStatus.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUpdateStatus.ForeColor = Color.White;
            btnUpdateStatus.Location = new Point(20, 450);
            btnUpdateStatus.Margin = new Padding(3, 4, 3, 4);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new Size(310, 50);
            btnUpdateStatus.TabIndex = 10;
            btnUpdateStatus.Text = "Update Status";
            btnUpdateStatus.UseVisualStyleBackColor = false;
            btnUpdateStatus.Click += btnUpdateStatus_Click;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Font = new Font("Segoe UI", 10F);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "PENDING", "SHIPPED", "DELIVERED" });
            cmbStatus.Location = new Point(20, 394);
            cmbStatus.Margin = new Padding(3, 4, 3, 4);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(310, 31);
            cmbStatus.TabIndex = 9;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStatus.ForeColor = Color.FromArgb(38, 50, 56);
            lblStatus.Location = new Point(15, 362);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(53, 20);
            lblStatus.TabIndex = 8;
            lblStatus.Text = "Status";
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.BorderStyle = BorderStyle.FixedSingle;
            txtTotalAmount.Font = new Font("Segoe UI", 10F);
            txtTotalAmount.Location = new Point(20, 306);
            txtTotalAmount.Margin = new Padding(3, 4, 3, 4);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.ReadOnly = true;
            txtTotalAmount.Size = new Size(310, 30);
            txtTotalAmount.TabIndex = 7;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTotalAmount.ForeColor = Color.FromArgb(38, 50, 56);
            lblTotalAmount.Location = new Point(15, 275);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(106, 20);
            lblTotalAmount.TabIndex = 6;
            lblTotalAmount.Text = "Total Amount";
            // 
            // txtOrderDate
            // 
            txtOrderDate.BorderStyle = BorderStyle.FixedSingle;
            txtOrderDate.Font = new Font("Segoe UI", 10F);
            txtOrderDate.Location = new Point(20, 219);
            txtOrderDate.Margin = new Padding(3, 4, 3, 4);
            txtOrderDate.Name = "txtOrderDate";
            txtOrderDate.ReadOnly = true;
            txtOrderDate.Size = new Size(310, 30);
            txtOrderDate.TabIndex = 5;
            // 
            // lblOrderDate
            // 
            lblOrderDate.AutoSize = true;
            lblOrderDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblOrderDate.ForeColor = Color.FromArgb(38, 50, 56);
            lblOrderDate.Location = new Point(15, 188);
            lblOrderDate.Name = "lblOrderDate";
            lblOrderDate.Size = new Size(86, 20);
            lblOrderDate.TabIndex = 4;
            lblOrderDate.Text = "Order Date";
            // 
            // txtCustomerName
            // 
            txtCustomerName.BorderStyle = BorderStyle.FixedSingle;
            txtCustomerName.Font = new Font("Segoe UI", 10F);
            txtCustomerName.Location = new Point(20, 131);
            txtCustomerName.Margin = new Padding(3, 4, 3, 4);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.ReadOnly = true;
            txtCustomerName.Size = new Size(310, 30);
            txtCustomerName.TabIndex = 3;
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCustomerName.ForeColor = Color.FromArgb(38, 50, 56);
            lblCustomerName.Location = new Point(15, 100);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(123, 20);
            lblCustomerName.TabIndex = 2;
            lblCustomerName.Text = "Customer Name";
            // 
            // txtOrderId
            // 
            txtOrderId.BorderStyle = BorderStyle.FixedSingle;
            txtOrderId.Font = new Font("Segoe UI", 10F);
            txtOrderId.Location = new Point(20, 54);
            txtOrderId.Margin = new Padding(3, 4, 3, 4);
            txtOrderId.Name = "txtOrderId";
            txtOrderId.ReadOnly = true;
            txtOrderId.Size = new Size(310, 30);
            txtOrderId.TabIndex = 1;
            // 
            // lblOrderId
            // 
            lblOrderId.AutoSize = true;
            lblOrderId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblOrderId.ForeColor = Color.FromArgb(38, 50, 56);
            lblOrderId.Location = new Point(15, 50);
            lblOrderId.Name = "lblOrderId";
            lblOrderId.Size = new Size(69, 20);
            lblOrderId.TabIndex = 0;
            lblOrderId.Text = "Order ID";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // OrderManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 875);
            Controls.Add(panelMain);
            Controls.Add(panelTop);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "OrderManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Orders - ShopGreen";
            FormClosing += OrderManagementForm_FormClosing;
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelMain.ResumeLayout(false);
            panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            panelStats.ResumeLayout(false);
            panelCard4.ResumeLayout(false);
            panelCard4.PerformLayout();
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