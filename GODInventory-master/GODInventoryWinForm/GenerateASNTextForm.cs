using GODInventory.ViewModel;
using GODInventory.ViewModel.EDI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GODInventoryWinForm
{
    public partial class GenerateASNTextForm : Form
    {
        public GenerateASNTextForm()
        {
            InitializeComponent();
        }

        private void ExportOrderTextForm_Load(object sender, EventArgs e)
        {
            this.pathTextBox1.Text = NYOTELPath();
            int count = OrderSqlHelper.ShippedOrderCount(entityDataSource1);
            this.orderCountTextBox.Text = count.ToString();
        }


        private void submitButton_Click(object sender, EventArgs e)
        {

        }


        public string NYOTELPath()
        {
            return Properties.Settings.Default.NFWEInstallDir + EDITxtHandler.ASNRelativePath;
        }
    }
}
