namespace ShopGreenSystem
{
    partial class MyCartForm
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
        private System.Windows.Forms.Panel panelCart;
        private System.Windows.Forms.DataGridView dgvCartItems;
        private System.Windows.Forms.Label lblCartTitle;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblCartSummary;
        private System.Windows.Forms.Panel panelCartActions;
        private System.Windows.Forms.Button btnRemoveSelected;
        private System.Windows.Forms.Button btnClearCart;
        private System.Windows.Forms.Panel panelOrderSummary;
        private System.Windows.Forms.Label lblOrderSummaryTitle;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblSubtotalValue;
        private System.Windows.Forms.Label lblShipping;
        private System.Windows.Forms.Label lblShippingValue;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnContinueShopping;

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
            btnContinueShopping = new Button();
            panelOrderSummary = new Panel();
            btnCheckout = new Button();
            lblTotalValue = new Label();
            lblTotal = new Label();
            lblShippingValue = new Label();
            lblShipping = new Label();
            lblSubtotalValue = new Label();
            lblSubtotal = new Label();
            lblOrderSummaryTitle = new Label();
            panelCart = new Panel();
            dgvCartItems = new DataGridView();
            lblCartSummary = new Label();
            lblCartTitle = new Label();
            btnRemoveSelected = new Button();
            btnClearCart = new Button();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelTop.SuspendLayout();
            panelMain.SuspendLayout();
            panelOrderSummary.SuspendLayout();
            panelCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCartItems).BeginInit();
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
            btnMyCart.BackColor = Color.FromArgb(37, 99, 41);
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
            btnMyCart.UseVisualStyleBackColor = false;
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
            panelMain.Controls.Add(btnContinueShopping);
            panelMain.Controls.Add(panelOrderSummary);
            panelMain.Controls.Add(panelCart);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(250, 125);
            panelMain.Margin = new Padding(3, 4, 3, 4);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(20, 25, 20, 25);
            panelMain.Size = new Size(950, 750);
            panelMain.TabIndex = 2;
            panelMain.Paint += panelMain_Paint;
            // 
            // btnContinueShopping
            // 
            btnContinueShopping.BackColor = Color.White;
            btnContinueShopping.Cursor = Cursors.Hand;
            btnContinueShopping.FlatAppearance.BorderColor = Color.FromArgb(46, 125, 50);
            btnContinueShopping.FlatAppearance.BorderSize = 2;
            btnContinueShopping.FlatStyle = FlatStyle.Flat;
            btnContinueShopping.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnContinueShopping.ForeColor = Color.FromArgb(46, 125, 50);
            btnContinueShopping.Location = new Point(20, 475);
            btnContinueShopping.Margin = new Padding(3, 4, 3, 4);
            btnContinueShopping.Name = "btnContinueShopping";
            btnContinueShopping.Size = new Size(550, 62);
            btnContinueShopping.TabIndex = 4;
            btnContinueShopping.Text = "🛍️ Continue Shopping";
            btnContinueShopping.UseVisualStyleBackColor = false;
            btnContinueShopping.Click += btnContinueShopping_Click;
            // 
            // panelOrderSummary
            // 
            panelOrderSummary.BackColor = Color.White;
            panelOrderSummary.Controls.Add(btnCheckout);
            panelOrderSummary.Controls.Add(lblTotalValue);
            panelOrderSummary.Controls.Add(lblTotal);
            panelOrderSummary.Controls.Add(lblShippingValue);
            panelOrderSummary.Controls.Add(lblShipping);
            panelOrderSummary.Controls.Add(lblSubtotalValue);
            panelOrderSummary.Controls.Add(lblSubtotal);
            panelOrderSummary.Controls.Add(lblOrderSummaryTitle);
            panelOrderSummary.Location = new Point(590, 363);
            panelOrderSummary.Margin = new Padding(3, 4, 3, 4);
            panelOrderSummary.Name = "panelOrderSummary";
            panelOrderSummary.Padding = new Padding(15, 19, 15, 19);
            panelOrderSummary.Size = new Size(340, 362);
            panelOrderSummary.TabIndex = 3;
            // 
            // btnCheckout
            // 
            btnCheckout.BackColor = Color.FromArgb(46, 125, 50);
            btnCheckout.Cursor = Cursors.Hand;
            btnCheckout.FlatAppearance.BorderSize = 0;
            btnCheckout.FlatStyle = FlatStyle.Flat;
            btnCheckout.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCheckout.ForeColor = Color.White;
            btnCheckout.Location = new Point(15, 275);
            btnCheckout.Margin = new Padding(3, 4, 3, 4);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(310, 62);
            btnCheckout.TabIndex = 7;
            btnCheckout.Text = "💳 Proceed to Checkout";
            btnCheckout.UseVisualStyleBackColor = false;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // lblTotalValue
            // 
            lblTotalValue.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTotalValue.ForeColor = Color.FromArgb(46, 125, 50);
            lblTotalValue.Location = new Point(150, 200);
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new Size(175, 35);
            lblTotalValue.TabIndex = 6;
            lblTotalValue.Text = "Rs. 0.00";
            lblTotalValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTotal.Location = new Point(15, 200);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(129, 35);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Total:";
            lblTotal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblShippingValue
            // 
            lblShippingValue.Font = new Font("Segoe UI", 12F);
            lblShippingValue.ForeColor = Color.Gray;
            lblShippingValue.Location = new Point(150, 150);
            lblShippingValue.Name = "lblShippingValue";
            lblShippingValue.Size = new Size(175, 30);
            lblShippingValue.TabIndex = 4;
            lblShippingValue.Text = "Rs. 0.00";
            lblShippingValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblShipping
            // 
            lblShipping.Font = new Font("Segoe UI", 12F);
            lblShipping.ForeColor = Color.Gray;
            lblShipping.Location = new Point(15, 150);
            lblShipping.Name = "lblShipping";
            lblShipping.Size = new Size(129, 30);
            lblShipping.TabIndex = 3;
            lblShipping.Text = "Shipping:";
            lblShipping.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSubtotalValue
            // 
            lblSubtotalValue.Font = new Font("Segoe UI", 12F);
            lblSubtotalValue.ForeColor = Color.Gray;
            lblSubtotalValue.Location = new Point(150, 100);
            lblSubtotalValue.Name = "lblSubtotalValue";
            lblSubtotalValue.Size = new Size(175, 30);
            lblSubtotalValue.TabIndex = 2;
            lblSubtotalValue.Text = "Rs. 0.00";
            lblSubtotalValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSubtotal
            // 
            lblSubtotal.Font = new Font("Segoe UI", 12F);
            lblSubtotal.ForeColor = Color.Gray;
            lblSubtotal.Location = new Point(15, 100);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(129, 30);
            lblSubtotal.TabIndex = 1;
            lblSubtotal.Text = "Subtotal:";
            lblSubtotal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblOrderSummaryTitle
            // 
            lblOrderSummaryTitle.Dock = DockStyle.Top;
            lblOrderSummaryTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblOrderSummaryTitle.ForeColor = Color.FromArgb(46, 125, 50);
            lblOrderSummaryTitle.Location = new Point(15, 19);
            lblOrderSummaryTitle.Name = "lblOrderSummaryTitle";
            lblOrderSummaryTitle.Size = new Size(310, 44);
            lblOrderSummaryTitle.TabIndex = 0;
            lblOrderSummaryTitle.Text = "💰 Order Summary";
            lblOrderSummaryTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelCart
            // 
            panelCart.BackColor = Color.White;
            panelCart.Controls.Add(dgvCartItems);
            panelCart.Controls.Add(lblCartSummary);
            panelCart.Controls.Add(lblCartTitle);
            panelCart.Dock = DockStyle.Top;
            panelCart.Location = new Point(20, 25);
            panelCart.Margin = new Padding(3, 4, 3, 4);
            panelCart.Name = "panelCart";
            panelCart.Padding = new Padding(15, 19, 15, 19);
            panelCart.Size = new Size(910, 325);
            panelCart.TabIndex = 0;
            // 
            // dgvCartItems
            // 
            dgvCartItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCartItems.Dock = DockStyle.Fill;
            dgvCartItems.Location = new Point(15, 107);
            dgvCartItems.Margin = new Padding(3, 4, 3, 4);
            dgvCartItems.Name = "dgvCartItems";
            dgvCartItems.RowHeadersWidth = 51;
            dgvCartItems.RowTemplate.Height = 24;
            dgvCartItems.Size = new Size(880, 199);
            dgvCartItems.TabIndex = 2;
            dgvCartItems.CellValueChanged += dgvCartItems_CellValueChanged;
            // 
            // lblCartSummary
            // 
            lblCartSummary.Dock = DockStyle.Top;
            lblCartSummary.Font = new Font("Segoe UI", 11F);
            lblCartSummary.ForeColor = Color.Gray;
            lblCartSummary.Location = new Point(15, 63);
            lblCartSummary.Name = "lblCartSummary";
            lblCartSummary.Size = new Size(880, 44);
            lblCartSummary.TabIndex = 1;
            lblCartSummary.Text = "You have 0 items in your cart";
            lblCartSummary.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCartTitle
            // 
            lblCartTitle.Dock = DockStyle.Top;
            lblCartTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblCartTitle.ForeColor = Color.FromArgb(46, 125, 50);
            lblCartTitle.Location = new Point(15, 19);
            lblCartTitle.Name = "lblCartTitle";
            lblCartTitle.Size = new Size(880, 44);
            lblCartTitle.TabIndex = 0;
            lblCartTitle.Text = "\U0001f6d2 My Shopping Cart";
            lblCartTitle.TextAlign = ContentAlignment.MiddleLeft;
            lblCartTitle.Click += lblCartTitle_Click;
            // 
            // btnRemoveSelected
            // 
            btnRemoveSelected.BackColor = Color.FromArgb(244, 67, 54);
            btnRemoveSelected.Cursor = Cursors.Hand;
            btnRemoveSelected.FlatAppearance.BorderSize = 0;
            btnRemoveSelected.FlatStyle = FlatStyle.Flat;
            btnRemoveSelected.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRemoveSelected.ForeColor = Color.White;
            btnRemoveSelected.Location = new Point(15, 19);
            btnRemoveSelected.Margin = new Padding(3, 4, 3, 4);
            btnRemoveSelected.Name = "btnRemoveSelected";
            btnRemoveSelected.Size = new Size(250, 62);
            btnRemoveSelected.TabIndex = 0;
            btnRemoveSelected.Text = "🗑️ Remove Selected";
            btnRemoveSelected.UseVisualStyleBackColor = false;
            btnRemoveSelected.Click += btnRemoveSelected_Click;
            // 
            // btnClearCart
            // 
            btnClearCart.BackColor = Color.FromArgb(255, 193, 7);
            btnClearCart.Cursor = Cursors.Hand;
            btnClearCart.FlatAppearance.BorderSize = 0;
            btnClearCart.FlatStyle = FlatStyle.Flat;
            btnClearCart.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClearCart.ForeColor = Color.White;
            btnClearCart.Location = new Point(285, 19);
            btnClearCart.Margin = new Padding(3, 4, 3, 4);
            btnClearCart.Name = "btnClearCart";
            btnClearCart.Size = new Size(250, 62);
            btnClearCart.TabIndex = 1;
            btnClearCart.Text = "🗑️ Clear Cart";
            btnClearCart.UseVisualStyleBackColor = false;
            btnClearCart.Click += btnClearCart_Click;
            // 
            // MyCartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 875);
            Controls.Add(panelMain);
            Controls.Add(panelTop);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MyCartForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "My Cart - ShopGreen";
            FormClosing += MyCartForm_FormClosing;
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelMain.ResumeLayout(false);
            panelOrderSummary.ResumeLayout(false);
            panelCart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCartItems).EndInit();
            ResumeLayout(false);
        }
    }
}