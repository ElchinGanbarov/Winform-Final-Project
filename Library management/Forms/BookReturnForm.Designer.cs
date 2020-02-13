namespace Library_management.Forms
{
    partial class BookReturnForm
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
            this.TxtOrderCustomer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgwShowBasketOrder = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtpReturnValue = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtLastMoney = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnOrderFinish = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwShowBasketOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtOrderCustomer
            // 
            this.TxtOrderCustomer.Location = new System.Drawing.Point(182, 15);
            this.TxtOrderCustomer.Name = "TxtOrderCustomer";
            this.TxtOrderCustomer.Size = new System.Drawing.Size(142, 20);
            this.TxtOrderCustomer.TabIndex = 0;
            this.TxtOrderCustomer.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Musterinin Kimlik Seriyasi :";
            // 
            // dgwShowBasketOrder
            // 
            this.dgwShowBasketOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwShowBasketOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgwShowBasketOrder.Location = new System.Drawing.Point(-17, 41);
            this.dgwShowBasketOrder.Name = "dgwShowBasketOrder";
            this.dgwShowBasketOrder.Size = new System.Drawing.Size(864, 150);
            this.dgwShowBasketOrder.TabIndex = 2;
            this.dgwShowBasketOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgwShowBasketOrder_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Kitabin adi";
            this.Column2.Name = "Column2";
            this.Column2.Width = 106;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Kitabin sayisi";
            this.Column3.Name = "Column3";
            this.Column3.Width = 105;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Kitabin qiymeti";
            this.Column4.Name = "Column4";
            this.Column4.Width = 106;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Musterinin adi";
            this.Column5.Name = "Column5";
            this.Column5.Width = 106;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Musterinin kimlik nomresi";
            this.Column6.Name = "Column6";
            this.Column6.Width = 105;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Sifaris olunan tarix";
            this.Column7.Name = "Column7";
            this.Column7.Width = 106;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Son tarix";
            this.Column8.Name = "Column8";
            this.Column8.Width = 107;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Istifadeci adi";
            this.Column9.Name = "Column9";
            this.Column9.Width = 106;
            // 
            // DtpReturnValue
            // 
            this.DtpReturnValue.Location = new System.Drawing.Point(471, 15);
            this.DtpReturnValue.Name = "DtpReturnValue";
            this.DtpReturnValue.Size = new System.Drawing.Size(200, 20);
            this.DtpReturnValue.TabIndex = 3;
            this.DtpReturnValue.ValueChanged += new System.EventHandler(this.DtpReturnValue_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(340, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Qaytarilma Vaxti:";
            // 
            // TxtLastMoney
            // 
            this.TxtLastMoney.Enabled = false;
            this.TxtLastMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLastMoney.Location = new System.Drawing.Point(182, 207);
            this.TxtLastMoney.Name = "TxtLastMoney";
            this.TxtLastMoney.Size = new System.Drawing.Size(100, 20);
            this.TxtLastMoney.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Odenilecek Mebleg:";
            // 
            // BtnOrderFinish
            // 
            this.BtnOrderFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOrderFinish.Location = new System.Drawing.Point(687, 12);
            this.BtnOrderFinish.Name = "BtnOrderFinish";
            this.BtnOrderFinish.Size = new System.Drawing.Size(139, 26);
            this.BtnOrderFinish.TabIndex = 7;
            this.BtnOrderFinish.Text = "Sifarisi Bagla";
            this.BtnOrderFinish.UseVisualStyleBackColor = true;
            this.BtnOrderFinish.Click += new System.EventHandler(this.BtnOrderFinish_Click);
            // 
            // BookReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 313);
            this.Controls.Add(this.BtnOrderFinish);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtLastMoney);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DtpReturnValue);
            this.Controls.Add(this.dgwShowBasketOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtOrderCustomer);
            this.Name = "BookReturnForm";
            this.Text = "BookReturnForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgwShowBasketOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtOrderCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgwShowBasketOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DateTimePicker DtpReturnValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtLastMoney;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnOrderFinish;
    }
}