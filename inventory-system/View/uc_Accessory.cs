using inventory_system.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory_system.View
{
    public partial class uc_Accessory : UserControl
    {
        public uc_Accessory()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        // Call Controller to Insert/Manage Accessory
        Controller.AccessoryController accCtrl = new Controller.AccessoryController();

        // Disable and Enable Functions
        Functions DE_Functions = new Functions();

        private void ResetFormState()
        {
            DE_Functions.ClearTxtAndCbox(this);
            DE_Functions.DisableTxtAndCbox(this);
            textBox1.Enabled = false;
            button3.Text = "Add";
            button3.Enabled = true;
            button1.Text = "Update";
            button1.Enabled = false;
            button2.Enabled = false;
        }

        private void uc_Accessory_Load(object sender, EventArgs e)
        {
            InitializeGridStyle();
            LoadDropdowns();
            ResetFormState();
            GetAccessoryData();
        }

        private void InitializeGridStyle()
        {
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(230, 230, 230);
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.RowTemplate.Height = 30;

            // Sienna header style
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(160, 82, 45);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(160, 82, 45);
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Padding = new Padding(4);
            dataGridView1.ColumnHeadersHeight = 36;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            // Default cell style
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.DefaultCellStyle.ForeColor = SystemColors.ControlText;
            dataGridView1.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular);
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(235, 220, 205);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Alternating rows
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 250);
        }

        private void LoadDropdowns()
        {
            try
            {
                // Category ComboBox (comboBox1)
                DataTable dtCategory = accCtrl.GetCategories();
                comboBox1.DataSource = dtCategory;
                comboBox1.DisplayMember = "CategoryName";
                comboBox1.ValueMember = "CategoryId";
                comboBox1.SelectedIndex = -1;

                // Supplier ComboBox (comboBox3)
                DataTable dtSupplier = accCtrl.GetSuppliers();
                comboBox3.DataSource = dtSupplier;
                comboBox3.DisplayMember = "SupplierName";
                comboBox3.ValueMember = "SupplierId";
                comboBox3.SelectedIndex = -1;

                // Model ComboBox (comboBox2)
                DataTable dtModel = accCtrl.GetModels();
                comboBox2.DataSource = dtModel;
                comboBox2.DisplayMember = "ModelName";
                comboBox2.ValueMember = "ModelId";
                comboBox2.SelectedIndex = -1;

                // Status ComboBox (comboBox4)
                comboBox4.Items.Clear();
                comboBox4.Items.Add("IN");
                comboBox4.Items.Add("OUT");
                comboBox4.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load dropdown options: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // button3: Add / Insert / Clear
        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text.Trim() == "Add")
            {
                DE_Functions.EnableTxtAndCbox(this);
                textBox1.Enabled = false;
                DE_Functions.ClearTxtAndCbox(this);

                comboBox4.SelectedItem = "IN";
                button3.Text = "Insert";
                button3.Enabled = true;
                button1.Enabled = true;
                button1.Text = "Clear";
                button2.Enabled = false;
                textBox2.Focus();
            }
            else if (button3.Text.Trim() == "Insert")
            {
                if (string.IsNullOrWhiteSpace(textBox2.Text) ||
                    string.IsNullOrWhiteSpace(textBox4.Text) ||
                    comboBox1.SelectedIndex == -1 ||
                    comboBox3.SelectedIndex == -1 ||
                    comboBox2.SelectedIndex == -1 ||
                    comboBox4.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Check Accessory Info", "Don't forget!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(textBox4.Text.Trim(), out decimal price) || price < 0)
                {
                    MessageBox.Show("Please enter a valid Price.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox4.Focus();
                    return;
                }

                try
                {
                    accCtrl.AccessoryName = textBox2.Text.Trim();
                    accCtrl.Price = price;
                    accCtrl.CategoryId = Convert.ToInt32(comboBox1.SelectedValue);
                    accCtrl.SupplierId = Convert.ToInt32(comboBox3.SelectedValue);
                    accCtrl.ModelId = Convert.ToInt32(comboBox2.SelectedValue);
                    accCtrl.Status = comboBox4.SelectedItem?.ToString() ?? "IN";
                    accCtrl.Description = textBox5.Text.Trim();
                    accCtrl.UserId = UserDetail.UserId;

                    accCtrl.InsertAccessory();

                    MessageBox.Show("Accessory Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetAccessoryData();
                    ResetFormState();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Insert Failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (button3.Text.Trim() == "Clear")
            {
                ResetFormState();
            }
        }

        // button1: Update / Clear
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text.Trim() == "Clear")
            {
                ResetFormState();
            }
            else if (button1.Text.Trim() == "Update")
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                    string.IsNullOrWhiteSpace(textBox2.Text) ||
                    string.IsNullOrWhiteSpace(textBox4.Text) ||
                    comboBox1.SelectedIndex == -1 ||
                    comboBox3.SelectedIndex == -1 ||
                    comboBox2.SelectedIndex == -1 ||
                    comboBox4.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Check Accessory Info", "Don't forget!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(textBox1.Text.Trim(), out int accId))
                {
                    MessageBox.Show("Please select a valid accessory from the table.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(textBox4.Text.Trim(), out decimal price) || price < 0)
                {
                    MessageBox.Show("Please enter a valid Price.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox4.Focus();
                    return;
                }

                try
                {
                    accCtrl.AccessoryId = accId;
                    accCtrl.AccessoryName = textBox2.Text.Trim();
                    accCtrl.Price = price;
                    accCtrl.CategoryId = Convert.ToInt32(comboBox1.SelectedValue);
                    accCtrl.SupplierId = Convert.ToInt32(comboBox3.SelectedValue);
                    accCtrl.ModelId = Convert.ToInt32(comboBox2.SelectedValue);
                    accCtrl.Status = comboBox4.SelectedItem?.ToString() ?? "IN";
                    accCtrl.Description = textBox5.Text.Trim();
                    accCtrl.UserId = UserDetail.UserId;

                    accCtrl.UpdateAccessory();

                    MessageBox.Show("Accessory Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetAccessoryData();
                    ResetFormState();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update Failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // button2: Delete
        private void button2_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure?", "Delete Accessory", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (int.TryParse(textBox1.Text.Trim(), out int accId))
                {
                    try
                    {
                        accCtrl.AccessoryId = accId;
                        accCtrl.DeleteAccessory();

                        MessageBox.Show("Accessory Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GetAccessoryData();
                        ResetFormState();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Delete Failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a valid accessory to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public void GetAccessoryData()
        {
            accCtrl.GetAccessoryData();
            dataGridView1.DataSource = accCtrl.dt;

            FormatGridColumns();
        }

        private void FormatGridColumns()
        {
            if (dataGridView1.Columns.Count == 0) return;

            // Display headers
            if (dataGridView1.Columns.Contains("AccessoryId"))
            {
                dataGridView1.Columns["AccessoryId"].HeaderText = "ID";
                dataGridView1.Columns["AccessoryId"].FillWeight = 50;
            }
            if (dataGridView1.Columns.Contains("AccessoryName"))
            {
                dataGridView1.Columns["AccessoryName"].HeaderText = "Accessory Name";
                dataGridView1.Columns["AccessoryName"].FillWeight = 150;
            }
            if (dataGridView1.Columns.Contains("CategoryName"))
            {
                dataGridView1.Columns["CategoryName"].HeaderText = "Category";
                dataGridView1.Columns["CategoryName"].FillWeight = 110;
            }
            if (dataGridView1.Columns.Contains("SupplierName"))
            {
                dataGridView1.Columns["SupplierName"].HeaderText = "Supplier";
                dataGridView1.Columns["SupplierName"].FillWeight = 110;
            }
            if (dataGridView1.Columns.Contains("ModelName"))
            {
                dataGridView1.Columns["ModelName"].HeaderText = "Model";
                dataGridView1.Columns["ModelName"].FillWeight = 100;
            }
            if (dataGridView1.Columns.Contains("Price"))
            {
                dataGridView1.Columns["Price"].HeaderText = "Price ($)";
                dataGridView1.Columns["Price"].DefaultCellStyle.Format = "N2";
                dataGridView1.Columns["Price"].FillWeight = 75;
            }
            if (dataGridView1.Columns.Contains("Status"))
            {
                dataGridView1.Columns["Status"].HeaderText = "Status";
                dataGridView1.Columns["Status"].FillWeight = 65;
            }
            if (dataGridView1.Columns.Contains("Description"))
            {
                dataGridView1.Columns["Description"].HeaderText = "Description";
                dataGridView1.Columns["Description"].FillWeight = 130;
            }

            // Hide foreign key ID columns from direct user view in grid
            if (dataGridView1.Columns.Contains("CategoryId"))
                dataGridView1.Columns["CategoryId"].Visible = false;
            if (dataGridView1.Columns.Contains("SupplierId"))
                dataGridView1.Columns["SupplierId"].Visible = false;
            if (dataGridView1.Columns.Contains("ModelId"))
                dataGridView1.Columns["ModelId"].Visible = false;
        }

        public void SelectRow(int rowIndex)
        {
            if (rowIndex >= 0 && rowIndex < dataGridView1.Rows.Count)
            {
                var mouseArgs = new MouseEventArgs(MouseButtons.Left, 1, 0, 0, 0);
                var cellMouseArgs = new DataGridViewCellMouseEventArgs(0, rowIndex, 0, 0, mouseArgs);
                dataGridView1_CellMouseClick(dataGridView1, cellMouseArgs);
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    // ID
                    textBox1.Text = row.Cells["AccessoryId"].Value?.ToString() ?? "";

                    // Name
                    textBox2.Text = row.Cells["AccessoryName"].Value?.ToString() ?? "";

                    // Price
                    if (row.Cells["Price"].Value != null && decimal.TryParse(row.Cells["Price"].Value.ToString(), out decimal price))
                    {
                        textBox4.Text = price.ToString("0.00");
                    }
                    else
                    {
                        textBox4.Text = row.Cells["Price"].Value?.ToString() ?? "";
                    }

                    // Category
                    if (row.Cells["CategoryId"].Value != null && int.TryParse(row.Cells["CategoryId"].Value.ToString(), out int catId) && catId > 0)
                    {
                        comboBox1.SelectedValue = catId;
                    }
                    else
                    {
                        comboBox1.SelectedIndex = -1;
                    }

                    // Supplier
                    if (row.Cells["SupplierId"].Value != null && int.TryParse(row.Cells["SupplierId"].Value.ToString(), out int supId) && supId > 0)
                    {
                        comboBox3.SelectedValue = supId;
                    }
                    else
                    {
                        comboBox3.SelectedIndex = -1;
                    }

                    // Model
                    if (row.Cells["ModelId"].Value != null && int.TryParse(row.Cells["ModelId"].Value.ToString(), out int modId) && modId > 0)
                    {
                        comboBox2.SelectedValue = modId;
                    }
                    else
                    {
                        comboBox2.SelectedIndex = -1;
                    }

                    // Status
                    string statusVal = row.Cells["Status"].Value?.ToString()?.Trim() ?? "";
                    if (statusVal.Equals("OUT", StringComparison.OrdinalIgnoreCase) || statusVal.Equals("InActive", StringComparison.OrdinalIgnoreCase) || statusVal == "0")
                    {
                        comboBox4.SelectedItem = "OUT";
                    }
                    else
                    {
                        comboBox4.SelectedItem = "IN";
                    }

                    // Description
                    textBox5.Text = row.Cells["Description"].Value?.ToString() ?? "";

                    // Enable editing
                    DE_Functions.EnableTxtAndCbox(this);
                    textBox1.Enabled = false;

                    button1.Enabled = true;
                    button1.Text = "Update";
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button3.Text = "Clear";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error selecting row: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
