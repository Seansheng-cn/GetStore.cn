using GODInventory.MyLinq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GODInventoryWinForm.Controls
{
    public partial class NewOrdersForm : Form
    {

        private IBindingListView shops = null;
        private IBindingListView products = null;
        private DbSet< t_orderdata> orders;
        public NewOrdersForm()
        {
            InitializeComponent();
            //shops = entityDataSource1.EntitySets["t_shoplist"].List;
            //products = entityDataSource1.EntitySets["t_dataitem"].List;
        }

        private void NewOrdersForm_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //受注日, 伝票番号, 発注日, 店舗コード, 店舗名漢字, JANコード, 商品コード, 品名漢字, 規格名漢字,  発注数量
            //原単価(税抜),原価金額(税抜), 売単価(税抜),納品先店舗コード, 納品先店舗名漢字, 納品場所名漢字

            t_orderdata order = new t_orderdata();
            order.受注日 = DateTime.Now;
            order.発注日 = orderCreatedAtDateTimePicker.Value;
            order.伝票番号 = Convert.ToInt32( invoiceNOTextBox.Text );
            order.店舗コード = Convert.ToInt16( storeCodeTextBox.Text );
            order.商品コード = Convert.ToInt32( productCodeTextBox.Text );
            order.発注数量 = Convert.ToInt32( orderQuantityUpDown.Value );

            //int row_index = shops.Find(order.店舗コード);
            //if ( row)
            //order.店舗名漢字 =

        }
    }
}
