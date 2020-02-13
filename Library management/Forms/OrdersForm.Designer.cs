namespace Library_management.Forms
{
    partial class OrdersForm
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
            this.TxtCustomerIdentity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbxIdentityOfCustomerOrderTime = new System.Windows.Forms.TextBox();
            this.tbxBookNameOrderTime = new System.Windows.Forms.TextBox();
            this.tbxBookPriceOrderTime = new System.Windows.Forms.TextBox();
            this.BtnBasket = new System.Windows.Forms.Button();
            this.btnShowBasket = new System.Windows.Forms.Button();
            this.lblOrderTimeIdentityId = new System.Windows.Forms.Label();
            this.lblBookNameOrderTime = new System.Windows.Forms.Label();
            this.lblBookPriceOrderTime = new System.Windows.Forms.Label();
            this.lblBookNameForSearchBook = new System.Windows.Forms.Label();
            this.dgwBookSearchForOrder = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbxSearchForBookOrder = new System.Windows.Forms.TextBox();
            this.lblReturnTime = new System.Windows.Forms.Label();
            this.lblBookCount = new System.Windows.Forms.Label();
            this.dtPckReturnTime = new System.Windows.Forms.DateTimePicker();
            this.tbxBookCount = new System.Windows.Forms.TextBox();
            this.btnReturnOrderNav = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBookSearchForOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtCustomerIdentity
            // 
            this.TxtCustomerIdentity.Location = new System.Drawing.Point(134, 16);
            this.TxtCustomerIdentity.Name = "TxtCustomerIdentity";
            this.TxtCustomerIdentity.Size = new System.Drawing.Size(131, 20);
            this.TxtCustomerIdentity.TabIndex = 0;
            this.TxtCustomerIdentity.TextChanged += new System.EventHandler(this.TxtCustomerIdentity_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Musterinin kimlik seriasi:";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(280, 16);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(190, 27);
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.Text = "Musteri yarat";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(12, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(458, 124);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Adi";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Soyadi";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Phone";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Email";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Kimlik-nomresi";
            this.Column6.Name = "Column6";
            // 
            // tbxIdentityOfCustomerOrderTime
            // 
            this.tbxIdentityOfCustomerOrderTime.Enabled = false;
            this.tbxIdentityOfCustomerOrderTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxIdentityOfCustomerOrderTime.Location = new System.Drawing.Point(686, 18);
            this.tbxIdentityOfCustomerOrderTime.Name = "tbxIdentityOfCustomerOrderTime";
            this.tbxIdentityOfCustomerOrderTime.Size = new System.Drawing.Size(105, 20);
            this.tbxIdentityOfCustomerOrderTime.TabIndex = 5;
            // 
            // tbxBookNameOrderTime
            // 
            this.tbxBookNameOrderTime.Enabled = false;
            this.tbxBookNameOrderTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBookNameOrderTime.Location = new System.Drawing.Point(686, 44);
            this.tbxBookNameOrderTime.Name = "tbxBookNameOrderTime";
            this.tbxBookNameOrderTime.Size = new System.Drawing.Size(105, 20);
            this.tbxBookNameOrderTime.TabIndex = 5;
            // 
            // tbxBookPriceOrderTime
            // 
            this.tbxBookPriceOrderTime.Enabled = false;
            this.tbxBookPriceOrderTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBookPriceOrderTime.Location = new System.Drawing.Point(686, 70);
            this.tbxBookPriceOrderTime.Name = "tbxBookPriceOrderTime";
            this.tbxBookPriceOrderTime.Size = new System.Drawing.Size(105, 20);
            this.tbxBookPriceOrderTime.TabIndex = 5;
            // 
            // BtnBasket
            // 
            this.BtnBasket.Enabled = false;
            this.BtnBasket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBasket.Location = new System.Drawing.Point(616, 151);
            this.BtnBasket.Name = "BtnBasket";
            this.BtnBasket.Size = new System.Drawing.Size(175, 32);
            this.BtnBasket.TabIndex = 6;
            this.BtnBasket.Text = "Sifaris et";
            this.BtnBasket.UseVisualStyleBackColor = true;
            this.BtnBasket.Click += new System.EventHandler(this.BtnBasket_Click);
            // 
            // btnShowBasket
            // 
            this.btnShowBasket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowBasket.Location = new System.Drawing.Point(616, 189);
            this.btnShowBasket.Name = "btnShowBasket";
            this.btnShowBasket.Size = new System.Drawing.Size(175, 32);
            this.btnShowBasket.TabIndex = 6;
            this.btnShowBasket.Text = "Sebeti Goster";
            this.btnShowBasket.UseVisualStyleBackColor = true;
            this.btnShowBasket.Click += new System.EventHandler(this.BtnShowBasket_Click);
            // 
            // lblOrderTimeIdentityId
            // 
            this.lblOrderTimeIdentityId.AutoSize = true;
            this.lblOrderTimeIdentityId.Location = new System.Drawing.Point(592, 23);
            this.lblOrderTimeIdentityId.Name = "lblOrderTimeIdentityId";
            this.lblOrderTimeIdentityId.Size = new System.Drawing.Size(88, 13);
            this.lblOrderTimeIdentityId.TabIndex = 8;
            this.lblOrderTimeIdentityId.Text = "Musteri ID Serie :";
            // 
            // lblBookNameOrderTime
            // 
            this.lblBookNameOrderTime.AutoSize = true;
            this.lblBookNameOrderTime.Location = new System.Drawing.Point(625, 47);
            this.lblBookNameOrderTime.Name = "lblBookNameOrderTime";
            this.lblBookNameOrderTime.Size = new System.Drawing.Size(55, 13);
            this.lblBookNameOrderTime.TabIndex = 8;
            this.lblBookNameOrderTime.Text = "Kitab Adi :";
            // 
            // lblBookPriceOrderTime
            // 
            this.lblBookPriceOrderTime.AutoSize = true;
            this.lblBookPriceOrderTime.Location = new System.Drawing.Point(606, 73);
            this.lblBookPriceOrderTime.Name = "lblBookPriceOrderTime";
            this.lblBookPriceOrderTime.Size = new System.Drawing.Size(74, 13);
            this.lblBookPriceOrderTime.TabIndex = 8;
            this.lblBookPriceOrderTime.Text = "Kitab Qiymeti :";
            // 
            // lblBookNameForSearchBook
            // 
            this.lblBookNameForSearchBook.AutoSize = true;
            this.lblBookNameForSearchBook.Location = new System.Drawing.Point(49, 186);
            this.lblBookNameForSearchBook.Name = "lblBookNameForSearchBook";
            this.lblBookNameForSearchBook.Size = new System.Drawing.Size(63, 13);
            this.lblBookNameForSearchBook.TabIndex = 1;
            this.lblBookNameForSearchBook.Text = "Kitabin Adi :";
            // 
            // dgwBookSearchForOrder
            // 
            this.dgwBookSearchForOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwBookSearchForOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBookSearchForOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.dgwBookSearchForOrder.Location = new System.Drawing.Point(15, 209);
            this.dgwBookSearchForOrder.Name = "dgwBookSearchForOrder";
            this.dgwBookSearchForOrder.Size = new System.Drawing.Size(458, 165);
            this.dgwBookSearchForOrder.TabIndex = 3;
            this.dgwBookSearchForOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgwBookSearchForOrder_CellClick);
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Id";
            this.Column7.Name = "Column7";
            this.Column7.Visible = false;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Name";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Kitabin qiymeti";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Kitab sayisi";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Janri";
            this.Column11.Name = "Column11";
            // 
            // tbxSearchForBookOrder
            // 
            this.tbxSearchForBookOrder.Location = new System.Drawing.Point(137, 183);
            this.tbxSearchForBookOrder.Name = "tbxSearchForBookOrder";
            this.tbxSearchForBookOrder.Size = new System.Drawing.Size(336, 20);
            this.tbxSearchForBookOrder.TabIndex = 9;
            this.tbxSearchForBookOrder.TextChanged += new System.EventHandler(this.TbxSearchForBookOrder_TextChanged);
            // 
            // lblReturnTime
            // 
            this.lblReturnTime.AutoSize = true;
            this.lblReturnTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnTime.Location = new System.Drawing.Point(496, 100);
            this.lblReturnTime.Name = "lblReturnTime";
            this.lblReturnTime.Size = new System.Drawing.Size(184, 16);
            this.lblReturnTime.TabIndex = 8;
            this.lblReturnTime.Text = "Qaytarilma Vaxtini Secin :";
            // 
            // lblBookCount
            // 
            this.lblBookCount.AutoSize = true;
            this.lblBookCount.Location = new System.Drawing.Point(613, 128);
            this.lblBookCount.Name = "lblBookCount";
            this.lblBookCount.Size = new System.Drawing.Size(67, 13);
            this.lblBookCount.TabIndex = 8;
            this.lblBookCount.Text = "Kitab Sayisi :";
            // 
            // dtPckReturnTime
            // 
            this.dtPckReturnTime.Location = new System.Drawing.Point(686, 96);
            this.dtPckReturnTime.Name = "dtPckReturnTime";
            this.dtPckReturnTime.Size = new System.Drawing.Size(105, 20);
            this.dtPckReturnTime.TabIndex = 10;
            this.dtPckReturnTime.ValueChanged += new System.EventHandler(this.DtPckReturnTime_ValueChanged);
            // 
            // tbxBookCount
            // 
            this.tbxBookCount.Enabled = false;
            this.tbxBookCount.Location = new System.Drawing.Point(686, 125);
            this.tbxBookCount.Name = "tbxBookCount";
            this.tbxBookCount.Size = new System.Drawing.Size(105, 20);
            this.tbxBookCount.TabIndex = 11;
            this.tbxBookCount.TextChanged += new System.EventHandler(this.TbxBookCount_TextChanged);
            // 
            // btnReturnOrderNav
            // 
            this.btnReturnOrderNav.BackColor = System.Drawing.Color.LightSalmon;
            this.btnReturnOrderNav.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnOrderNav.Location = new System.Drawing.Point(616, 227);
            this.btnReturnOrderNav.Name = "btnReturnOrderNav";
            this.btnReturnOrderNav.Size = new System.Drawing.Size(175, 41);
            this.btnReturnOrderNav.TabIndex = 12;
            this.btnReturnOrderNav.Text = "SIFARIS QAYTAR";
            this.btnReturnOrderNav.UseVisualStyleBackColor = false;
            this.btnReturnOrderNav.Click += new System.EventHandler(this.BtnReturnOrderNav_Click);
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(806, 385);
            this.Controls.Add(this.btnReturnOrderNav);
            this.Controls.Add(this.tbxBookCount);
            this.Controls.Add(this.dtPckReturnTime);
            this.Controls.Add(this.tbxSearchForBookOrder);
            this.Controls.Add(this.lblBookCount);
            this.Controls.Add(this.lblReturnTime);
            this.Controls.Add(this.lblBookPriceOrderTime);
            this.Controls.Add(this.lblBookNameOrderTime);
            this.Controls.Add(this.lblOrderTimeIdentityId);
            this.Controls.Add(this.btnShowBasket);
            this.Controls.Add(this.BtnBasket);
            this.Controls.Add(this.tbxBookPriceOrderTime);
            this.Controls.Add(this.tbxBookNameOrderTime);
            this.Controls.Add(this.tbxIdentityOfCustomerOrderTime);
            this.Controls.Add(this.dgwBookSearchForOrder);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblBookNameForSearchBook);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtCustomerIdentity);
            this.Name = "OrdersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrdersForm";
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBookSearchForOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtCustomerIdentity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbxIdentityOfCustomerOrderTime;
        private System.Windows.Forms.TextBox tbxBookNameOrderTime;
        private System.Windows.Forms.TextBox tbxBookPriceOrderTime;
        private System.Windows.Forms.Button BtnBasket;
        private System.Windows.Forms.Button btnShowBasket;
        private System.Windows.Forms.Label lblOrderTimeIdentityId;
        private System.Windows.Forms.Label lblBookNameOrderTime;
        private System.Windows.Forms.Label lblBookPriceOrderTime;
        private System.Windows.Forms.Label lblBookNameForSearchBook;
        private System.Windows.Forms.DataGridView dgwBookSearchForOrder;
        private System.Windows.Forms.TextBox tbxSearchForBookOrder;
        private System.Windows.Forms.Label lblReturnTime;
        private System.Windows.Forms.Label lblBookCount;
        private System.Windows.Forms.DateTimePicker dtPckReturnTime;
        private System.Windows.Forms.TextBox tbxBookCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.Button btnReturnOrderNav;
    }
}