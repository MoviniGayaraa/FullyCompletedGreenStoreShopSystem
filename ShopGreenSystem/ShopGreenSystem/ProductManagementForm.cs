using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ShopGreenSystem
{
    public partial class ProductManagementForm : Form
    {
        // Database connection string
        private string connectionString = "Server=localhost;Port=3306;Database=shopGreen;Uid=root;Pwd=1234;";
        private int adminId;
        private string adminName;
        private int selectedProductId = -1;
        private string selectedImagePath = "";

        public ProductManagementForm(int userId, string userName)
        {
            InitializeComponent();
            this.adminId = userId;
            this.adminName = userName;
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadProducts();
        }

        // Load all products into DataGridView
        private void LoadProducts()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT product_id AS 'Product ID', product_name AS 'Product Name', 
                                   category AS 'Category', price AS 'Price', stock AS 'Stock', 
                                   status AS 'Status', supplier AS 'Supplier', 
                                   discount AS 'Discount', image_path AS 'Image Path', 
                                   created_at AS 'Created At' 
                                   FROM products ORDER BY product_id DESC";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvProducts.DataSource = dt;

                        // Style DataGridView
                        dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        dgvProducts.MultiSelect = false;
                        dgvProducts.ReadOnly = true;
                        dgvProducts.AllowUserToAddRows = false;
                        dgvProducts.RowHeadersVisible = false;
                        dgvProducts.BackgroundColor = Color.White;
                        dgvProducts.BorderStyle = BorderStyle.None;
                        dgvProducts.DefaultCellStyle.SelectionBackColor = Color.FromArgb(46, 125, 50);
                        dgvProducts.DefaultCellStyle.SelectionForeColor = Color.White;
                        dgvProducts.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 125, 50);
                        dgvProducts.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                        dgvProducts.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                        dgvProducts.EnableHeadersVisualStyles = false;

                        // Hide image path column
                        if (dgvProducts.Columns["Image Path"] != null)
                        {
                            dgvProducts.Columns["Image Path"].Visible = false;
                        }

                        // Highlight low stock rows (stock < 10)
                        foreach (DataGridViewRow row in dgvProducts.Rows)
                        {
                            if (row.Cells["Stock"].Value != null)
                            {
                                int stock = Convert.ToInt32(row.Cells["Stock"].Value);
                                if (stock < 10)
                                {
                                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 235, 238);
                                    row.DefaultCellStyle.ForeColor = Color.FromArgb(198, 40, 40);
                                }
                            }
                        }

                        lblTotalProducts.Text = $"Total Products: {dt.Rows.Count}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Add Product Button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Validation
                errorProvider1.Clear();
                bool isValid = true;

                if (string.IsNullOrWhiteSpace(txtProductName.Text))
                {
                    errorProvider1.SetError(txtProductName, "Product name is required");
                    isValid = false;
                }

                if (cmbCategory.SelectedIndex == -1)
                {
                    errorProvider1.SetError(cmbCategory, "Category is required");
                    isValid = false;
                }

                if (string.IsNullOrWhiteSpace(txtPrice.Text))
                {
                    errorProvider1.SetError(txtPrice, "Price is required");
                    isValid = false;
                }
                else if (!decimal.TryParse(txtPrice.Text, out decimal price) || price <= 0)
                {
                    errorProvider1.SetError(txtPrice, "Price must be a valid positive number");
                    isValid = false;
                }

                if (string.IsNullOrWhiteSpace(txtStock.Text))
                {
                    errorProvider1.SetError(txtStock, "Stock is required");
                    isValid = false;
                }
                else if (!int.TryParse(txtStock.Text, out int stock) || stock < 0)
                {
                    errorProvider1.SetError(txtStock, "Stock must be a valid non-negative number");
                    isValid = false;
                }

                if (cmbStatus.SelectedIndex == -1)
                {
                    errorProvider1.SetError(cmbStatus, "Status is required");
                    isValid = false;
                }

                if (!isValid)
                {
                    MessageBox.Show("Please fix all errors before adding product!", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Insert product
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"INSERT INTO products (product_name, category, price, stock, status, 
                                   supplier, discount, image_path) 
                                   VALUES (@name, @category, @price, @stock, @status, @supplier, 
                                   @discount, @imagePath)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", txtProductName.Text.Trim());
                        cmd.Parameters.AddWithValue("@category", cmbCategory.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@price", decimal.Parse(txtPrice.Text));
                        cmd.Parameters.AddWithValue("@stock", int.Parse(txtStock.Text));
                        cmd.Parameters.AddWithValue("@status", cmbStatus.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@supplier", txtSupplier.Text.Trim());
                        cmd.Parameters.AddWithValue("@discount", chkDiscount.Checked ? 1 : 0);
                        cmd.Parameters.AddWithValue("@imagePath", selectedImagePath);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Product added successfully! 🌱", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadProducts();
                            ClearFields();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding product: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Update Product Button
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedProductId == -1)
                {
                    MessageBox.Show("Please select a product to update!", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validation
                errorProvider1.Clear();
                bool isValid = true;

                if (string.IsNullOrWhiteSpace(txtProductName.Text))
                {
                    errorProvider1.SetError(txtProductName, "Product name is required");
                    isValid = false;
                }

                if (cmbCategory.SelectedIndex == -1)
                {
                    errorProvider1.SetError(cmbCategory, "Category is required");
                    isValid = false;
                }

                if (string.IsNullOrWhiteSpace(txtPrice.Text))
                {
                    errorProvider1.SetError(txtPrice, "Price is required");
                    isValid = false;
                }
                else if (!decimal.TryParse(txtPrice.Text, out decimal price) || price <= 0)
                {
                    errorProvider1.SetError(txtPrice, "Price must be a valid positive number");
                    isValid = false;
                }

                if (string.IsNullOrWhiteSpace(txtStock.Text))
                {
                    errorProvider1.SetError(txtStock, "Stock is required");
                    isValid = false;
                }
                else if (!int.TryParse(txtStock.Text, out int stock) || stock < 0)
                {
                    errorProvider1.SetError(txtStock, "Stock must be a valid non-negative number");
                    isValid = false;
                }

                if (cmbStatus.SelectedIndex == -1)
                {
                    errorProvider1.SetError(cmbStatus, "Status is required");
                    isValid = false;
                }

                if (!isValid)
                {
                    MessageBox.Show("Please fix all errors before updating product!", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Update product
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"UPDATE products SET product_name = @name, category = @category, 
                                   price = @price, stock = @stock, status = @status, supplier = @supplier, 
                                   discount = @discount, image_path = @imagePath 
                                   WHERE product_id = @productId";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", txtProductName.Text.Trim());
                        cmd.Parameters.AddWithValue("@category", cmbCategory.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@price", decimal.Parse(txtPrice.Text));
                        cmd.Parameters.AddWithValue("@stock", int.Parse(txtStock.Text));
                        cmd.Parameters.AddWithValue("@status", cmbStatus.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@supplier", txtSupplier.Text.Trim());
                        cmd.Parameters.AddWithValue("@discount", chkDiscount.Checked ? 1 : 0);
                        cmd.Parameters.AddWithValue("@imagePath", selectedImagePath);
                        cmd.Parameters.AddWithValue("@productId", selectedProductId);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Product updated successfully! 🌱", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadProducts();
                            ClearFields();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating product: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Delete Product Button
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedProductId == -1)
                {
                    MessageBox.Show("Please select a product to delete!", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure you want to delete this product?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM products WHERE product_id = @productId";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@productId", selectedProductId);

                            int deleteResult = cmd.ExecuteNonQuery();

                            if (deleteResult > 0)
                            {
                                MessageBox.Show("Product deleted successfully! 🌱", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadProducts();
                                ClearFields();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting product: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Clear Button
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        // Clear all input fields
        private void ClearFields()
        {
            txtProductName.Clear();
            cmbCategory.SelectedIndex = -1;
            txtPrice.Clear();
            txtStock.Clear();
            cmbStatus.SelectedIndex = -1;
            txtSupplier.Clear();
            chkDiscount.Checked = false;
            pictureBoxProduct.Image = null;
            selectedProductId = -1;
            selectedImagePath = "";
            errorProvider1.Clear();
            txtProductName.Focus();
        }

        // Upload Image Button
        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                    openFileDialog.Title = "Select Product Image";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        selectedImagePath = openFileDialog.FileName;
                        pictureBoxProduct.Image = Image.FromFile(selectedImagePath);
                        pictureBoxProduct.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // DataGridView cell click - populate fields
        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvProducts.Rows[e.RowIndex];

                    selectedProductId = Convert.ToInt32(row.Cells["Product ID"].Value);
                    txtProductName.Text = row.Cells["Product Name"].Value.ToString();
                    cmbCategory.SelectedItem = row.Cells["Category"].Value.ToString();
                    txtPrice.Text = row.Cells["Price"].Value.ToString();
                    txtStock.Text = row.Cells["Stock"].Value.ToString();
                    cmbStatus.SelectedItem = row.Cells["Status"].Value.ToString();
                    txtSupplier.Text = row.Cells["Supplier"].Value?.ToString() ?? "";
                    chkDiscount.Checked = Convert.ToBoolean(row.Cells["Discount"].Value);

                    // Load image if exists
                    selectedImagePath = row.Cells["Image Path"].Value?.ToString() ?? "";
                    if (!string.IsNullOrEmpty(selectedImagePath) && File.Exists(selectedImagePath))
                    {
                        pictureBoxProduct.Image = Image.FromFile(selectedImagePath);
                        pictureBoxProduct.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    else
                    {
                        pictureBoxProduct.Image = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error selecting product: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Search functionality
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    LoadProducts();
                    return;
                }

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT product_id AS 'Product ID', product_name AS 'Product Name', 
                                   category AS 'Category', price AS 'Price', stock AS 'Stock', 
                                   status AS 'Status', supplier AS 'Supplier', 
                                   discount AS 'Discount', image_path AS 'Image Path', 
                                   created_at AS 'Created At' 
                                   FROM products 
                                   WHERE product_name LIKE @search OR supplier LIKE @search 
                                   ORDER BY product_id DESC";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@search", "%" + txtSearch.Text + "%");
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvProducts.DataSource = dt;

                        // Hide image path column
                        if (dgvProducts.Columns["Image Path"] != null)
                        {
                            dgvProducts.Columns["Image Path"].Visible = false;
                        }

                        lblTotalProducts.Text = $"Total Products: {dt.Rows.Count}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Navigation Menu Buttons
        private void btnHome_Click(object sender, EventArgs e)
        {
            AdminDashboardForm adminDashboard = new AdminDashboardForm(adminId, adminName);
            adminDashboard.Show();
            this.Hide();
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            ManageUsersForm manageUsersForm = new ManageUsersForm(adminId, adminName);
            manageUsersForm.Show();
            this.Hide();
        }

        private void btnManageProducts_Click(object sender, EventArgs e)
        {
            // Already on this form
            LoadProducts();
        }

        private void btnManageCustomers_Click(object sender, EventArgs e)
        {
            CustomerManagementForm customerForm = new CustomerManagementForm(adminId, adminName);
            customerForm.Show();
            this.Hide();
        }

        private void btnManageOrders_Click(object sender, EventArgs e)
        {
            OrderManagementForm orderForm = new OrderManagementForm(adminId, adminName);
            orderForm.Show();
            this.Hide();
        }

        private void btnGenerateReports_Click(object sender, EventArgs e)
        {
            ReportsForm reportsForm = new ReportsForm(adminId, adminName);
            reportsForm.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
        }

        // Hover effects
        private void MenuButton_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.FromArgb(37, 99, 41);
        }

        private void MenuButton_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.FromArgb(46, 125, 50);
        }

        private void ProductManagementForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        // Only allow numbers and decimal point in price field
        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        // Only allow numbers in stock field
        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}