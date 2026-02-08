namespace ShopGreenSystem
{
    partial class BrowseProductsForm
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
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Panel panelFilters;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Button btnClearFilters;
        private System.Windows.Forms.Label lblProductCount;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnShowDiscounted;
        private System.Windows.Forms.Button btnShowInStock;
        private System.Windows.Forms.Label lblCartCount;
        private System.Windows.Forms.Panel panelQuickActions;
        private System.Windows.Forms.Button btnQuickAddToCart;
        private System.Windows.Forms.Button btnQuickBuyNow;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.Button btnShowDiscountedPrices;
        private System.Windows.Forms.Button btnQuickCheckout;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnShowHighlyRated;

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
            lblCartCount = new Label();
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
            panelQuickActions = new Panel();
            btnQuickCheckout = new Button();
            btnShowDiscountedPrices = new Button();
            btnViewDetails = new Button();
            btnQuickBuyNow = new Button();
            btnQuickAddToCart = new Button();
            lblProductCount = new Label();
            dgvProducts = new DataGridView();
            panelFilters = new Panel();
            btnShowHighlyRated = new Button();
            btnSort = new Button();
            btnShowInStock = new Button();
            btnShowDiscounted = new Button();
            btnClearFilters = new Button();
            cmbCategory = new ComboBox();
            txtSearch = new TextBox();
            lblCategory = new Label();
            lblSearch = new Label();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelTop.SuspendLayout();
            panelMain.SuspendLayout();
            panelQuickActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            panelFilters.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(46, 125, 50);
            panelMenu.Controls.Add(lblCartCount);
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
            // lblCartCount
            // 
            lblCartCount.AutoSize = true;
            lblCartCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCartCount.ForeColor = Color.White;
            lblCartCount.Location = new Point(150, 380);
            lblCartCount.Name = "lblCartCount";
            lblCartCount.Size = new Size(89, 20);
            lblCartCount.TabIndex = 7;
            lblCartCount.Text = "🛒 Cart (0)";
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
            btnMyCart.Text = "🛒 My Cart";
            btnMyCart.TextAlign = ContentAlignment.MiddleLeft;
            btnMyCart.UseVisualStyleBackColor = true;
            btnMyCart.Click += btnMyCart_Click;
            btnMyCart.MouseEnter += MenuButton_MouseEnter;
            btnMyCart.MouseLeave += MenuButton_MouseLeave;
            // 
            // btnBrowseProducts
            // 
            btnBrowseProducts.BackColor = Color.FromArgb(37, 99, 41);
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
            btnBrowseProducts.UseVisualStyleBackColor = false;
            btnBrowseProducts.Click += btnBrowseProducts_Click;
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
            panelMain.Controls.Add(panelQuickActions);
            panelMain.Controls.Add(lblProductCount);
            panelMain.Controls.Add(dgvProducts);
            panelMain.Controls.Add(panelFilters);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(250, 125);
            panelMain.Margin = new Padding(3, 4, 3, 4);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(20, 25, 20, 25);
            panelMain.Size = new Size(950, 750);
            panelMain.TabIndex = 2;
            // 
            // panelQuickActions
            // 
            panelQuickActions.BackColor = Color.White;
            panelQuickActions.Controls.Add(btnQuickCheckout);
            panelQuickActions.Controls.Add(btnShowDiscountedPrices);
            panelQuickActions.Controls.Add(btnViewDetails);
            panelQuickActions.Controls.Add(btnQuickBuyNow);
            panelQuickActions.Controls.Add(btnQuickAddToCart);
            panelQuickActions.Location = new Point(20, 630);
            panelQuickActions.Margin = new Padding(3, 4, 3, 4);
            panelQuickActions.Name = "panelQuickActions";
            panelQuickActions.Size = new Size(910, 95);
            panelQuickActions.TabIndex = 3;
            // 
            // btnQuickCheckout
            // 
            btnQuickCheckout.BackColor = Color.FromArgb(156, 39, 176);
            btnQuickCheckout.Cursor = Cursors.Hand;
            btnQuickCheckout.FlatStyle = FlatStyle.Flat;
            btnQuickCheckout.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnQuickCheckout.ForeColor = Color.White;
            btnQuickCheckout.Location = new Point(730, 15);
            btnQuickCheckout.Margin = new Padding(3, 4, 3, 4);
            btnQuickCheckout.Name = "btnQuickCheckout";
            btnQuickCheckout.Size = new Size(170, 65);
            btnQuickCheckout.TabIndex = 4;
            btnQuickCheckout.Text = "💳 Go to Checkout";
            btnQuickCheckout.UseVisualStyleBackColor = false;
            btnQuickCheckout.Click += btnQuickCheckout_Click;
            // 
            // btnShowDiscountedPrices
            // 
            btnShowDiscountedPrices.BackColor = Color.FromArgb(255, 152, 0);
            btnShowDiscountedPrices.Cursor = Cursors.Hand;
            btnShowDiscountedPrices.FlatStyle = FlatStyle.Flat;
            btnShowDiscountedPrices.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnShowDiscountedPrices.ForeColor = Color.White;
            btnShowDiscountedPrices.Location = new Point(550, 15);
            btnShowDiscountedPrices.Margin = new Padding(3, 4, 3, 4);
            btnShowDiscountedPrices.Name = "btnShowDiscountedPrices";
            btnShowDiscountedPrices.Size = new Size(170, 65);
            btnShowDiscountedPrices.TabIndex = 3;
            btnShowDiscountedPrices.Text = "🔥 Show Discounts";
            btnShowDiscountedPrices.UseVisualStyleBackColor = false;
            btnShowDiscountedPrices.Click += btnShowDiscountedPrices_Click;
            // 
            // btnViewDetails
            // 
            btnViewDetails.BackColor = Color.FromArgb(33, 150, 243);
            btnViewDetails.Cursor = Cursors.Hand;
            btnViewDetails.FlatStyle = FlatStyle.Flat;
            btnViewDetails.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnViewDetails.ForeColor = Color.White;
            btnViewDetails.Location = new Point(370, 15);
            btnViewDetails.Margin = new Padding(3, 4, 3, 4);
            btnViewDetails.Name = "btnViewDetails";
            btnViewDetails.Size = new Size(170, 65);
            btnViewDetails.TabIndex = 2;
            btnViewDetails.Text = "📋 View Details";
            btnViewDetails.UseVisualStyleBackColor = false;
            btnViewDetails.Click += btnViewDetails_Click;
            // 
            // btnQuickBuyNow
            // 
            btnQuickBuyNow.BackColor = Color.FromArgb(46, 125, 50);
            btnQuickBuyNow.Cursor = Cursors.Hand;
            btnQuickBuyNow.FlatStyle = FlatStyle.Flat;
            btnQuickBuyNow.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnQuickBuyNow.ForeColor = Color.White;
            btnQuickBuyNow.Location = new Point(190, 15);
            btnQuickBuyNow.Margin = new Padding(3, 4, 3, 4);
            btnQuickBuyNow.Name = "btnQuickBuyNow";
            btnQuickBuyNow.Size = new Size(170, 65);
            btnQuickBuyNow.TabIndex = 1;
            btnQuickBuyNow.Text = "🚀 Buy Now";
            btnQuickBuyNow.UseVisualStyleBackColor = false;
            btnQuickBuyNow.Click += btnQuickBuyNow_Click;
            // 
            // btnQuickAddToCart
            // 
            btnQuickAddToCart.BackColor = Color.FromArgb(255, 193, 7);
            btnQuickAddToCart.Cursor = Cursors.Hand;
            btnQuickAddToCart.FlatStyle = FlatStyle.Flat;
            btnQuickAddToCart.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnQuickAddToCart.ForeColor = Color.White;
            btnQuickAddToCart.Location = new Point(10, 15);
            btnQuickAddToCart.Margin = new Padding(3, 4, 3, 4);
            btnQuickAddToCart.Name = "btnQuickAddToCart";
            btnQuickAddToCart.Size = new Size(170, 65);
            btnQuickAddToCart.TabIndex = 0;
            btnQuickAddToCart.Text = "🛒 Add to Cart";
            btnQuickAddToCart.UseVisualStyleBackColor = false;
            btnQuickAddToCart.Click += btnQuickAddToCart_Click;
            // 
            // lblProductCount
            // 
            lblProductCount.AutoSize = true;
            lblProductCount.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblProductCount.ForeColor = Color.Gray;
            lblProductCount.Location = new Point(20, 120);
            lblProductCount.Name = "lblProductCount";
            lblProductCount.Size = new Size(162, 23);
            lblProductCount.TabIndex = 2;
            lblProductCount.Text = "0 Product(s) Found";
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(20, 147);
            dgvProducts.Margin = new Padding(3, 4, 3, 4);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.RowTemplate.Height = 80;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(910, 475);
            dgvProducts.TabIndex = 1;
            dgvProducts.CellDoubleClick += dgvProducts_CellDoubleClick;
            dgvProducts.CellMouseClick += dgvProducts_CellMouseClick;
            // 
            // panelFilters
            // 
            panelFilters.BackColor = Color.White;
            panelFilters.Controls.Add(btnShowHighlyRated);
            panelFilters.Controls.Add(btnSort);
            panelFilters.Controls.Add(btnShowInStock);
            panelFilters.Controls.Add(btnShowDiscounted);
            panelFilters.Controls.Add(btnClearFilters);
            panelFilters.Controls.Add(cmbCategory);
            panelFilters.Controls.Add(txtSearch);
            panelFilters.Controls.Add(lblCategory);
            panelFilters.Controls.Add(lblSearch);
            panelFilters.Location = new Point(20, 25);
            panelFilters.Margin = new Padding(3, 4, 3, 4);
            panelFilters.Name = "panelFilters";
            panelFilters.Size = new Size(910, 91);
            panelFilters.TabIndex = 0;
            // 
            // btnShowHighlyRated
            // 
            btnShowHighlyRated.BackColor = Color.White;
            btnShowHighlyRated.Cursor = Cursors.Hand;
            btnShowHighlyRated.FlatStyle = FlatStyle.Flat;
            btnShowHighlyRated.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnShowHighlyRated.ForeColor = Color.FromArgb(255, 193, 7);
            btnShowHighlyRated.Location = new Point(740, 50);
            btnShowHighlyRated.Margin = new Padding(3, 4, 3, 4);
            btnShowHighlyRated.Name = "btnShowHighlyRated";
            btnShowHighlyRated.Size = new Size(150, 35);
            btnShowHighlyRated.TabIndex = 8;
            btnShowHighlyRated.Text = "⭐ Highly Rated";
            btnShowHighlyRated.UseVisualStyleBackColor = false;
            btnShowHighlyRated.Click += btnShowHighlyRated_Click;
            // 
            // btnSort
            // 
            btnSort.BackColor = Color.FromArgb(33, 150, 243);
            btnSort.Cursor = Cursors.Hand;
            btnSort.FlatStyle = FlatStyle.Flat;
            btnSort.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSort.ForeColor = Color.White;
            btnSort.Location = new Point(580, 10);
            btnSort.Margin = new Padding(3, 4, 3, 4);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(150, 35);
            btnSort.TabIndex = 7;
            btnSort.Text = "Sort: Name (A-Z)";
            btnSort.UseVisualStyleBackColor = false;
            btnSort.Click += btnSort_Click;
            // 
            // btnShowInStock
            // 
            btnShowInStock.BackColor = Color.White;
            btnShowInStock.Cursor = Cursors.Hand;
            btnShowInStock.FlatStyle = FlatStyle.Flat;
            btnShowInStock.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnShowInStock.ForeColor = Color.FromArgb(46, 125, 50);
            btnShowInStock.Location = new Point(580, 50);
            btnShowInStock.Margin = new Padding(3, 4, 3, 4);
            btnShowInStock.Name = "btnShowInStock";
            btnShowInStock.Size = new Size(150, 35);
            btnShowInStock.TabIndex = 6;
            btnShowInStock.Text = "📦 In Stock";
            btnShowInStock.UseVisualStyleBackColor = false;
            btnShowInStock.Click += btnShowInStock_Click;
            // 
            // btnShowDiscounted
            // 
            btnShowDiscounted.BackColor = Color.White;
            btnShowDiscounted.Cursor = Cursors.Hand;
            btnShowDiscounted.FlatStyle = FlatStyle.Flat;
            btnShowDiscounted.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnShowDiscounted.ForeColor = Color.FromArgb(255, 152, 0);
            btnShowDiscounted.Location = new Point(740, 10);
            btnShowDiscounted.Margin = new Padding(3, 4, 3, 4);
            btnShowDiscounted.Name = "btnShowDiscounted";
            btnShowDiscounted.Size = new Size(150, 35);
            btnShowDiscounted.TabIndex = 5;
            btnShowDiscounted.Text = "🔥 Discounted";
            btnShowDiscounted.UseVisualStyleBackColor = false;
            btnShowDiscounted.Click += btnShowDiscounted_Click;
            // 
            // btnClearFilters
            // 
            btnClearFilters.BackColor = Color.FromArgb(189, 189, 189);
            btnClearFilters.Cursor = Cursors.Hand;
            btnClearFilters.FlatStyle = FlatStyle.Flat;
            btnClearFilters.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClearFilters.ForeColor = Color.White;
            btnClearFilters.Location = new Point(410, 50);
            btnClearFilters.Margin = new Padding(3, 4, 3, 4);
            btnClearFilters.Name = "btnClearFilters";
            btnClearFilters.Size = new Size(150, 35);
            btnClearFilters.TabIndex = 4;
            btnClearFilters.Text = "🗑️ Clear Filters";
            btnClearFilters.UseVisualStyleBackColor = false;
            btnClearFilters.Click += btnClearFilters_Click;
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Font = new Font("Segoe UI", 10F);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(250, 50);
            cmbCategory.Margin = new Padding(3, 4, 3, 4);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(150, 31);
            cmbCategory.TabIndex = 3;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(20, 50);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search products...";
            txtSearch.Size = new Size(220, 30);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCategory.ForeColor = Color.FromArgb(46, 125, 50);
            lblCategory.Location = new Point(250, 20);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(89, 23);
            lblCategory.TabIndex = 1;
            lblCategory.Text = "Category:";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSearch.ForeColor = Color.FromArgb(46, 125, 50);
            lblSearch.Location = new Point(20, 20);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(68, 23);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search:";
            // 
            // BrowseProductsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 875);
            Controls.Add(panelMain);
            Controls.Add(panelTop);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "BrowseProductsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Browse Products - ShopGreen";
            FormClosing += BrowseProductsForm_FormClosing;
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            panelQuickActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            panelFilters.ResumeLayout(false);
            panelFilters.PerformLayout();
            ResumeLayout(false);
        }
    }
}