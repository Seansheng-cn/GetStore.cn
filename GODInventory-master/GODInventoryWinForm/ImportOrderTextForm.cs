
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
    using GODInventory.MyLinq;
    using GODInventory.ViewModel;
    using GODInventory.ViewModel.EDI;
    using System.Data.Entity.Validation;
    using System.IO;

    public partial class ImportOrderTextForm : Form
    {
        public ImportOrderTextForm()
        {
            InitializeComponent();
        }

        public int ProgressValue 
         {
             get { return this.progressBar1.Value; }
             set { progressBar1.Value = value; }
         }
 

        private void openFileBtton_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK) {
                this.pathTextBox.Text = openFileDialog1.FileName;
            }
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            this.importButton.Enabled = false;
            this.cancelButton.Enabled = false;
            backgroundWorker1.RunWorkerAsync(new WorkerArgument { OrderCount = 0, CurrentIndex = 0 });

           
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            WorkerArgument arg = e.Argument as WorkerArgument;
            bool success = ImportOrderTxt( pathTextBox.Text, arg);
            e.Cancel = !success;

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            WorkerArgument arg = e.UserState as WorkerArgument;
            if(!arg.HasError)
            {
                this.progressMsgLabel.Text = String.Format("{0}/{1}", arg.CurrentIndex, arg.OrderCount);
                this.ProgressValue = e.ProgressPercentage;
            }
            else
            {
                this.progressMsgLabel.Text = arg.ErrorMessage;
            }

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                this.importButton.Enabled = true;
                this.cancelButton.Enabled = true;
                this.progressMsgLabel.Text = "Great, it is done!";
            }
            else {
                this.cancelButton.Enabled = true;
            }
        }


        private bool ImportOrderTxt(string path, WorkerArgument arg)
        {
            bool success = true;
            //File.ReadLines(path, Encoding.)
            //File.ReadAllBytes(path);

            //var lines = ConvertToUtf8Strings(path);
            List<OrderModel> order_models = new List<OrderModel>();

            try
            {
                //byte[] first_line = null;
                //byte[] line = null;
                using (BinaryReader br = new BinaryReader(new FileStream(path, FileMode.Open, FileAccess.Read)))
                {
                    OrderHeadModel order_head = new OrderHeadModel(br);
                    Console.WriteLine(" write head ={0}", order_head.DetailCount);
                    for (var i = 0; i < order_head.DetailCount; i++)
                    {
                        int progress = Convert.ToInt16( (i + 1) * 0.5 / order_head.DetailCount *100);
                        order_models.Add(new OrderModel(br));
                        //if (progress != last)
                        //
                        //    backgroundWorker1.ReportProgress(progress);
                        //    last = progress;
                        //}
                    }
                   
                }
            }
            catch (EndOfStreamException e)
            {

            }

            using (var ctx = new GODDbContext())
            {
                List<t_itemlist> items = ctx.t_itemlist.Select(s => s).ToList();
                List<t_shoplist> shops = ctx.t_shoplist.Select(s => s).ToList();

                OrderModel model = null;
                int progress = 0;
                using (var ctxTransaction = ctx.Database.BeginTransaction())
                {
                    try
                    {
                        List<string> sqls = new List<string>(100);
                        //var orders = order_models.Select(x => x.ConverToEntity());
                        //var result = ctx.Entry(orders.First()).GetValidationResult();
                        //ctx.t_orderdata.AddRange(orders);                        
                        //ctx.SaveChanges();
                        arg.OrderCount = order_models.Count;
                        CustomMySqlParameters sql_parameters = null;
                        for (var i = 0; i < order_models.Count; i++)
                        {
                            arg.CurrentIndex = i + 1;

                            progress = Convert.ToInt16( ( (i+1)*1.0 / order_models.Count )* 100);
                            model = order_models.ElementAt(i);
                            var item = items.FirstOrDefault(s => s.JANコード == model.JanCode);
                            if(item == null)
                            {
                                throw new Exception(String.Format("Can not find product by jancode {0}", model.JanCode));
                            }
                            var shop = shops.FirstOrDefault(s => s.店番 == model.StoreCode);
                            if (shop == null)
                            {
                                throw new Exception(String.Format("Can not find shop by shopcode {0}", model.StoreCode));
                            }

                            //sql_parameters = model.ToSqlArguments(shop, item);
                            var sql = model.ToRawSql(shop, item);
                            //Console.WriteLine("sql = #{0}", sql);
                            sqls.Add(sql);
                            if ((i == order_models.Count - 1) || (arg.CurrentIndex % 25 ==0))
                            {
                                var multisql = String.Join("", sqls.ToArray());
                                ctx.Database.ExecuteSqlCommand(multisql);
                                sqls.Clear();
                            }
                            //ctx.Database.ExecuteSqlCommand(sql_parameters.SqlString, sql_parameters.Parameters);
                            // use sql instead of orm
                            //var order = order_models.ElementAt(i).ConverToEntity();
                            //ctx.t_orderdata.Add(order);
                            //ctx.SaveChanges();
                            if (arg.CurrentIndex % 25 == 0)
                            {
                                backgroundWorker1.ReportProgress(progress, arg);
                            }

                        }
                        backgroundWorker1.ReportProgress(100, arg);

                        ctxTransaction.Commit();
                    }
                   
                    catch (Exception e)
                    {
                        ctxTransaction.Rollback();
                        arg.HasError = true;
                        arg.ErrorMessage = e.Message;                            
                        
                        backgroundWorker1.ReportProgress(progress, arg);
                        success = false;
                    }
                }

            }
            return success;
        }
        private string[] ConvertToUtf8Strings(string path)
        {
            byte[] bytes = File.ReadAllBytes(path);
            string text_in_utf8 = EncodingUtility.ConvertShiftJisToUtf8(bytes);
            return text_in_utf8.Split(System.Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
        }

    }
}
