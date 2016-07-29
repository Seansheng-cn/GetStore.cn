using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GODInventoryWinForm.Controls
{
    using GODInventory.MyLinq;
    using GODInventory.ViewModel;
    public partial class OrderCheckForm : Form
    {
        public OrderCheckForm()
        {
            InitializeComponent();           
        }

        private void InitializeOrderData() {


            var q = OrderSqlHelper.PendingOrderSql( entityDataSource1);
            // create BindingList (sortable/filterable)
            var bindingList = entityDataSource1.CreateView(q);
            // assign BindingList to grid
            dataGridView1.DataSource = bindingList;

        }

        private void redundantButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                t_orderdata myData = row.DataBoundItem as t_orderdata;
                myData.キャンセル = "yes";
                myData.キャンセル時刻 = DateTime.Now;
                Console.WriteLine("order id = {0}, cancled = {1}", myData.id, myData.キャンセル);
            }

        }

        private void submitButton_Click(object sender, EventArgs e)
        {

            entityDataSource1.SaveChanges();
            List<object> canceled_data = new List<object>();
            foreach (t_orderdata data in bindingSource1.List)
            {
                if (data.キャンセル == "yes")
                {
                    canceled_data.Add(data);
                }
            }
            foreach (var data in canceled_data)
            {
                bindingSource1.Remove(data);
            }

        }

        private void OrderCheckForm_Load(object sender, EventArgs e)
        {
            InitializeOrderData();
        }
    }
}
