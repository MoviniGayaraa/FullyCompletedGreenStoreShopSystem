namespace ShopGreenSystem
{
    partial class CustomerDashboardForm
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
        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.Panel panelCard1;
        private System.Windows.Forms.Panel panelCard2;
        private System.Windows.Forms.Panel panelCard3;
        private System.Windows.Forms.Panel panelCard4;
        private System.Windows.Forms.Label lblTotalOrdersTitle;
        private System.Windows.Forms.Label lblTotalOrdersValue;
        private System.Windows.Forms.Label lblPendingOrdersTitle;
        private System.Windows.Forms.Label lblPendingOrdersValue;
        private System.Windows.Forms.Label lblCartItemsTitle;
        private System.Windows.Forms.Label lblCartItemsValue;
        private System.Windows.Forms.Label lblTotalSpentTitle;
        private System.Windows.Forms.Label lblTotalSpentValue;
        private System.Windows.Forms.Panel panelFeaturedProducts;
        private System.Windows.Forms.DataGridView dgvFeaturedProducts;
        private System.Windows.Forms.Label lblFeaturedProductsTitle;
        private System.Windows.Forms.Button btnRefresh;

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
            panelFeaturedProducts = new Panel();
            dgvFeaturedProducts = new DataGridView();
            lblFeaturedProductsTitle = new Label();
            panelStats = new Panel();
            panelCard4 = new Panel();
            lblTotalSpentValue = new Label();
            lblTotalSpentTitle = new Label();
            panelCard3 = new Panel();
            lblCartItemsValue = new Label();
            lblCartItemsTitle = new Label();
            panelCard2 = new Panel();
            lblPendingOrdersValue = new Label();
            lblPendingOrdersTitle = new Label();
            panelCard1 = new Panel();
            lblTotalOrdersValue = new Label();
            lblTotalOrdersTitle = new Label();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelTop.SuspendLayout();
            panelMain.SuspendLayout();
            panelFeaturedProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFeaturedProducts).BeginInit();
            panelStats.SuspendLayout();
            panelCard4.SuspendLayout();
            panelCard3.SuspendLayout();
            panelCard2.SuspendLayout();
            panelCard1.SuspendLayout();
            SuspendLayout();

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

            // btnMyProfile
            // 
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
            btnMyProfile.UseVisualStyleBackColor = true;
            btnMyProfile.Click += btnMyProfile_Click;
            btnMyProfile.MouseEnter += MenuButton_MouseEnter;
            btnMyProfile.MouseLeave += MenuButton_MouseLeave;

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

            // btnStore
            // 
            btnStore.BackColor = Color.FromArgb(37, 99, 41);
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
            btnStore.UseVisualStyleBackColor = false;
            btnStore.Click += btnStore_Click;

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

            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(245, 245, 245);
            panelMain.Controls.Add(panelFeaturedProducts);
            panelMain.Controls.Add(panelStats);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(250, 125);
            panelMain.Margin = new Padding(3, 4, 3, 4);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(20, 25, 20, 25);
            panelMain.Size = new Size(950, 750);
            panelMain.TabIndex = 2;

            // panelFeaturedProducts
            // 
            panelFeaturedProducts.BackColor = Color.White;
            panelFeaturedProducts.Controls.Add(dgvFeaturedProducts);
            panelFeaturedProducts.Controls.Add(lblFeaturedProductsTitle);
            panelFeaturedProducts.Dock = DockStyle.Fill;
            panelFeaturedProducts.Location = new Point(20, 213);
            panelFeaturedProducts.Margin = new Padding(3, 4, 3, 4);
            panelFeaturedProducts.Name = "panelFeaturedProducts";
            panelFeaturedProducts.Padding = new Padding(15, 19, 15, 19);
            panelFeaturedProducts.Size = new Size(910, 512);
            panelFeaturedProducts.TabIndex = 1;

            // dgvFeaturedProducts
            // 
            dgvFeaturedProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFeaturedProducts.Dock = DockStyle.Fill;
            dgvFeaturedProducts.Location = new Point(15, 63);
            dgvFeaturedProducts.Margin = new Padding(3, 4, 3, 4);
            dgvFeaturedProducts.Name = "dgyFeaturedProducts";
            dgvFeaturedProducts.RowHeadersWidth = 51;
            dgvFeaturedProducts.RowTemplate.Height = 24;
            dgvFeaturedProducts.Size = new Size(880, 430);
            dgvFeaturedProducts.TabIndex = 1;
            dgvFeaturedProducts.CellDoubleClick += dgvFeaturedProducts_CellDoubleClick;

            // lblFeaturedProductsTitle
            // 
            lblFeaturedProductsTitle.Dock = DockStyle.Top;
            lblFeaturedProductsTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblFeaturedProductsTitle.ForeColor = Color.FromArgb(46, 125, 50);
            lblFeaturedProductsTitle.Location = new Point(15, 19);
            lblFeaturedProductsTitle.Name = "lblFeaturedProductsTitle";
            lblFeaturedProductsTitle.Size = new Size(880, 44);
            lblFeaturedProductsTitle.TabIndex = 0;
            lblFeaturedProductsTitle.Text = "🌟 Featured Products";
            lblFeaturedProductsTitle.Click += lblFeaturedProductsTitle_Click;

            // panelStats
            // 
            panelStats.Controls.Add(panelCard4);
            panelStats.Controls.Add(panelCard3);
            panelStats.Controls.Add(panelCard2);
            panelStats.Controls.Add(panelCard1);
            panelStats.Dock = DockStyle.Top;
            panelStats.Location = new Point(20, 25);
            panelStats.Margin = new Padding(3, 4, 3, 4);
            panelStats.Name = "panelStats";
            panelStats.Size = new Size(910, 188);
            panelStats.TabIndex = 0;

            // panelCard4
            // 
            panelCard4.BackColor = Color.White;
            panelCard4.Controls.Add(lblTotalSpentValue);
            panelCard4.Controls.Add(lblTotalSpentTitle);
            panelCard4.Cursor = Cursors.Hand;
            panelCard4.Location = new Point(690, 12);
            panelCard4.Margin = new Padding(3, 4, 3, 4);
            panelCard4.Name = "panelCard4";
            panelCard4.Size = new Size(210, 162);
            panelCard4.TabIndex = 3;
            panelCard4.Paint += panelCard4_Paint;
            panelCard4.MouseEnter += Card_MouseEnter;
            panelCard4.MouseLeave += Card_MouseLeave;

            // lblTotalSpentValue
            // 
            lblTotalSpentValue.AutoEllipsis = true;
            lblTotalSpentValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTotalSpentValue.ForeColor = Color.FromArgb(156, 39, 176);
            lblTotalSpentValue.Location = new Point(10, 60);
            lblTotalSpentValue.Name = "lblTotalSpentValue";
            lblTotalSpentValue.Size = new Size(190, 90);
            lblTotalSpentValue.TabIndex = 1;
            lblTotalSpentValue.Text = "Rs. 0.00";
            lblTotalSpentValue.TextAlign = ContentAlignment.MiddleCenter;

            // lblTotalSpentTitle
            // 
            lblTotalSpentTitle.AutoSize = true;
            lblTotalSpentTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalSpentTitle.ForeColor = Color.FromArgb(38, 50, 56);
            lblTotalSpentTitle.Location = new Point(15, 20);
            lblTotalSpentTitle.Name = "lblTotalSpentTitle";
            lblTotalSpentTitle.Size = new Size(153, 28);
            lblTotalSpentTitle.TabIndex = 0;
            lblTotalSpentTitle.Text = "💰 Total Spent";

            // panelCard3
            // 
            panelCard3.BackColor = Color.White;
            panelCard3.Controls.Add(lblCartItemsValue);
            panelCard3.Controls.Add(lblCartItemsTitle);
            panelCard3.Cursor = Cursors.Hand;
            panelCard3.Location = new Point(465, 12);
            panelCard3.Margin = new Padding(3, 4, 3, 4);
            panelCard3.Name = "panelCard3";
            panelCard3.Size = new Size(210, 162);
            panelCard3.TabIndex = 2;
            panelCard3.MouseEnter += Card_MouseEnter;
            panelCard3.MouseLeave += Card_MouseLeave;

            // lblCartItemsValue
            // 
            lblCartItemsValue.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblCartItemsValue.ForeColor = Color.FromArgb(255, 152, 0);
            lblCartItemsValue.Location = new Point(10, 75);
            lblCartItemsValue.Name = "lblCartItemsValue";
            lblCartItemsValue.Size = new Size(190, 75);
            lblCartItemsValue.TabIndex = 1;
            lblCartItemsValue.Text = "0";
            lblCartItemsValue.TextAlign = ContentAlignment.MiddleCenter;

            // lblCartItemsTitle
            // 
            lblCartItemsTitle.AutoSize = true;
            lblCartItemsTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCartItemsTitle.ForeColor = Color.FromArgb(38, 50, 56);
            lblCartItemsTitle.Location = new Point(15, 25);
            lblCartItemsTitle.Name = "lblCartItemsTitle";
            lblCartItemsTitle.Size = new Size(144, 28);
            lblCartItemsTitle.TabIndex = 0;
            lblCartItemsTitle.Text = "\U0001f6d2 Cart Items";

            // panelCard2
            // 
            panelCard2.BackColor = Color.White;
            panelCard2.Controls.Add(lblPendingOrdersValue);
            panelCard2.Controls.Add(lblPendingOrdersTitle);
            panelCard2.Cursor = Cursors.Hand;
            panelCard2.Location = new Point(240, 12);
            panelCard2.Margin = new Padding(3, 4, 3, 4);
            panelCard2.Name = "panelCard2";
            panelCard2.Size = new Size(210, 162);
            panelCard2.TabIndex = 1;
            panelCard2.MouseEnter += Card_MouseEnter;
            panelCard2.MouseLeave += Card_MouseLeave;

            // lblPendingOrdersValue
            // 
            lblPendingOrdersValue.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblPendingOrdersValue.ForeColor = Color.FromArgb(33, 150, 243);
            lblPendingOrdersValue.Location = new Point(10, 75);
            lblPendingOrdersValue.Name = "lblPendingOrdersValue";
            lblPendingOrdersValue.Size = new Size(190, 75);
            lblPendingOrdersValue.TabIndex = 1;
            lblPendingOrdersValue.Text = "0";
            lblPendingOrdersValue.TextAlign = ContentAlignment.MiddleCenter;

            // lblPendingOrdersTitle
            // 
            lblPendingOrdersTitle.AutoSize = true;
            lblPendingOrdersTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPendingOrdersTitle.ForeColor = Color.FromArgb(38, 50, 56);
            lblPendingOrdersTitle.Location = new Point(15, 25);
            lblPendingOrdersTitle.Name = "lblPendingOrdersTitle";
            lblPendingOrdersTitle.Size = new Size(175, 28);
            lblPendingOrdersTitle.TabIndex = 0;
            lblPendingOrdersTitle.Text = "📦 Active Orders";

            // panelCard1
            // 
            panelCard1.BackColor = Color.White;
            panelCard1.Controls.Add(lblTotalOrdersValue);
            panelCard1.Controls.Add(lblTotalOrdersTitle);
            panelCard1.Cursor = Cursors.Hand;
            panelCard1.Location = new Point(10, 12);
            panelCard1.Margin = new Padding(3, 4, 3, 4);
            panelCard1.Name = "panelCard1";
            panelCard1.Size = new Size(210, 162);
            panelCard1.TabIndex = 0;
            panelCard1.MouseEnter += Card_MouseEnter;
            panelCard1.MouseLeave += Card_MouseLeave;

            // lblTotalOrdersValue
            // 
            lblTotalOrdersValue.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblTotalOrdersValue.ForeColor = Color.FromArgb(46, 125, 50);
            lblTotalOrdersValue.Location = new Point(10, 75);
            lblTotalOrdersValue.Name = "lblTotalOrdersValue";
            lblTotalOrdersValue.Size = new Size(190, 75);
            lblTotalOrdersValue.TabIndex = 1;
            lblTotalOrdersValue.Text = "0";
            lblTotalOrdersValue.TextAlign = ContentAlignment.MiddleCenter;

            // lblTotalOrdersTitle
            // 
            lblTotalOrdersTitle.AutoSize = true;
            lblTotalOrdersTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalOrdersTitle.ForeColor = Color.FromArgb(38, 50, 56);
            lblTotalOrdersTitle.Location = new Point(15, 25);
            lblTotalOrdersTitle.Name = "lblTotalOrdersTitle";
            lblTotalOrdersTitle.Size = new Size(162, 28);
            lblTotalOrdersTitle.TabIndex = 0;
            lblTotalOrdersTitle.Text = "📋 Total Orders";

            // CustomerDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 875);
            Controls.Add(panelMain);
            Controls.Add(panelTop);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "CustomerDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer Dashboard - ShopGreen";
            FormClosing += CustomerDashboardForm_FormClosing;
            Load += CustomerDashboardForm_Load;
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelMain.ResumeLayout(false);
            panelFeaturedProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFeaturedProducts).EndInit();
            panelStats.ResumeLayout(false);
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