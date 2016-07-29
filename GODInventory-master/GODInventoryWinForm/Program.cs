using GODInventory.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.Interception;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.Entity;
using GODInventory.MyLinq;

namespace GODInventoryWinForm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Database.SetInitializer<GODDbContext>(null);
            if (DbConnectable())
            {
                LogHelper.WriteLog("Start application GodInventory");
                StartMainForm();
            }
            else {

                StartDbConfiguration();
            }
        }

        static void StartMainForm() {
#if DEBUG   
            DbInterception.Add(new EFIntercepterLogging());
#endif
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        
        }

        static void StartDbConfiguration() {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);            
            //Application.Run(new DBConfigurationForm());
            MessageBox.Show( String.Format( "{0}",
                "Can not connect to mysql, please correct GODDBContext in file InventoryDemo.exe.config !" ));
        }

        static bool DbConnectable() {
            bool success = false;
            string msg = "";
            //连接字符串拼装  
            var myconn = new MySqlConnection(DBConfiguration.GetConnectionString("GODDbContext"));


            //连接 
            try
            {
                myconn.Open();

                if (myconn.State.ToString() == "Open")
                {
                    success = true;
                }

            }
            catch (MySqlException exception)
            {
                LogHelper.WriteLog("DB open error", exception);
                LogHelper.WriteLog(string.Format("DB connection string is {0}", DBConfiguration.GetConnectionString("GODDbContext")));
            }
            finally
            {

                myconn.Close();
            }

            return success;
        }
    }
}
