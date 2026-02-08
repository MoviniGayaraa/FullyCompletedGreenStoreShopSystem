namespace ShopGreenSystem
{
    partial class AdminDashboardForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Button btnManageProducts;
        private System.Windows.Forms.Button btnManageCustomers;
        private System.Windows.Forms.Button btnManageOrders;
        private System.Windows.Forms.Button btnGenerateReports;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelCard1;
        private System.Windows.Forms.Panel panelCard2;
        private System.Windows.Forms.Panel panelCard3;
        private System.Windows.Forms.Panel panelCard4;
        private System.Windows.Forms.Panel panelCard5;
        private System.Windows.Forms.Label lblTotalSales;
        private System.Windows.Forms.Label lblTotalSalesValue;
        private System.Windows.Forms.Label lblProductsInStock;
        private System.Windows.Forms.Label lblProductsInStockValue;
        private System.Windows.Forms.Label lblActiveOrders;
        private System.Windows.Forms.Label lblActiveOrdersValue;
        private System.Windows.Forms.Label lblTotalCustomers;
        private System.Windows.Forms.Label lblTotalCustomersValue;
        private System.Windows.Forms.Label lblLowStock;
        private System.Windows.Forms.Label lblLowStockValue;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.PictureBox pictureBoxLogo;

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
            btnRefresh = new Button();
            lblWelcome = new Label();
            lblTitle = new Label();
            panelContent = new Panel();
            panelCard5 = new Panel();
            lblLowStockValue = new Label();
            lblLowStock = new Label();
            panelCard4 = new Panel();
            lblTotalCustomersValue = new Label();
            lblTotalCustomers = new Label();
            panelCard3 = new Panel();
            lblActiveOrdersValue = new Label();
            lblActiveOrders = new Label();
            panelCard2 = new Panel();
            lblProductsInStockValue = new Label();
            lblProductsInStock = new Label();
            panelCard1 = new Panel();
            lblTotalSalesValue = new Label();
            lblTotalSales = new Label();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelTop.SuspendLayout();
            panelContent.SuspendLayout();
            panelCard5.SuspendLayout();
            panelCard4.SuspendLayout();
            panelCard3.SuspendLayout();
            panelCard2.SuspendLayout();
            panelCard1.SuspendLayout();
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
            btnManageProducts.Text = "🛒 Manage Products";
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
            lblWelcome.Size = new Size(166, 28);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome, Admin!";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(46, 125, 50);
            lblTitle.Location = new Point(25, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(273, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Admin Dashboard";
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.FromArgb(245, 245, 245);
            panelContent.Controls.Add(panelCard5);
            panelContent.Controls.Add(panelCard4);
            panelContent.Controls.Add(panelCard3);
            panelContent.Controls.Add(panelCard2);
            panelContent.Controls.Add(panelCard1);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(250, 125);
            panelContent.Margin = new Padding(3, 4, 3, 4);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(20, 25, 20, 25);
            panelContent.Size = new Size(950, 750);
            panelContent.TabIndex = 2;
            panelContent.Paint += panelContent_Paint;
            // 
            // panelCard5
            // 
            panelCard5.BackColor = Color.White;
            panelCard5.Controls.Add(lblLowStockValue);
            panelCard5.Controls.Add(lblLowStock);
            panelCard5.Cursor = Cursors.Hand;
            panelCard5.Location = new Point(490, 400);
            panelCard5.Margin = new Padding(3, 4, 3, 4);
            panelCard5.Name = "panelCard5";
            panelCard5.Size = new Size(420, 188);
            panelCard5.TabIndex = 4;
            panelCard5.MouseEnter += Card_MouseEnter;
            panelCard5.MouseLeave += Card_MouseLeave;
            // 
            // lblLowStockValue
            // 
            lblLowStockValue.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            lblLowStockValue.ForeColor = Color.FromArgb(255, 152, 0);
            lblLowStockValue.Location = new Point(20, 75);
            lblLowStockValue.Name = "lblLowStockValue";
            lblLowStockValue.Size = new Size(380, 88);
            lblLowStockValue.TabIndex = 1;
            lblLowStockValue.Text = "0";
            lblLowStockValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLowStock
            // 
            lblLowStock.AutoSize = true;
            lblLowStock.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblLowStock.ForeColor = Color.FromArgb(38, 50, 56);
            lblLowStock.Location = new Point(20, 25);
            lblLowStock.Name = "lblLowStock";
            lblLowStock.Size = new Size(233, 32);
            lblLowStock.TabIndex = 0;
            lblLowStock.Text = "⚠️ Low Stock Alert";
            // 
            // panelCard4
            // 
            panelCard4.BackColor = Color.White;
            panelCard4.Controls.Add(lblTotalCustomersValue);
            panelCard4.Controls.Add(lblTotalCustomers);
            panelCard4.Cursor = Cursors.Hand;
            panelCard4.Location = new Point(40, 400);
            panelCard4.Margin = new Padding(3, 4, 3, 4);
            panelCard4.Name = "panelCard4";
            panelCard4.Size = new Size(420, 188);
            panelCard4.TabIndex = 3;
            panelCard4.MouseEnter += Card_MouseEnter;
            panelCard4.MouseLeave += Card_MouseLeave;
            // 
            // lblTotalCustomersValue
            // 
            lblTotalCustomersValue.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            lblTotalCustomersValue.ForeColor = Color.FromArgb(156, 39, 176);
            lblTotalCustomersValue.Location = new Point(20, 75);
            lblTotalCustomersValue.Name = "lblTotalCustomersValue";
            lblTotalCustomersValue.Size = new Size(380, 88);
            lblTotalCustomersValue.TabIndex = 1;
            lblTotalCustomersValue.Text = "0";
            lblTotalCustomersValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalCustomers
            // 
            lblTotalCustomers.AutoSize = true;
            lblTotalCustomers.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTotalCustomers.ForeColor = Color.FromArgb(38, 50, 56);
            lblTotalCustomers.Location = new Point(20, 25);
            lblTotalCustomers.Name = "lblTotalCustomers";
            lblTotalCustomers.Size = new Size(239, 32);
            lblTotalCustomers.TabIndex = 0;
            lblTotalCustomers.Text = "👥 Total Customers";
            // 
            // panelCard3
            // 
            panelCard3.BackColor = Color.White;
            panelCard3.Controls.Add(lblActiveOrdersValue);
            panelCard3.Controls.Add(lblActiveOrders);
            panelCard3.Cursor = Cursors.Hand;
            panelCard3.Location = new Point(630, 50);
            panelCard3.Margin = new Padding(3, 4, 3, 4);
            panelCard3.Name = "panelCard3";
            panelCard3.Size = new Size(280, 275);
            panelCard3.TabIndex = 2;
            panelCard3.MouseEnter += Card_MouseEnter;
            panelCard3.MouseLeave += Card_MouseLeave;
            // 
            // lblActiveOrdersValue
            // 
            lblActiveOrdersValue.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblActiveOrdersValue.ForeColor = Color.FromArgb(255, 152, 0);
            lblActiveOrdersValue.Location = new Point(20, 100);
            lblActiveOrdersValue.Name = "lblActiveOrdersValue";
            lblActiveOrdersValue.Size = new Size(240, 125);
            lblActiveOrdersValue.TabIndex = 1;
            lblActiveOrdersValue.Text = "0";
            lblActiveOrdersValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblActiveOrders
            // 
            lblActiveOrders.AutoSize = true;
            lblActiveOrders.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblActiveOrders.ForeColor = Color.FromArgb(38, 50, 56);
            lblActiveOrders.Location = new Point(20, 25);
            lblActiveOrders.Name = "lblActiveOrders";
            lblActiveOrders.Size = new Size(210, 32);
            lblActiveOrders.TabIndex = 0;
            lblActiveOrders.Text = "📦 Active Orders";
            // 
            // panelCard2
            // 
            panelCard2.BackColor = Color.White;
            panelCard2.Controls.Add(lblProductsInStockValue);
            panelCard2.Controls.Add(lblProductsInStock);
            panelCard2.Cursor = Cursors.Hand;
            panelCard2.Location = new Point(330, 50);
            panelCard2.Margin = new Padding(3, 4, 3, 4);
            panelCard2.Name = "panelCard2";
            panelCard2.Size = new Size(280, 275);
            panelCard2.TabIndex = 1;
            panelCard2.MouseEnter += Card_MouseEnter;
            panelCard2.MouseLeave += Card_MouseLeave;
            // 
            // lblProductsInStockValue
            // 
            lblProductsInStockValue.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblProductsInStockValue.ForeColor = Color.FromArgb(33, 150, 243);
            lblProductsInStockValue.Location = new Point(20, 100);
            lblProductsInStockValue.Name = "lblProductsInStockValue";
            lblProductsInStockValue.Size = new Size(240, 125);
            lblProductsInStockValue.TabIndex = 1;
            lblProductsInStockValue.Text = "0";
            lblProductsInStockValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblProductsInStock
            // 
            lblProductsInStock.AutoSize = true;
            lblProductsInStock.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblProductsInStock.ForeColor = Color.FromArgb(38, 50, 56);
            lblProductsInStock.Location = new Point(20, 25);
            lblProductsInStock.Name = "lblProductsInStock";
            lblProductsInStock.Size = new Size(226, 32);
            lblProductsInStock.TabIndex = 0;
            lblProductsInStock.Text = "🛒 Total Products";
            // 
            // panelCard1
            // 
            panelCard1.BackColor = Color.White;
            panelCard1.Controls.Add(lblTotalSalesValue);
            panelCard1.Controls.Add(lblTotalSales);
            panelCard1.Cursor = Cursors.Hand;
            panelCard1.Location = new Point(40, 50);
            panelCard1.Margin = new Padding(3, 4, 3, 4);
            panelCard1.Name = "panelCard1";
            panelCard1.Size = new Size(280, 275);
            panelCard1.TabIndex = 0;
            panelCard1.MouseEnter += Card_MouseEnter;
            panelCard1.MouseLeave += Card_MouseLeave;
            // 
            // lblTotalSalesValue
            // 
            lblTotalSalesValue.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTotalSalesValue.ForeColor = Color.FromArgb(46, 125, 50);
            lblTotalSalesValue.Location = new Point(20, 100);
            lblTotalSalesValue.Name = "lblTotalSalesValue";
            lblTotalSalesValue.Size = new Size(240, 125);
            lblTotalSalesValue.TabIndex = 1;
            lblTotalSalesValue.Text = "Rs. 0.00";
            lblTotalSalesValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalSales
            // 
            lblTotalSales.AutoSize = true;
            lblTotalSales.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTotalSales.ForeColor = Color.FromArgb(38, 50, 56);
            lblTotalSales.Location = new Point(20, 25);
            lblTotalSales.Name = "lblTotalSales";
            lblTotalSales.Size = new Size(175, 32);
            lblTotalSales.TabIndex = 0;
            lblTotalSales.Text = "💰 Total Sales";
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 875);
            Controls.Add(panelContent);
            Controls.Add(panelTop);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Dashboard - ShopGreen";
            FormClosing += AdminDashboardForm_FormClosing;
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelContent.ResumeLayout(false);
            panelCard5.ResumeLayout(false);
            panelCard5.PerformLayout();
            panelCard4.ResumeLayout(false);
            panelCard4.PerformLayout();
            panelCard3.ResumeLayout(false);
            panelCard3.PerformLayout();
            panelCard2.ResumeLayout(false);
            panelCard2.PerformLayout();
            panelCard1.ResumeLayout(false);
            panelCard1.PerformLayout();
            ResumeLayout(false);
        }
    }
}