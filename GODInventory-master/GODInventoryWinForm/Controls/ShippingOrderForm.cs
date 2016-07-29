using GODInventory.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GODInventory.MyLinq;
using GODInventory.ViewModel.EDI;
using System.IO;

namespace GODInventoryWinForm.Controls
{
    public partial class ShippingOrderForm : Form
    {
        public ReceivedOrdersReportForm reportForm;
        public ShippingOrderForm()
        {
            InitializeComponent();
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView3.AutoGenerateColumns = false;

           
            InitializePager();
            InitializeEdiData();
            reportForm = new ReceivedOrdersReportForm();
        }

        #region Pager Methods

        public void InitializePager()
        {
            this.pager1.PageCurrent = 1; //当前页为第一页              
            this.pager1.PageSize = 5000; //页数   
            this.pager1.Bind();
            this.pager3.PageCurrent = 1; //当前页为第一页              
            this.pager3.PageSize = 5000; //页数   
            this.pager3.Bind();
        }

        public void RefreshPager()
        {
            this.pager1.Bind();
            this.pager3.Bind();
        }

        #endregion

        private int InitializeOrderData()
        {

            var q = OrderSqlHelper.ShippingOrderSql(entityDataSource1);
            
            var count = q.Count();
            // create BindingList (sortable/filterable)
            this.bindingSource1.DataSource = entityDataSource1.CreateView(q);
            // assign BindingList to grid
            dataGridView1.DataSource = this.bindingSource1;


            return count;

        }

        private void InitializeEdiData() {

            this.bindingSource2.DataSource = OrderSqlHelper.ASNEdiDataList(entityDataSource1);
            dataGridView2.DataSource = this.bindingSource2;
        
        }

        private int InitializeReceivingOrder()
        {

            var q = OrderSqlHelper.ASNOrderSql(entityDataSource1);
            
            var count = q.Count();
            
            this.bindingSource3.DataSource = entityDataSource1.CreateView(q);
            // assign BindingList to grid
            dataGridView3.DataSource = this.bindingSource3;

            return count;

        }
        

        private void uploadForEDIButton_Click(object sender, EventArgs e)
        {
            var ids = GetEdiDataIdsBySelectedGridCell();
            if (ids.Count > 0) { 
            // 上传相应ASN数据
                using (var ctx = new GODDbContext())
                {

                    var edidata = ctx.t_edidata.Find(ids.First());

                    edidata.is_sent = true;
                    edidata.sent_at = DateTime.Now;
                    ctx.SaveChanges();
                }
            }
            InitializeEdiData();

        }

        private void printForEDIButton_Click(object sender, EventArgs e)
        {
           
            var rows = dataGridView2.SelectedRows;
            if (rows.Count > 0) {

                var edidata = rows[0].DataBoundItem as t_edidata;
                var orders = OrderSqlHelper.ASNOrderDataListByMid(entityDataSource1, edidata.管理連番);
                
                reportForm.OrderEnities = orders;
                reportForm.InitializeDataSource();
                reportForm.ShowDialog();
                InitializeEdiData();
            }
            
        }

        private void generateASNButton_Click(object sender, EventArgs e)
        {

            var orderIds = GetOrderIdsBySelectedGridCell();
            if (orderIds.Count() > 0)
            {

                OrderSqlHelper.GenerateASN(orderIds);
                pager1.Bind();
                InitializeEdiData();
                pager3.Bind();
            }
            else
            {
                MessageBox.Show(" please select rows in the order list first.");
            }

        }

        private IEnumerable<DataGridViewRow> GetSelectedRowsBySelectedCells(DataGridView dgv)
        {
            List<DataGridViewRow> rows = new List<DataGridViewRow>();
            foreach (DataGridViewCell cell in dgv.SelectedCells)
            {
                rows.Add(cell.OwningRow);
            }
            return rows.Distinct();
        }

        private List<int> GetOrderIdsBySelectedGridCell( ) { 
        
            List<int> order_ids = new List<int>();
            var rows = GetSelectedRowsBySelectedCells( dataGridView1 );
            foreach(DataGridViewRow row in rows)
            {
                var pendingorder = row.DataBoundItem as v_pendingorder;
                order_ids.Add(pendingorder.id受注データ);
            }

            return order_ids;  
        }

        private List<int> GetEdiDataIdsBySelectedGridCell()
        {

            List<int> ids = new List<int>();
            var rows = GetSelectedRowsBySelectedCells(dataGridView2);
            foreach (DataGridViewRow row in rows)
            {
                var t_edidata = row.DataBoundItem as t_edidata;
                ids.Add(t_edidata.Id);
            }

            return ids;
        }
      

        private void ShippingOrderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // trigger rdlc.dispose
            reportForm.Close();
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private int pager1_EventPaging(EventPagingArg e)
        {
            int order_count = InitializeOrderData();

            return order_count;
        }

        private int pager3_EventPaging(EventPagingArg e)
        {
            int order_count = InitializeReceivingOrder();

            return order_count;
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            //if (e.TabPage == deliveryTabPage3) {
            //    this.pager3.Bind();
            //}
        }

        private void finishOrderButton1_Click(object sender, EventArgs e)
        {
            
            var ids = GetRecievedOrderIdsBySelectedGridCell();
            if (ids.Count > 0) {

                OrderSqlHelper.FinishOrders(ids);
            }
            pager3.Bind();
        }

        private List<int> GetRecievedOrderIdsBySelectedGridCell()
        {

            List<int> ids = new List<int>();
            var rows = GetSelectedRowsBySelectedCells(dataGridView3);
            foreach (DataGridViewRow row in rows)
            {
                var t_orderdata = row.DataBoundItem as t_orderdata;
                ids.Add(t_orderdata.id受注データ);
            }

            return ids;
        }

    }
}
