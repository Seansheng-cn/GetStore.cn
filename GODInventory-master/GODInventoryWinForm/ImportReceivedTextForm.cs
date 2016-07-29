using GODInventory.MyLinq;
using GODInventory.ViewModel.EDI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GODInventoryWinForm
{
    public partial class ImportReceivedTextForm : Form
    {
        public ImportReceivedTextForm()
        {
            InitializeComponent();
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            this.importButton.Enabled = false;
            this.cancelButton.Enabled = false;
            backgroundWorker1.RunWorkerAsync(new WorkerArgument { OrderCount = 0, CurrentIndex = 0 });

        }

        public int ProgressValue
        {
            get { return this.progressBar1.Value; }
            set { progressBar1.Value = value; }
        }


        private void openFileBtton_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.pathTextBox.Text = openFileDialog1.FileName;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            WorkerArgument arg = e.Argument as WorkerArgument;
            bool success = ImportJuryouTxt(pathTextBox.Text, arg);
            e.Cancel = !success;

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            WorkerArgument arg = e.UserState as WorkerArgument;
            if (!arg.HasError)
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
            else
            {
                this.cancelButton.Enabled = true;
            }
        }

        private bool ImportJuryouTxt(string path, WorkerArgument arg)
        {
            bool success = true;
            ReceivedOrderHeadModel order_head = null;
            List<ReceivedOrderModel> models;
            try
            {
                //byte[] first_line = null;
                //byte[] line = null;
                using (BinaryReader br = new BinaryReader(new FileStream(path, FileMode.Open, FileAccess.Read)))
                {
                    order_head = new ReceivedOrderHeadModel(br);
                    Console.WriteLine(" write head ={0}", order_head.DetailCount);
                    
                }
            }
            catch (EndOfStreamException e)
            {

            }

            using (var ctx = new GODDbContext())
            {
                int progress = 0;
                
                using (var ctxTransaction = ctx.Database.BeginTransaction())
                {
                    try
                    {
                        List<string> sqls = new List<string>(100);
                        
                        arg.OrderCount = order_head.DetailCount;
                        models = order_head.Models;
                        for (var i = 0; i < models.Count; i++)
                        {
                            var model = models.ElementAt(i);
                            progress = Convert.ToInt16(((i + 1) * 1.0 / models.Count) * 100);
                            // use sql instead of orm
                            //var order = model.ConverToEntity( ctx );
                            int count = 0;
                            
                                //sql_parameters = model.ToSqlArguments(shop, item);
                                var sql = model.ToRawSql();
                                //Console.WriteLine("sql = #{0}", sql);
                                
                                if( ctx.Database.ExecuteSqlCommand(sql) ==0 ){
                                   throw new Exception(String.Format("Can not find order by 店舗コード {0} and 伝票番号 {1} in 3 months.", model.StoreCode, model.InvoiceCode));
                                }
                                
                                arg.CurrentIndex = i + 1;
                                if (i % 25 == 0)
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
                        if (e.Message.StartsWith("Can"))
                        {
                            arg.ErrorMessage = e.Message;
                        }
                        backgroundWorker1.ReportProgress(progress, arg);
                        success = false;
                    }
                }

            }
            return success;

        }

    }
}
