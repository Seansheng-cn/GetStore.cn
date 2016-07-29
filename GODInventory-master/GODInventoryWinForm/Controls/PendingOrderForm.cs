using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;

namespace GODInventoryWinForm.Controls
{
    using GODInventory.MyLinq;
    using GODInventory.ViewModel;
    using MySql.Data.MySqlClient;

    public partial class PendingOrderForm : Form
    {
        public Size ParentContainerSize { get; set; }
        
        //  [c1_r1_changed=> new_value,c1_r1=> original_value] ]
        private Hashtable datagrid_changes = null;
        private List<t_stockstate> stockstates;

        public PendingOrderForm()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;

            var ctx = entityDataSource1.DbContext as GODDbContext;
            this.stockstates = ctx.t_stockstate.Select(s => s).ToList();
            InitializePager();
            
        }

        #region Pager Methods

        public void InitializePager(){
            this.pager1.PageCurrent = 1; //当前页为第一页   
            this.pager1.PageSize = 5000; //页数   
            this.pager1.Bind();
        }
        public void RefreshPager()
        {
            this.pager1.Bind();
        }

        #endregion

        private void redundantButton_Click(object sender, EventArgs e)
        {


        }

        private void submitButton_Click(object sender, EventArgs e)
        {
/*
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
            */
        }

        private void OrderCheckForm_Load(object sender, EventArgs e)
        {
           

            //this.Location = new Point(50, 25);

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //if(dateTimePicker1.Text == String.Empty)
            {
            //    this.dateTimePicker1.CustomFormat =  " ";
            //    this.dateTimePicker1.Format = DateTimePickerFormat.Custom;
            }
            //else
            {
                this.dateTimePicker1.Format = DateTimePickerFormat.Short;
            }

       
        }

        private void submitFormButton_Click(object sender, EventArgs e)
        {
            //string oid = orderIDTextBox.Text;
            int oid = GetSelectedOrderID();
            if ( oid > 0 )
            {
                using (var ctx = new GODDbContext())
                {
                    t_orderdata order = ctx.t_orderdata.Find(oid);
                    order.品名漢字 = productKanjiNameTextBox.Text;
                    ctx.SaveChanges();
                }
                InitializeOrderData();
            }

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0) {
                this.tabControl1.SelectTab(formTabPage);                
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            using (var ctx = new GODDbContext())
            {
                IEnumerable<int> rows = GetChangedRowIndexes();

                if (rows.Count() > 0)
                {
                    foreach (var row in rows.Distinct())
                    {
                        var pendingorder = bindingSource1.List[row] as v_pendingorder;
                        t_orderdata order = ctx.t_orderdata.Find(pendingorder.id受注データ);
                        order.発注数量 = pendingorder.発注数量;
                        order.口数 = pendingorder.口数;
                        order.重量 = pendingorder.重量;
                        order.原価金額_税抜_ = pendingorder.原価金額_税抜_;
                        order.発注形態名称漢字 = pendingorder.発注形態名称漢字;
                        order.実際配送担当 = pendingorder.実際配送担当;
                        order.備考 = "発注形態配送担当数量変更";
                    }

                    ctx.SaveChanges();
                    InitializeOrderData();
                }
            }

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            IEnumerable<int> rows = GetChangedRowIndexes();
            if( rows.Count()> 0)
            {
                pager1.Bind();
            }

        }


        private void dataGridView1_Layout(object sender, LayoutEventArgs e)
        {
            //Console.WriteLine(" yes, Layout is called...");
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //Console.WriteLine(" yes, DataBindingComplete is called...");
        }


        private int GetDatagridRowCount() {
            return dataGridView1.RowCount;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex < dataGridView1.Rows.Count - 1)
            {
                DataGridViewRow dgrSingle = dataGridView1.Rows[e.RowIndex];
                try
                {
                    if(datagrid_changes.ContainsKey(e.RowIndex))//if (dgrSingle.Cells["列名"].Value.ToString().Contains("比较值"))
                    {
                        dgrSingle.DefaultCellStyle.ForeColor = Color.Red;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            DataGridViewRow dgrSingle = dataGridView1.Rows[e.RowIndex];
            string cell_key = e.RowIndex.ToString() + "_" + e.ColumnIndex.ToString();

            if (!datagrid_changes.ContainsKey(cell_key))
            {
                datagrid_changes[cell_key] = dgrSingle.Cells[e.ColumnIndex].Value;
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            string cell_key = e.RowIndex.ToString() + "_" + e.ColumnIndex.ToString();
            var new_cell_value = row.Cells[e.ColumnIndex].Value;
            var original_cell_value = datagrid_changes[cell_key];
            // original_cell_value could null
            //Console.WriteLine(" original = {0} {3}, new ={1} {4}, compare = {2}, {5}", original_cell_value, new_cell_value, original_cell_value == new_cell_value, original_cell_value.GetType(), new_cell_value.GetType(), new_cell_value.Equals(original_cell_value));
            if (new_cell_value == null && original_cell_value == null) {
                datagrid_changes.Remove(cell_key + "_changed");
            } else if ( (new_cell_value ==null && original_cell_value!=null) || (new_cell_value != null && original_cell_value == null) || !new_cell_value.Equals(original_cell_value) ) 
            {
                datagrid_changes[cell_key + "_changed"] = new_cell_value;
            }
            else {
                datagrid_changes.Remove(cell_key + "_changed");
            }

        }

        private void dataGridView1_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {

        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //出荷日,納品日,受注日,店舗コード,店名,伝票番号,口数,品名漢字,規格名漢字,発注数量,実際配送担当,県別,キャンセル,ダブリ,一旦保留
            string cell_key = e.RowIndex.ToString() + "_" + e.ColumnIndex.ToString() + "_changed";

            if (datagrid_changes.ContainsKey(cell_key))
            {              
                    e.CellStyle.BackColor = Color.Red;
                    e.CellStyle.SelectionBackColor = Color.DarkRed;               
            }

        }

        private void ordersTabPage_Click(object sender, EventArgs e)
        {

        }

        #region InitializeOrderData

        private int InitializeOrderData()
        {
            // 记录DataGridView改变数据
            this.datagrid_changes = new Hashtable();

            //var ctx = entityDataSource1.DbContext as GODDbContext;
            //var stockstates = ctx.t_stockstate.Select(s => s).ToList();
            var cq = OrderSqlHelper.PendingOrderQuery(entityDataSource1);
            var count = cq.Count();

            var q = OrderSqlHelper.PendingOrderQueryEx(entityDataSource1);
            // 分页
            
            //if (pager1.PageCurrent > 1) { 
              q = q.Skip(pager1.OffSet(pager1.PageCurrent - 1));
            //}
            q = q.Take(pager1.OffSet(pager1.PageCurrent));

            // create BindingList (sortable/filterable)
            var bindinglist = entityDataSource1.CreateView(q) as EntityBindingList<v_pendingorder>;
            
            var list = new List<v_pendingorder>();
            if(  bindinglist!= null){
              list =  bindinglist.ToList();
            }

            IEnumerable<IGrouping<int, v_pendingorder>> grouped_orders = list.GroupBy( o => o.自社コード, o => o);
            foreach (var gos in grouped_orders)
            {
                int total = 0; 

                foreach (var o in gos) {
                    total += o.発注数量;

                    if (o.在庫数 >= total)
                    {
                        o.在庫状態 = "あり";
                    }
                    else if (o.在庫数 > o.口数)
                    {
                        o.在庫状態 = "一部不足";
                    }
                    else {
                        o.在庫状態 = "なし";
                    }
                }
            }
               
            this.bindingSource1.DataSource = bindinglist;
            // assign BindingList to grid
            dataGridView1.DataSource = this.bindingSource1;

            InitializeFormDataSource();

            return count;
        }

        private void InitializeFormDataSource()
        {
            orderIDTextBox.DataBindings.Clear();
            invoiceNOTextBox.DataBindings.Clear();
            storeNamTextBox.DataBindings.Clear();
            storeCodeTextBox.DataBindings.Clear();
            orderReceivedAtTextBox.DataBindings.Clear();
            productKanjiNameTextBox.DataBindings.Clear();
            productKanjiSpecificationTextBox.DataBindings.Clear();
            productReceivedAtTextBox3.DataBindings.Clear();

            if( this.bindingSource1.Count > 0)
            {
                //invoiceNOTextBox.DataBindings.Clear();
                orderIDTextBox.DataBindings.Add("Text", bindingSource1, "id受注データ");
                invoiceNOTextBox.DataBindings.Add("Text", bindingSource1, "伝票番号");
                storeNamTextBox.DataBindings.Add("Text", bindingSource1, "店名");
                storeCodeTextBox.DataBindings.Add("Text", bindingSource1, "店舗コード");
                orderReceivedAtTextBox.DataBindings.Add("Text", bindingSource1, "受注日");
                productKanjiNameTextBox.DataBindings.Add("Text", bindingSource1, "品名漢字");
                productKanjiSpecificationTextBox.DataBindings.Add("Text", bindingSource1, "規格名漢字");

                //dateTimePicker1.DataBindings.Add("Text", bindingSource1, "出荷日");
                productReceivedAtTextBox3.DataBindings.Add("Text", bindingSource1, "納品日");


                dateTimePicker1.CustomFormat = " ";
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
            }

        }



        #endregion

        private int GetSelectedOrderID()
        {

            return Convert.ToInt32(orderIDTextBox.Text);
        }

        private IEnumerable<int> GetChangedRowIndexes() {

            List<int> rows = new List<int>();
            foreach (DictionaryEntry entry in datagrid_changes)
            {
                var key = entry.Key as string;
                if (key.EndsWith("_changed"))
                {
                    int row = Int32.Parse(key.Split('_')[0]);
                    rows.Add(row);
                }
                //                    Console.WriteLine("Key -- {0}; Value --{1}.", entry.Key, entry.Value);
            }
            return rows.Distinct();
        }

        private void sendToShipperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var oids = GetOrderIdsBySelectedGridCell();

            if (oids.Count() > 0)
            {
                OrderSqlHelper.SendOrderToShipper(oids);
                pager1.Bind();
            }
            else {
                MessageBox.Show(" please select rows in the order list first.");
            }
        }

        private void cancelOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rows = GetSelectedRowsBySelectedCells();
            if (rows.Count() > 0)
            {
                using (var ctx = new GODDbContext())
                {
                    foreach (DataGridViewRow row in rows)
                    {
                        var pendingorder = row.DataBoundItem as v_pendingorder;
                        t_orderdata order = ctx.t_orderdata.Find(pendingorder.id受注データ);
                        order.キャンセル = "yes";
                        order.キャンセル時刻 = DateTime.Now;
                        order.備考 = "キャンセル";
                    }
                    ctx.SaveChanges();
                }
                pager1.Bind();
            }
            else
            {
                MessageBox.Show(" please select rows in the order list first.");
            }
        }

        private void uncancleOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rows = GetSelectedRowsBySelectedCells();
            if (rows.Count() > 0)
            {
                using (var ctx = new GODDbContext())
                {
                    foreach (DataGridViewRow row in rows)
                    {
                        var pendingorder = row.DataBoundItem as v_pendingorder;
                        t_orderdata order = ctx.t_orderdata.Find(pendingorder.id受注データ);
                        order.キャンセル = "no";
                        order.キャンセル時刻 = null;
                        order.備考 = "キャンセル解除";
                    }
                    ctx.SaveChanges();
                }
                pager1.Bind();
            }
            else
            {
                MessageBox.Show(" please select rows in the order list first.");
            }

        }

        private void newOrderbutton_Click(object sender, EventArgs e)
        {
            var form = new NewOrdersForm();
            if (form.ShowDialog() == DialogResult.OK) {
                pager1.Bind();
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }


        private IEnumerable<DataGridViewRow> GetSelectedRowsBySelectedCells() {
            List<DataGridViewRow> rows = new List<DataGridViewRow>();
            foreach (DataGridViewCell cell in this.dataGridView1.SelectedCells)
            {
                rows.Add(cell.OwningRow);
            }
            return rows.Distinct();
        }

        private void invoiceNoFilterTextBox_Leave(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            string filter = "";
            if (this.storeCodeFilterTextBox3.Text.Length > 0)
            {
                filter += "(店舗コード=" + this.storeCodeFilterTextBox3.Text + ")";
            }
            if (this.invoiceNoFilterTextBox.Text.Length > 0)
            {
                if (filter.Length > 0)
                {
                    filter += " AND ";
                }
                filter += "(伝票番号=" + this.invoiceNoFilterTextBox.Text + ")";
            }
            this.bindingSource1.Filter = filter;

        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private int pager1_EventPaging(EventPagingArg e)
        {
            int order_count = InitializeOrderData();
            
            return order_count;
        }

        /// <summary>   
        /// GridViw数据绑定   
        /// </summary>   
        /// <returns></returns>   
        private int BindDgv()
        {
            //传入要取的第一条和最后一条   
            //string start = (pager1.PageSize * (pager1.PageCurrent - 1) + 1).ToString();
            //string end = (pager1.PageSize * pager1.PageCurrent).ToString();

            //数据源   
            //dtPage = achieve.GetAll(Keyword, start, end);
            //绑定分页控件   
            //pager1.bindingSource1.DataSource = dtPage;
            //pager1.bindingNavigator1.BindingSource = pager1.bindingSource1;
            //讲分页控件绑定DataGridView   
            //dgvClients.DataSource = pager1.bindingSource1;
            //返回总记录数   
            return 0;// achieve.GetToalCount(Keyword);
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

        private List<int> GetOrderIdsBySelectedGridCell()
        {

            List<int> order_ids = new List<int>();
            var rows = GetSelectedRowsBySelectedCells(dataGridView1);
            foreach (DataGridViewRow row in rows)
            {
                var pendingorder = row.DataBoundItem as v_pendingorder;
                order_ids.Add(pendingorder.id受注データ);
            }

            return order_ids;
        }

        private void PendingOrderForm_SizeChanged(object sender, EventArgs e)
        {
           
        }

    }
}
