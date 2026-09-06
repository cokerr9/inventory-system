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
    public partial class uc_Category : UserControl
    {
        public uc_Category()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;

        }
        // Call Controller to to Insert Category
        Controller.ControllerCategory categoryCtrl = new Controller.ControllerCategory();

        // Functions to Disable and Enable TextBoxes and ComboBoxes
        Functions DE_Functions = new Functions();

        private void uc_Category_Load(object sender, EventArgs e)
        {
            DE_Functions.DisableTxtAndCbox(this);
            btnAdd.Enabled = false;
            btnSave.Enabled = false;
            Get
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if 
        }
    }
}
