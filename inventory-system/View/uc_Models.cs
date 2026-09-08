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
    public partial class uc_Models : UserControl
    {
        public uc_Models()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        // Call Controller to Insert/Manage Model
        Controller.ControllerModels modelCtrl = new Controller.ControllerModels();

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

        private void uc_Models_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            comboBox2.Items.Clear();
            comboBox2.Items.Add("Active");
            comboBox2.Items.Add("InActive");
            ResetFormState();
            GetModelData();
        }

        // button3: Add / Insert / Clear
        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text.Trim() == "Add")
            {
                DE_Functions.EnableTxtAndCbox(this);
                textBox1.Enabled = false;
                textBox1.Clear();
                textBox2.Clear();
                comboBox2.SelectedIndex = -1;

                button3.Text = "Insert";
                button3.Enabled = true;
                button1.Enabled = true;
                button1.Text = "Clear";
                button2.Enabled = false;
                textBox2.Focus();
            }
            else if (button3.Text.Trim() == "Insert")
            {
                if (string.IsNullOrWhiteSpace(textBox2.Text) || comboBox2.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Check model Info", "Don't forget!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    modelCtrl.ModelName = textBox2.Text.Trim();
                    modelCtrl.ModelStatus = (comboBox2.SelectedItem != null && comboBox2.SelectedItem.ToString() == "Active") ? 1 : 0;
                    modelCtrl.InsertModel();

                    MessageBox.Show("Model Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetModelData();
                    ResetFormState();
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
                if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || comboBox2.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Check model Info", "Don't forget!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (!int.TryParse(textBox1.Text.Trim(), out int modelId))
                    {
                        MessageBox.Show("Please select a valid model from the table.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    modelCtrl.ModelId = modelId;
                    modelCtrl.ModelName = textBox2.Text.Trim();
                    modelCtrl.ModelStatus = (comboBox2.SelectedItem != null && comboBox2.SelectedItem.ToString() == "Active") ? 1 : 0;
                    modelCtrl.UpdateModel();

                    MessageBox.Show("Model Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetModelData();
                    ResetFormState();
                }
            }
        }

        // button2: Delete
        private void button2_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure?", "Delete Model", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (int.TryParse(textBox1.Text.Trim(), out int modelId))
                {
                    modelCtrl.ModelId = modelId;
                    modelCtrl.DeleteModel();

                    MessageBox.Show("Model Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetModelData();
                    ResetFormState();
                }
                else
                {
                    MessageBox.Show("Please select a valid model to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public void GetModelData()
        {
            modelCtrl.GetModelData();
            dataGridView1.DataSource = modelCtrl.dt;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    textBox1.Text = row.Cells[0].Value?.ToString() ?? "";
                    textBox2.Text = row.Cells[1].Value?.ToString() ?? "";

                    var statusVal = row.Cells[2].Value;
                    if (statusVal != null)
                    {
                        string statusStr = statusVal.ToString().Trim();
                        if (statusStr == "1" || statusStr.Equals("Active", StringComparison.OrdinalIgnoreCase) || statusStr.Equals("True", StringComparison.OrdinalIgnoreCase))
                        {
                            comboBox2.SelectedItem = "Active";
                        }
                        else
                        {
                            comboBox2.SelectedItem = "InActive";
                        }
                    }

                    DE_Functions.EnableTxtAndCbox(this);
                    textBox1.Enabled = false;

                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button3.Text = "Clear";

                    if (button3.Text == "Clear")
                    {
                        button1.Text = "Update";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.Value == null)
                return;

            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            string propName = dataGridView1.Columns[e.ColumnIndex].DataPropertyName;

            // Format Model Status: 1 -> Active, 0 -> InActive
            if (colName == "Column3" || propName == "ModelStatus" || e.ColumnIndex == 2)
            {
                string raw = e.Value.ToString().Trim();
                if (raw == "1" || raw.Equals("True", StringComparison.OrdinalIgnoreCase) || raw.Equals("Active", StringComparison.OrdinalIgnoreCase))
                {
                    e.Value = "Active";
                    e.FormattingApplied = true;
                }
                else if (raw == "0" || raw.Equals("False", StringComparison.OrdinalIgnoreCase) || raw.Equals("InActive", StringComparison.OrdinalIgnoreCase) || raw.Equals("Disable", StringComparison.OrdinalIgnoreCase))
                {
                    e.Value = "InActive";
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
