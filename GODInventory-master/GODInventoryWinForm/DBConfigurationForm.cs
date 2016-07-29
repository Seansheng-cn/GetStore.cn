using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GODInventory.ViewModel;
using MySql.Data.MySqlClient;

namespace GODInventoryWinForm
{
    public partial class DBConfigurationForm : Form
    {
        public DBConfigurationForm()
        {
            InitializeComponent();
        }

        private void SaveButton3_Click(object sender, EventArgs e)
        {
            ConfigHelper.SetConfig("server", this.serverTextBox1.Text);
            ConfigHelper.SetConfig("database", this.databaseTextBox2.Text);
            ConfigHelper.SetConfig("user id", this.userNameTextBox3.Text);
            ConfigHelper.SetConfig("password", this.userPasswordTextBox4.Text);
            
            System.Windows.Forms.Application.Restart();
        }

        private void DBConfigurationForm_Load(object sender, EventArgs e)
        {
            var configs = ConfigHelper.GetConfig();
            // for first time, there is no key server ...
            if (configs.ContainsKey("server")) { 
                this.serverTextBox1.Text = configs["server"];
                this.databaseTextBox2.Text = configs["database"];
                this.userNameTextBox3.Text = configs["user id"];
                this.userPasswordTextBox4.Text = configs["password"];
            }
        }

        private void testButton1_Click(object sender, EventArgs e)
        {

            string msg = "";
            //连接字符串拼装  
            var myconn = new MySqlConnection(DBConfiguration.GetConnectionString("GODDbContext"));

            //连接 
            try
            {
                myconn.Open();

                if (myconn.State.ToString() == "Open")
                {
                    msg = "Connect MYSQL successfully!";
                }

            }
            catch (MySqlException exception)
            {

                msg = exception.Message;
            }
            finally {

                myconn.Close();
            }
              

        }

        private string BuildDbConnectionString() {

            return String.Format("server={0};user id={1};database={2};passowrd={3};allowuservariables=True;characterset=utf8",
                this.serverTextBox1.Text, this.databaseTextBox2.Text, this.userNameTextBox3, this.userPasswordTextBox4.Text);
        
        }

        private void cancelButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
