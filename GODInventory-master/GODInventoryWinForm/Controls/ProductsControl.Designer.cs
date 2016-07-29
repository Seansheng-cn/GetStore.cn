namespace GODInventoryWinForm.Controls
{
    partial class ProductsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.自社コードDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.得意先DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ジャンルDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商品名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.規格DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.配送担当DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.価格発動日DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pT入数DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.仕入原価DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.単価DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.売価DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商品コードDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jANコードDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.インストアコードDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.単品重量DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.単位DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pT単位かDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entityDataSource1 = new GODInventory.ViewModel.EntityDataSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.自社コードDataGridViewTextBoxColumn,
            this.得意先DataGridViewTextBoxColumn,
            this.ジャンルDataGridViewTextBoxColumn,
            this.商品名DataGridViewTextBoxColumn,
            this.規格DataGridViewTextBoxColumn,
            this.配送担当DataGridViewTextBoxColumn,
            this.価格発動日DataGridViewTextBoxColumn,
            this.pT入数DataGridViewTextBoxColumn,
            this.仕入原価DataGridViewTextBoxColumn,
            this.単価DataGridViewTextBoxColumn,
            this.売価DataGridViewTextBoxColumn,
            this.商品コードDataGridViewTextBoxColumn,
            this.jANコードDataGridViewTextBoxColumn,
            this.インストアコードDataGridViewTextBoxColumn,
            this.単品重量DataGridViewTextBoxColumn,
            this.単位DataGridViewTextBoxColumn,
            this.pT単位かDataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "t_itemlist";
            this.dataGridView1.DataSource = this.entityDataSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(754, 389);
            this.dataGridView1.TabIndex = 0;
            // 
            // 自社コードDataGridViewTextBoxColumn
            // 
            this.自社コードDataGridViewTextBoxColumn.DataPropertyName = "自社コード";
            this.自社コードDataGridViewTextBoxColumn.HeaderText = "自社コード";
            this.自社コードDataGridViewTextBoxColumn.Name = "自社コードDataGridViewTextBoxColumn";
            // 
            // 得意先DataGridViewTextBoxColumn
            // 
            this.得意先DataGridViewTextBoxColumn.DataPropertyName = "得意先";
            this.得意先DataGridViewTextBoxColumn.HeaderText = "得意先";
            this.得意先DataGridViewTextBoxColumn.Name = "得意先DataGridViewTextBoxColumn";
            // 
            // ジャンルDataGridViewTextBoxColumn
            // 
            this.ジャンルDataGridViewTextBoxColumn.DataPropertyName = "ジャンル";
            this.ジャンルDataGridViewTextBoxColumn.HeaderText = "ジャンル";
            this.ジャンルDataGridViewTextBoxColumn.Name = "ジャンルDataGridViewTextBoxColumn";
            // 
            // 商品名DataGridViewTextBoxColumn
            // 
            this.商品名DataGridViewTextBoxColumn.DataPropertyName = "商品名";
            this.商品名DataGridViewTextBoxColumn.HeaderText = "商品名";
            this.商品名DataGridViewTextBoxColumn.Name = "商品名DataGridViewTextBoxColumn";
            // 
            // 規格DataGridViewTextBoxColumn
            // 
            this.規格DataGridViewTextBoxColumn.DataPropertyName = "規格";
            this.規格DataGridViewTextBoxColumn.HeaderText = "規格";
            this.規格DataGridViewTextBoxColumn.Name = "規格DataGridViewTextBoxColumn";
            // 
            // 配送担当DataGridViewTextBoxColumn
            // 
            this.配送担当DataGridViewTextBoxColumn.DataPropertyName = "配送担当";
            this.配送担当DataGridViewTextBoxColumn.HeaderText = "配送担当";
            this.配送担当DataGridViewTextBoxColumn.Name = "配送担当DataGridViewTextBoxColumn";
            // 
            // 価格発動日DataGridViewTextBoxColumn
            // 
            this.価格発動日DataGridViewTextBoxColumn.DataPropertyName = "価格発動日";
            this.価格発動日DataGridViewTextBoxColumn.HeaderText = "価格発動日";
            this.価格発動日DataGridViewTextBoxColumn.Name = "価格発動日DataGridViewTextBoxColumn";
            // 
            // pT入数DataGridViewTextBoxColumn
            // 
            this.pT入数DataGridViewTextBoxColumn.DataPropertyName = "PT入数";
            this.pT入数DataGridViewTextBoxColumn.HeaderText = "PT入数";
            this.pT入数DataGridViewTextBoxColumn.Name = "pT入数DataGridViewTextBoxColumn";
            // 
            // 仕入原価DataGridViewTextBoxColumn
            // 
            this.仕入原価DataGridViewTextBoxColumn.DataPropertyName = "仕入原価";
            this.仕入原価DataGridViewTextBoxColumn.HeaderText = "仕入原価";
            this.仕入原価DataGridViewTextBoxColumn.Name = "仕入原価DataGridViewTextBoxColumn";
            // 
            // 単価DataGridViewTextBoxColumn
            // 
            this.単価DataGridViewTextBoxColumn.DataPropertyName = "単価";
            this.単価DataGridViewTextBoxColumn.HeaderText = "単価";
            this.単価DataGridViewTextBoxColumn.Name = "単価DataGridViewTextBoxColumn";
            // 
            // 売価DataGridViewTextBoxColumn
            // 
            this.売価DataGridViewTextBoxColumn.DataPropertyName = "売価";
            this.売価DataGridViewTextBoxColumn.HeaderText = "売価";
            this.売価DataGridViewTextBoxColumn.Name = "売価DataGridViewTextBoxColumn";
            // 
            // 商品コードDataGridViewTextBoxColumn
            // 
            this.商品コードDataGridViewTextBoxColumn.DataPropertyName = "商品コード";
            this.商品コードDataGridViewTextBoxColumn.HeaderText = "商品コード";
            this.商品コードDataGridViewTextBoxColumn.Name = "商品コードDataGridViewTextBoxColumn";
            // 
            // jANコードDataGridViewTextBoxColumn
            // 
            this.jANコードDataGridViewTextBoxColumn.DataPropertyName = "JANコード";
            this.jANコードDataGridViewTextBoxColumn.HeaderText = "JANコード";
            this.jANコードDataGridViewTextBoxColumn.Name = "jANコードDataGridViewTextBoxColumn";
            // 
            // インストアコードDataGridViewTextBoxColumn
            // 
            this.インストアコードDataGridViewTextBoxColumn.DataPropertyName = "インストアコード";
            this.インストアコードDataGridViewTextBoxColumn.HeaderText = "インストアコード";
            this.インストアコードDataGridViewTextBoxColumn.Name = "インストアコードDataGridViewTextBoxColumn";
            // 
            // 単品重量DataGridViewTextBoxColumn
            // 
            this.単品重量DataGridViewTextBoxColumn.DataPropertyName = "単品重量";
            this.単品重量DataGridViewTextBoxColumn.HeaderText = "単品重量";
            this.単品重量DataGridViewTextBoxColumn.Name = "単品重量DataGridViewTextBoxColumn";
            // 
            // 単位DataGridViewTextBoxColumn
            // 
            this.単位DataGridViewTextBoxColumn.DataPropertyName = "単位";
            this.単位DataGridViewTextBoxColumn.HeaderText = "単位";
            this.単位DataGridViewTextBoxColumn.Name = "単位DataGridViewTextBoxColumn";
            // 
            // pT単位かDataGridViewTextBoxColumn
            // 
            this.pT単位かDataGridViewTextBoxColumn.DataPropertyName = "PT単位か";
            this.pT単位かDataGridViewTextBoxColumn.HeaderText = "PT単位か";
            this.pT単位かDataGridViewTextBoxColumn.Name = "pT単位かDataGridViewTextBoxColumn";
            // 
            // entityDataSource1
            // 
            this.entityDataSource1.DbContextType = typeof(GODInventory.MyLinq.GODDbContext);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(0, 46);
            this.panel1.Margin = new System.Windows.Forms.Padding(8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 389);
            this.panel1.TabIndex = 2;
            // 
            // ProductsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.panel1);
            this.Name = "ProductsControl";
            this.Size = new System.Drawing.Size(754, 438);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private GODInventory.ViewModel.EntityDataSource entityDataSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 自社コードDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 得意先DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ジャンルDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 規格DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 配送担当DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 価格発動日DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pT入数DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 仕入原価DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 単価DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 売価DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品コードDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jANコードDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn インストアコードDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 単品重量DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 単位DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pT単位かDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
    }
}
