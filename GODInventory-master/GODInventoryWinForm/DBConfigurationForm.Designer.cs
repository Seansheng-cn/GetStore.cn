namespace GODInventoryWinForm
{
    partial class DBConfigurationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.serverTextBox1 = new System.Windows.Forms.TextBox();
            this.databaseTextBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userNameTextBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.userPasswordTextBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.testButton1 = new System.Windows.Forms.Button();
            this.cancelButton2 = new System.Windows.Forms.Button();
            this.SaveButton3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server IP";
            // 
            // serverTextBox1
            // 
            this.serverTextBox1.Location = new System.Drawing.Point(144, 50);
            this.serverTextBox1.Name = "serverTextBox1";
            this.serverTextBox1.Size = new System.Drawing.Size(204, 21);
            this.serverTextBox1.TabIndex = 1;
            // 
            // databaseTextBox2
            // 
            this.databaseTextBox2.Location = new System.Drawing.Point(144, 77);
            this.databaseTextBox2.Name = "databaseTextBox2";
            this.databaseTextBox2.Size = new System.Drawing.Size(204, 21);
            this.databaseTextBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Database";
            // 
            // userNameTextBox3
            // 
            this.userNameTextBox3.Location = new System.Drawing.Point(144, 104);
            this.userNameTextBox3.Name = "userNameTextBox3";
            this.userNameTextBox3.Size = new System.Drawing.Size(204, 21);
            this.userNameTextBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "User name";
            // 
            // userPasswordTextBox4
            // 
            this.userPasswordTextBox4.Location = new System.Drawing.Point(144, 131);
            this.userPasswordTextBox4.Name = "userPasswordTextBox4";
            this.userPasswordTextBox4.Size = new System.Drawing.Size(204, 21);
            this.userPasswordTextBox4.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "User password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "System database configuration";
            // 
            // testButton1
            // 
            this.testButton1.Location = new System.Drawing.Point(90, 163);
            this.testButton1.Name = "testButton1";
            this.testButton1.Size = new System.Drawing.Size(75, 23);
            this.testButton1.TabIndex = 9;
            this.testButton1.Text = "Test";
            this.testButton1.UseVisualStyleBackColor = true;
            this.testButton1.Click += new System.EventHandler(this.testButton1_Click);
            // 
            // cancelButton2
            // 
            this.cancelButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton2.Location = new System.Drawing.Point(272, 163);
            this.cancelButton2.Name = "cancelButton2";
            this.cancelButton2.Size = new System.Drawing.Size(75, 23);
            this.cancelButton2.TabIndex = 10;
            this.cancelButton2.Text = "Cancel";
            this.cancelButton2.UseVisualStyleBackColor = true;
            this.cancelButton2.Click += new System.EventHandler(this.cancelButton2_Click);
            // 
            // SaveButton3
            // 
            this.SaveButton3.Location = new System.Drawing.Point(182, 163);
            this.SaveButton3.Name = "SaveButton3";
            this.SaveButton3.Size = new System.Drawing.Size(75, 23);
            this.SaveButton3.TabIndex = 11;
            this.SaveButton3.Text = "Save";
            this.SaveButton3.UseVisualStyleBackColor = true;
            this.SaveButton3.Click += new System.EventHandler(this.SaveButton3_Click);
            // 
            // DBConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 199);
            this.Controls.Add(this.SaveButton3);
            this.Controls.Add(this.cancelButton2);
            this.Controls.Add(this.testButton1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.userPasswordTextBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.userNameTextBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.databaseTextBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.serverTextBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DBConfigurationForm";
            this.Text = "ConfigurationForm";
            this.Load += new System.EventHandler(this.DBConfigurationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox serverTextBox1;
        private System.Windows.Forms.TextBox databaseTextBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userNameTextBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userPasswordTextBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button testButton1;
        private System.Windows.Forms.Button cancelButton2;
        private System.Windows.Forms.Button SaveButton3;
    }
}