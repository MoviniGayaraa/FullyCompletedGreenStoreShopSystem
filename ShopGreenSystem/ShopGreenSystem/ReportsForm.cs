using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Drawing.Printing;
using System.Diagnostics;

namespace ShopGreenSystem
{
    public partial class ReportsForm : Form
    {
        // Database connection string
        private string connectionString = "Server=localhost;Port=3306;Database=shopGreen;Uid=root;Pwd=1234;";
        private int adminId;
        private string adminName;
        private DataTable currentReportData;
        private PrintDocument printDocument;
        private Font printFont;
        private string currentReportTitle = "";
        private string currentReportSummary = "";
        private int currentRow = 0;
        private int rowsPerPage = 30;
        private StringFormat stringFormat = new StringFormat();

        public ReportsForm(int userId, string userName)
        {
            InitializeComponent();
            this.adminId = userId;
            this.adminName = userName;
            this.StartPosition = FormStartPosition.CenterScreen;

            // Initialize print document
            printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;
            printFont = new Font("Arial", 10);

            // Configure string format for printing
            stringFormat.Alignment = StringAlignment.Near;
            stringFormat.LineAlignment = StringAlignment.Center;
            stringFormat.Trimming = StringTrimming.EllipsisCharacter;
        }

        // Sales Report Button
        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT 
                                   o.order_id AS 'Order ID',
                                   u.name AS 'Customer Name',
                                   o.order_date AS 'Order Date',
                                   o.total_amount AS 'Amount',
                                   o.status AS 'Status'
                                   FROM orders o
                                   INNER JOIN users u ON o.user_id = u.user_id
                                   WHERE o.status = 'DELIVERED'
                                   ORDER BY o.order_date DESC";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        currentReportData = dt;
                        dgvReport.DataSource = dt;

                        // Style DataGridView
                        StyleDataGridView();

                        // Calculate total sales
                        decimal totalSales = 0;
                        foreach (DataRow row in dt.Rows)
                        {
                            totalSales += Convert.ToDecimal(row["Amount"]);
                        }

                        currentReportTitle = "Sales Report (Delivered Orders)";
                        currentReportSummary = $"Total Sales: Rs. {totalSales:N2} | Total Orders: {dt.Rows.Count}";

                        lblReportTitle.Text = "📊 " + currentReportTitle;
                        lblReportSummary.Text = currentReportSummary;

                        MessageBox.Show($"Sales Report Generated!\n\nTotal Sales: Rs. {totalSales:N2}\nTotal Orders: {dt.Rows.Count}",
                            "Report Generated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating sales report: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Stock Report Button
        private void btnStockReport_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT 
                                   product_id AS 'Product ID',
                                   product_name AS 'Product Name',
                                   category AS 'Category',
                                   price AS 'Price',
                                   stock AS 'Stock',
                                   status AS 'Status',
                                   supplier AS 'Supplier'
                                   FROM products
                                   ORDER BY stock ASC";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        currentReportData = dt;
                        dgvReport.DataSource = dt;

                        // Style DataGridView
                        StyleDataGridView();

                        // Highlight low stock items
                        foreach (DataGridViewRow row in dgvReport.Rows)
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

                        // Calculate statistics
                        int totalProducts = dt.Rows.Count;
                        int lowStockCount = 0;
                        int outOfStockCount = 0;

                        foreach (DataRow row in dt.Rows)
                        {
                            int stock = Convert.ToInt32(row["Stock"]);
                            if (stock == 0) outOfStockCount++;
                            else if (stock < 10) lowStockCount++;
                        }

                        currentReportTitle = "Stock Report";
                        currentReportSummary = $"Total Products: {totalProducts} | Low Stock: {lowStockCount} | Out of Stock: {outOfStockCount}";

                        lblReportTitle.Text = "📦 " + currentReportTitle;
                        lblReportSummary.Text = currentReportSummary;

                        MessageBox.Show($"Stock Report Generated!\n\nTotal Products: {totalProducts}\nLow Stock (<10): {lowStockCount}\nOut of Stock: {outOfStockCount}",
                            "Report Generated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating stock report: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Customer Order History Button
        private void btnCustomerOrderHistory_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT 
                                   u.user_id AS 'Customer ID',
                                   u.name AS 'Customer Name',
                                   u.email AS 'Email',
                                   COUNT(o.order_id) AS 'Total Orders',
                                   COALESCE(SUM(o.total_amount), 0) AS 'Total Spent',
                                   MAX(o.order_date) AS 'Last Order Date'
                                   FROM users u
                                   LEFT JOIN orders o ON u.user_id = o.user_id
                                   WHERE u.role = 'CUSTOMER'
                                   GROUP BY u.user_id, u.name, u.email
                                   ORDER BY COUNT(o.order_id) DESC";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        currentReportData = dt;
                        dgvReport.DataSource = dt;

                        // Style DataGridView
                        StyleDataGridView();

                        // Calculate statistics
                        int totalCustomers = dt.Rows.Count;
                        int activeCustomers = 0;
                        decimal totalRevenue = 0;

                        foreach (DataRow row in dt.Rows)
                        {
                            int orderCount = Convert.ToInt32(row["Total Orders"]);
                            if (orderCount > 0) activeCustomers++;
                            totalRevenue += Convert.ToDecimal(row["Total Spent"]);
                        }

                        currentReportTitle = "Customer Order History";
                        currentReportSummary = $"Total Customers: {totalCustomers} | Active: {activeCustomers} | Total Revenue: Rs. {totalRevenue:N2}";

                        lblReportTitle.Text = "👥 " + currentReportTitle;
                        lblReportSummary.Text = currentReportSummary;

                        MessageBox.Show($"Customer Order History Generated!\n\nTotal Customers: {totalCustomers}\nActive Customers: {activeCustomers}\nTotal Revenue: Rs. {totalRevenue:N2}",
                            "Report Generated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating customer order history: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Low Stock Alert Report Button
        private void btnLowStockAlert_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT 
                                   product_id AS 'Product ID',
                                   product_name AS 'Product Name',
                                   category AS 'Category',
                                   stock AS 'Current Stock',
                                   supplier AS 'Supplier',
                                   status AS 'Status'
                                   FROM products
                                   WHERE stock < 10
                                   ORDER BY stock ASC";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        currentReportData = dt;
                        dgvReport.DataSource = dt;

                        // Style DataGridView
                        StyleDataGridView();

                        // Highlight all rows in red
                        foreach (DataGridViewRow row in dgvReport.Rows)
                        {
                            row.DefaultCellStyle.BackColor = Color.FromArgb(255, 235, 238);
                            row.DefaultCellStyle.ForeColor = Color.FromArgb(198, 40, 40);
                        }

                        currentReportTitle = "Low Stock Alert Report";
                        currentReportSummary = $"Products with Low Stock: {dt.Rows.Count}";

                        lblReportTitle.Text = "⚠️ " + currentReportTitle;
                        lblReportSummary.Text = currentReportSummary;

                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show($"Low Stock Alert!\n\n{dt.Rows.Count} products need restocking.",
                                "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("All products have sufficient stock!", "No Alerts",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating low stock report: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Monthly Sales Report Button
        private void btnMonthlySales_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT 
                                   DATE_FORMAT(order_date, '%Y-%m') AS 'Month',
                                   COUNT(order_id) AS 'Total Orders',
                                   SUM(total_amount) AS 'Total Sales',
                                   AVG(total_amount) AS 'Average Order Value'
                                   FROM orders
                                   WHERE status = 'DELIVERED'
                                   GROUP BY DATE_FORMAT(order_date, '%Y-%m')
                                   ORDER BY Month DESC";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        currentReportData = dt;
                        dgvReport.DataSource = dt;

                        // Style DataGridView
                        StyleDataGridView();

                        currentReportTitle = "Monthly Sales Report";
                        currentReportSummary = $"Showing sales data for {dt.Rows.Count} months";

                        lblReportTitle.Text = "📈 " + currentReportTitle;
                        lblReportSummary.Text = currentReportSummary;

                        MessageBox.Show($"Monthly Sales Report Generated!\n\nShowing data for {dt.Rows.Count} months",
                            "Report Generated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating monthly sales report: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Style DataGridView
        private void StyleDataGridView()
        {
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReport.MultiSelect = false;
            dgvReport.ReadOnly = true;
            dgvReport.AllowUserToAddRows = false;
            dgvReport.RowHeadersVisible = false;
            dgvReport.BackgroundColor = Color.White;
            dgvReport.BorderStyle = BorderStyle.None;
            dgvReport.DefaultCellStyle.SelectionBackColor = Color.FromArgb(46, 125, 50);
            dgvReport.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvReport.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 125, 50);
            dgvReport.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvReport.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvReport.EnableHeadersVisualStyles = false;
        }

        // Export to CSV Button
        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentReportData == null || currentReportData.Rows.Count == 0)
                {
                    MessageBox.Show("Please generate a report first!", "No Data",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SaveFileDialog saveDialog = new SaveFileDialog())
                {
                    saveDialog.Filter = "CSV Files|*.csv";
                    saveDialog.Title = "Export Report to CSV";
                    saveDialog.FileName = $"ShopGreen_Report_{DateTime.Now:yyyyMMdd_HHmmss}.csv";
                    saveDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        StringBuilder csv = new StringBuilder();

                        // Add report title
                        csv.AppendLine($"Report: {currentReportTitle}");
                        csv.AppendLine($"Generated: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
                        csv.AppendLine();

                        // Add column headers
                        for (int i = 0; i < currentReportData.Columns.Count; i++)
                        {
                            csv.Append(currentReportData.Columns[i].ColumnName);
                            if (i < currentReportData.Columns.Count - 1)
                                csv.Append(",");
                        }
                        csv.AppendLine();

                        // Add rows
                        foreach (DataRow row in currentReportData.Rows)
                        {
                            for (int i = 0; i < currentReportData.Columns.Count; i++)
                            {
                                string value = row[i].ToString();
                                // Handle commas in data
                                if (value.Contains(","))
                                    value = $"\"{value}\"";
                                csv.Append(value);
                                if (i < currentReportData.Columns.Count - 1)
                                    csv.Append(",");
                            }
                            csv.AppendLine();
                        }

                        File.WriteAllText(saveDialog.FileName, csv.ToString());

                        MessageBox.Show($"Report exported successfully!\n\nSaved to: {saveDialog.FileName}",
                            "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Optionally open the file
                        DialogResult openResult = MessageBox.Show("Would you like to open the exported file?", "Open File",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (openResult == DialogResult.Yes)
                        {
                            Process.Start(new ProcessStartInfo(saveDialog.FileName) { UseShellExecute = true });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting to CSV: {ex.Message}", "Export Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Print Report Button - Updated to save as PDF or print
        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentReportData == null || currentReportData.Rows.Count == 0)
                {
                    MessageBox.Show("Please generate a report first!", "No Data",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Show print options dialog
                using (PrintOptionsDialog printDialog = new PrintOptionsDialog())
                {
                    if (printDialog.ShowDialog() == DialogResult.OK)
                    {
                        if (printDialog.PrintToFile)
                        {
                            // Save as PDF or text file
                            SaveReportToFile();
                        }
                        else
                        {
                            // Print directly to printer
                            PrintDirectly();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error printing report: {ex.Message}", "Print Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Save report to file (PDF or text)
        private void SaveReportToFile()
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Text Files|*.txt|PDF Files|*.pdf|All Files|*.*";
                saveDialog.Title = "Save Report";
                saveDialog.FileName = $"ShopGreen_Report_{currentReportTitle.Replace(" ", "_")}_{DateTime.Now:yyyyMMdd_HHmmss}";
                saveDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveDialog.FileName;
                    string extension = Path.GetExtension(filePath).ToLower();

                    if (extension == ".txt")
                    {
                        SaveAsTextFile(filePath);
                    }
                    else if (extension == ".pdf")
                    {
                        SaveAsPDF(filePath);
                    }
                    else
                    {
                        // Default to text file
                        SaveAsTextFile(filePath);
                    }
                }
            }
        }

        // Save report as text file
        private void SaveAsTextFile(string filePath)
        {
            StringBuilder sb = new StringBuilder();

            // Add header
            sb.AppendLine("=".PadRight(80, '='));
            sb.AppendLine("SHOPGREEN REPORT".PadLeft(40 + "SHOPGREEN REPORT".Length / 2));
            sb.AppendLine("=".PadRight(80, '='));
            sb.AppendLine();

            // Add report info
            sb.AppendLine($"Report: {currentReportTitle}");
            sb.AppendLine($"Date: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
            sb.AppendLine($"Summary: {currentReportSummary}");
            sb.AppendLine();
            sb.AppendLine("-".PadRight(80, '-'));

            // Calculate column widths
            int[] columnWidths = new int[currentReportData.Columns.Count];
            for (int i = 0; i < currentReportData.Columns.Count; i++)
            {
                columnWidths[i] = currentReportData.Columns[i].ColumnName.Length;
                foreach (DataRow row in currentReportData.Rows)
                {
                    string cellValue = row[i].ToString();
                    if (cellValue.Length > columnWidths[i])
                        columnWidths[i] = cellValue.Length;
                }
                // Limit max width
                if (columnWidths[i] > 30) columnWidths[i] = 30;
            }

            // Add column headers
            for (int i = 0; i < currentReportData.Columns.Count; i++)
            {
                sb.Append(currentReportData.Columns[i].ColumnName.PadRight(columnWidths[i] + 2));
            }
            sb.AppendLine();
            sb.AppendLine("-".PadRight(80, '-'));

            // Add data rows
            foreach (DataRow row in currentReportData.Rows)
            {
                for (int i = 0; i < currentReportData.Columns.Count; i++)
                {
                    string cellValue = row[i].ToString();
                    if (cellValue.Length > 30) cellValue = cellValue.Substring(0, 27) + "...";
                    sb.Append(cellValue.PadRight(columnWidths[i] + 2));
                }
                sb.AppendLine();
            }

            // Add footer
            sb.AppendLine();
            sb.AppendLine("-".PadRight(80, '-'));
            sb.AppendLine($"Total Records: {currentReportData.Rows.Count}");
            sb.AppendLine("=".PadRight(80, '='));

            File.WriteAllText(filePath, sb.ToString());

            MessageBox.Show($"Report saved successfully!\n\nSaved to: {filePath}",
                "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Open the file
            Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
        }

        // Save as PDF (simple implementation - saves as text with PDF extension)
        private void SaveAsPDF(string filePath)
        {
            // Note: For proper PDF generation, you would need a PDF library like iTextSharp
            // This is a simple workaround that creates a text file with PDF extension

            SaveAsTextFile(Path.ChangeExtension(filePath, ".txt"));
            MessageBox.Show("For proper PDF generation, please install a PDF library.\n\nA text file has been saved instead.",
                "PDF Generation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Print directly to printer
        private void PrintDirectly()
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                currentRow = 0;
                printDocument.Print();
            }
        }

        // PrintDocument PrintPage event
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font headerFont = new Font("Arial", 16, FontStyle.Bold);
            Font subHeaderFont = new Font("Arial", 12);
            Font columnFont = new Font("Arial", 10, FontStyle.Bold);
            Font dataFont = new Font("Arial", 9);

            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;
            float yPos = topMargin;

            // Print header
            graphics.DrawString("SHOPGREEN REPORT", headerFont, Brushes.Black, leftMargin, yPos);
            yPos += headerFont.GetHeight() + 20;

            // Print report title
            graphics.DrawString(currentReportTitle, subHeaderFont, Brushes.Black, leftMargin, yPos);
            yPos += subHeaderFont.GetHeight() + 10;

            // Print date and summary
            graphics.DrawString($"Date: {DateTime.Now:yyyy-MM-dd HH:mm:ss}", dataFont, Brushes.Black, leftMargin, yPos);
            yPos += dataFont.GetHeight() + 5;
            graphics.DrawString($"Summary: {currentReportSummary}", dataFont, Brushes.Black, leftMargin, yPos);
            yPos += dataFont.GetHeight() + 20;

            if (currentReportData != null && currentReportData.Rows.Count > 0)
            {
                // Calculate column widths
                float[] columnWidths = new float[currentReportData.Columns.Count];
                float totalWidth = e.MarginBounds.Width;
                float columnSpacing = 5;

                for (int i = 0; i < currentReportData.Columns.Count; i++)
                {
                    columnWidths[i] = totalWidth / currentReportData.Columns.Count;
                }

                // Print column headers
                float xPos = leftMargin;
                for (int i = 0; i < currentReportData.Columns.Count; i++)
                {
                    graphics.DrawString(currentReportData.Columns[i].ColumnName,
                        columnFont, Brushes.Black, xPos, yPos);
                    xPos += columnWidths[i];
                }
                yPos += columnFont.GetHeight() + 10;

                // Draw line under headers
                graphics.DrawLine(Pens.Black, leftMargin, yPos - 5,
                    leftMargin + totalWidth, yPos - 5);

                // Print data rows
                int rowsPrinted = 0;
                while (currentRow < currentReportData.Rows.Count && rowsPrinted < rowsPerPage)
                {
                    xPos = leftMargin;
                    DataRow row = currentReportData.Rows[currentRow];

                    for (int i = 0; i < currentReportData.Columns.Count; i++)
                    {
                        string cellValue = row[i].ToString();
                        if (cellValue.Length > 30)
                            cellValue = cellValue.Substring(0, 27) + "...";

                        RectangleF cellRect = new RectangleF(xPos, yPos, columnWidths[i], dataFont.GetHeight());
                        graphics.DrawString(cellValue, dataFont, Brushes.Black, cellRect, stringFormat);
                        xPos += columnWidths[i];
                    }

                    yPos += dataFont.GetHeight() + 5;
                    currentRow++;
                    rowsPrinted++;

                    // Check if we need a new page
                    if (yPos > e.MarginBounds.Bottom - dataFont.GetHeight())
                    {
                        e.HasMorePages = true;
                        return;
                    }
                }

                // Print total count
                yPos += 20;
                graphics.DrawString($"Total Records: {currentReportData.Rows.Count}",
                    columnFont, Brushes.Black, leftMargin, yPos);
            }

            e.HasMorePages = false;
            currentRow = 0;
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
            ProductManagementForm productForm = new ProductManagementForm(adminId, adminName);
            productForm.Show();
            this.Hide();
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
            // Already on this form
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
            if (btn != null)
            {
                btn.BackColor = Color.FromArgb(37, 99, 41);
            }
        }

        private void MenuButton_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                btn.BackColor = Color.FromArgb(46, 125, 50);
            }
        }

        private void ReportsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {
            // Empty method
        }
    }

    // Simple Print Options Dialog
    public class PrintOptionsDialog : Form
    {
        private RadioButton rbPrintDirect;
        private RadioButton rbSaveToFile;
        private Button btnOK;
        private Button btnCancel;

        public bool PrintToFile => rbSaveToFile.Checked;

        public PrintOptionsDialog()
        {
            InitializeComponent();
            this.Text = "Print Options";
            this.Size = new Size(300, 200);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void InitializeComponent()
        {
            rbPrintDirect = new RadioButton
            {
                Text = "🖨️ Print directly to printer",
                Location = new Point(20, 20),
                Size = new Size(250, 30),
                Checked = true
            };

            rbSaveToFile = new RadioButton
            {
                Text = "💾 Save to file (PDF/Text)",
                Location = new Point(20, 60),
                Size = new Size(250, 30)
            };

            btnOK = new Button
            {
                Text = "OK",
                Location = new Point(50, 120),
                Size = new Size(80, 30),
                DialogResult = DialogResult.OK
            };

            btnCancel = new Button
            {
                Text = "Cancel",
                Location = new Point(150, 120),
                Size = new Size(80, 30),
                DialogResult = DialogResult.Cancel
            };

            this.Controls.Add(rbPrintDirect);
            this.Controls.Add(rbSaveToFile);
            this.Controls.Add(btnOK);
            this.Controls.Add(btnCancel);
        }
    }
}