namespace ShopGreenSystem
{
    partial class ReportsForm
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
        private System.Windows.Forms.Panel panelReportButtons;
        private System.Windows.Forms.Panel panelReportView;
        private System.Windows.Forms.Button btnSalesReport;
        private System.Windows.Forms.Button btnStockReport;
        private System.Windows.Forms.Button btnCustomerOrderHistory;
        private System.Windows.Forms.Button btnLowStockAlert;
        private System.Windows.Forms.Button btnMonthlySales;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Label lblReportTitle;
        private System.Windows.Forms.Label lblReportSummary;
        private System.Windows.Forms.Button btnExportCSV;
        private System.Windows.Forms.Button btnPrintReport;

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
            btnGenerateReports = new Button();
            btnManageOrders = new Button();
            btnManageCustomers = new Button();
            btnManageProducts = new Button();
            btnManageUsers = new Button();
            btnHome = new Button();
            panelTop = new Panel();
            lblTitle = new Label();
            panelMain = new Panel();
            panelReportView = new Panel();
            dgvReport = new DataGridView();
            lblReportSummary = new Label();
            lblReportTitle = new Label();
            panelReportButtons = new Panel();
            btnPrintReport = new Button();
            btnExportCSV = new Button();
            btnMonthlySales = new Button();
            btnLowStockAlert = new Button();
            btnCustomerOrderHistory = new Button();
            btnStockReport = new Button();
            btnSalesReport = new Button();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelTop.SuspendLayout();
            panelMain.SuspendLayout();
            panelReportView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            panelReportButtons.SuspendLayout();
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
            btnGenerateReports.BackColor = Color.FromArgb(37, 99, 41);
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
            btnGenerateReports.UseVisualStyleBackColor = false;
            btnGenerateReports.Click += btnGenerateReports_Click;
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
            panelTop.Controls.Add(lblTitle);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(250, 0);
            panelTop.Margin = new Padding(3, 4, 3, 4);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(950, 100);
            panelTop.TabIndex = 1;
            panelTop.Paint += panelTop_Paint;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(46, 125, 50);
            lblTitle.Location = new Point(25, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(263, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Generate Reports";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(245, 245, 245);
            panelMain.Controls.Add(panelReportView);
            panelMain.Controls.Add(panelReportButtons);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(250, 100);
            panelMain.Margin = new Padding(3, 4, 3, 4);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(20, 25, 20, 25);
            panelMain.Size = new Size(950, 775);
            panelMain.TabIndex = 2;
            // 
            // panelReportView
            // 
            panelReportView.BackColor = Color.White;
            panelReportView.Controls.Add(dgvReport);
            panelReportView.Controls.Add(lblReportSummary);
            panelReportView.Controls.Add(lblReportTitle);
            panelReportView.Dock = DockStyle.Fill;
            panelReportView.Location = new Point(270, 25);
            panelReportView.Margin = new Padding(3, 4, 3, 4);
            panelReportView.Name = "panelReportView";
            panelReportView.Padding = new Padding(15, 19, 15, 19);
            panelReportView.Size = new Size(660, 725);
            panelReportView.TabIndex = 1;
            // 
            // dgvReport
            // 
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReport.Dock = DockStyle.Fill;
            dgvReport.Location = new Point(15, 88);
            dgvReport.Margin = new Padding(3, 4, 3, 4);
            dgvReport.Name = "dgvReport";
            dgvReport.RowHeadersWidth = 51;
            dgvReport.RowTemplate.Height = 24;
            dgvReport.Size = new Size(630, 618);
            dgvReport.TabIndex = 2;
            // 
            // lblReportSummary
            // 
            lblReportSummary.Dock = DockStyle.Top;
            lblReportSummary.Font = new Font("Segoe UI", 10F);
            lblReportSummary.ForeColor = Color.Gray;
            lblReportSummary.Location = new Point(15, 50);
            lblReportSummary.Name = "lblReportSummary";
            lblReportSummary.Padding = new Padding(0, 6, 0, 6);
            lblReportSummary.Size = new Size(630, 38);
            lblReportSummary.TabIndex = 1;
            lblReportSummary.Text = "Select a report type to view data";
            // 
            // lblReportTitle
            // 
            lblReportTitle.Dock = DockStyle.Top;
            lblReportTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblReportTitle.ForeColor = Color.FromArgb(46, 125, 50);
            lblReportTitle.Location = new Point(15, 19);
            lblReportTitle.Name = "lblReportTitle";
            lblReportTitle.Size = new Size(630, 31);
            lblReportTitle.TabIndex = 0;
            lblReportTitle.Text = "📊 Reports";
            // 
            // panelReportButtons
            // 
            panelReportButtons.BackColor = Color.White;
            panelReportButtons.Controls.Add(btnPrintReport);
            panelReportButtons.Controls.Add(btnExportCSV);
            panelReportButtons.Controls.Add(btnMonthlySales);
            panelReportButtons.Controls.Add(btnLowStockAlert);
            panelReportButtons.Controls.Add(btnCustomerOrderHistory);
            panelReportButtons.Controls.Add(btnStockReport);
            panelReportButtons.Controls.Add(btnSalesReport);
            panelReportButtons.Dock = DockStyle.Left;
            panelReportButtons.Location = new Point(20, 25);
            panelReportButtons.Margin = new Padding(3, 4, 3, 4);
            panelReportButtons.Name = "panelReportButtons";
            panelReportButtons.Padding = new Padding(15, 19, 15, 19);
            panelReportButtons.Size = new Size(250, 725);
            panelReportButtons.TabIndex = 0;
            // 
            // btnPrintReport
            // 
            btnPrintReport.BackColor = Color.FromArgb(96, 125, 139);
            btnPrintReport.Cursor = Cursors.Hand;
            btnPrintReport.FlatAppearance.BorderSize = 0;
            btnPrintReport.FlatStyle = FlatStyle.Flat;
            btnPrintReport.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPrintReport.ForeColor = Color.White;
            btnPrintReport.Location = new Point(15, 575);
            btnPrintReport.Margin = new Padding(3, 4, 3, 4);
            btnPrintReport.Name = "btnPrintReport";
            btnPrintReport.Size = new Size(220, 56);
            btnPrintReport.TabIndex = 6;
            btnPrintReport.Text = "🖨️ Print Report";
            btnPrintReport.UseVisualStyleBackColor = false;
            btnPrintReport.Click += btnPrintReport_Click;
            // 
            // btnExportCSV
            // 
            btnExportCSV.BackColor = Color.FromArgb(76, 175, 80);
            btnExportCSV.Cursor = Cursors.Hand;
            btnExportCSV.FlatAppearance.BorderSize = 0;
            btnExportCSV.FlatStyle = FlatStyle.Flat;
            btnExportCSV.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnExportCSV.ForeColor = Color.White;
            btnExportCSV.Location = new Point(15, 500);
            btnExportCSV.Margin = new Padding(3, 4, 3, 4);
            btnExportCSV.Name = "btnExportCSV";
            btnExportCSV.Size = new Size(220, 56);
            btnExportCSV.TabIndex = 5;
            btnExportCSV.Text = "📥 Export to CSV";
            btnExportCSV.UseVisualStyleBackColor = false;
            btnExportCSV.Click += btnExportCSV_Click;
            // 
            // btnMonthlySales
            // 
            btnMonthlySales.BackColor = Color.FromArgb(156, 39, 176);
            btnMonthlySales.Cursor = Cursors.Hand;
            btnMonthlySales.FlatAppearance.BorderSize = 0;
            btnMonthlySales.FlatStyle = FlatStyle.Flat;
            btnMonthlySales.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnMonthlySales.ForeColor = Color.White;
            btnMonthlySales.Location = new Point(15, 350);
            btnMonthlySales.Margin = new Padding(3, 4, 3, 4);
            btnMonthlySales.Name = "btnMonthlySales";
            btnMonthlySales.Size = new Size(220, 62);
            btnMonthlySales.TabIndex = 4;
            btnMonthlySales.Text = "📈 Monthly Sales";
            btnMonthlySales.UseVisualStyleBackColor = false;
            btnMonthlySales.Click += btnMonthlySales_Click;
            // 
            // btnLowStockAlert
            // 
            btnLowStockAlert.BackColor = Color.FromArgb(244, 67, 54);
            btnLowStockAlert.Cursor = Cursors.Hand;
            btnLowStockAlert.FlatAppearance.BorderSize = 0;
            btnLowStockAlert.FlatStyle = FlatStyle.Flat;
            btnLowStockAlert.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLowStockAlert.ForeColor = Color.White;
            btnLowStockAlert.Location = new Point(15, 269);
            btnLowStockAlert.Margin = new Padding(3, 4, 3, 4);
            btnLowStockAlert.Name = "btnLowStockAlert";
            btnLowStockAlert.Size = new Size(220, 62);
            btnLowStockAlert.TabIndex = 3;
            btnLowStockAlert.Text = "⚠️ Low Stock Alert";
            btnLowStockAlert.UseVisualStyleBackColor = false;
            btnLowStockAlert.Click += btnLowStockAlert_Click;
            // 
            // btnCustomerOrderHistory
            // 
            btnCustomerOrderHistory.BackColor = Color.FromArgb(255, 152, 0);
            btnCustomerOrderHistory.Cursor = Cursors.Hand;
            btnCustomerOrderHistory.FlatAppearance.BorderSize = 0;
            btnCustomerOrderHistory.FlatStyle = FlatStyle.Flat;
            btnCustomerOrderHistory.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCustomerOrderHistory.ForeColor = Color.White;
            btnCustomerOrderHistory.Location = new Point(15, 188);
            btnCustomerOrderHistory.Margin = new Padding(3, 4, 3, 4);
            btnCustomerOrderHistory.Name = "btnCustomerOrderHistory";
            btnCustomerOrderHistory.Size = new Size(220, 62);
            btnCustomerOrderHistory.TabIndex = 2;
            btnCustomerOrderHistory.Text = "👥 Customer Orders";
            btnCustomerOrderHistory.UseVisualStyleBackColor = false;
            btnCustomerOrderHistory.Click += btnCustomerOrderHistory_Click;
            // 
            // btnStockReport
            // 
            btnStockReport.BackColor = Color.FromArgb(33, 150, 243);
            btnStockReport.Cursor = Cursors.Hand;
            btnStockReport.FlatAppearance.BorderSize = 0;
            btnStockReport.FlatStyle = FlatStyle.Flat;
            btnStockReport.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnStockReport.ForeColor = Color.White;
            btnStockReport.Location = new Point(15, 106);
            btnStockReport.Margin = new Padding(3, 4, 3, 4);
            btnStockReport.Name = "btnStockReport";
            btnStockReport.Size = new Size(220, 62);
            btnStockReport.TabIndex = 1;
            btnStockReport.Text = "📦 Stock Report";
            btnStockReport.UseVisualStyleBackColor = false;
            btnStockReport.Click += btnStockReport_Click;
            // 
            // btnSalesReport
            // 
            btnSalesReport.BackColor = Color.FromArgb(46, 125, 50);
            btnSalesReport.Cursor = Cursors.Hand;
            btnSalesReport.FlatAppearance.BorderSize = 0;
            btnSalesReport.FlatStyle = FlatStyle.Flat;
            btnSalesReport.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSalesReport.ForeColor = Color.White;
            btnSalesReport.Location = new Point(15, 25);
            btnSalesReport.Margin = new Padding(3, 4, 3, 4);
            btnSalesReport.Name = "btnSalesReport";
            btnSalesReport.Size = new Size(220, 62);
            btnSalesReport.TabIndex = 0;
            btnSalesReport.Text = "📊 Sales Report";
            btnSalesReport.UseVisualStyleBackColor = false;
            btnSalesReport.Click += btnSalesReport_Click;
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 875);
            Controls.Add(panelMain);
            Controls.Add(panelTop);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ReportsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reports - ShopGreen";
            FormClosing += ReportsForm_FormClosing;
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelMain.ResumeLayout(false);
            panelReportView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            panelReportButtons.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}