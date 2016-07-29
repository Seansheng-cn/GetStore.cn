using GODInventory.MyLinq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GODInventory.ViewModel;

namespace GODInventoryWinForm.Controls
{
    public partial class ShipingInfoConfirmForm : Form
    {
        private List<int> selected_order_ids = null;

        public ShipingInfoConfirmForm()
        {
            InitializeComponent();
            selected_order_ids = new List<int>();
        }

        public List<int> SelectedOrderIds
        {
            get { return selected_order_ids; }
            set { selected_order_ids = value; }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ShipingInfoConfirmForm_Load(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {

            
           OrderSqlHelper.ShippingInfoConfirm(SelectedOrderIds, productShippedAtDateTimePicker1.Value, productReceivedAtDateTimePicker2.Value);
            
           

        }

        private void ShipingInfoConfirmForm_Shown(object sender, EventArgs e)
        {
            this.orderCountTextBox.Text = SelectedOrderIds.Count.ToString();
        }
    }
}
