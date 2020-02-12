namespace Library_management.Forms
{
    partial class ShowTheBasketForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteFromBasketShow = new System.Windows.Forms.Button();
            this.btnUpdateShowBasketForm = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwShowBasketOrder)).BeginInit();
            this.SuspendLayout();
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
            this.dgwShowBasketOrder.Location = new System.Drawing.Point(12, 45);
            this.dgwShowBasketOrder.Name = "dgwShowBasketOrder";
            this.dgwShowBasketOrder.Size = new System.Drawing.Size(890, 150);
            this.dgwShowBasketOrder.TabIndex = 0;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sifaris Olunanlar Listi :";
            // 
            // btnDeleteFromBasketShow
            // 
            this.btnDeleteFromBasketShow.Enabled = false;
            this.btnDeleteFromBasketShow.Location = new System.Drawing.Point(908, 45);
            this.btnDeleteFromBasketShow.Name = "btnDeleteFromBasketShow";
            this.btnDeleteFromBasketShow.Size = new System.Drawing.Size(75, 68);
            this.btnDeleteFromBasketShow.TabIndex = 2;
            this.btnDeleteFromBasketShow.Text = "Sil";
            this.btnDeleteFromBasketShow.UseVisualStyleBackColor = true;
            this.btnDeleteFromBasketShow.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnUpdateShowBasketForm
            // 
            this.btnUpdateShowBasketForm.Enabled = false;
            this.btnUpdateShowBasketForm.Location = new System.Drawing.Point(908, 120);
            this.btnUpdateShowBasketForm.Name = "btnUpdateShowBasketForm";
            this.btnUpdateShowBasketForm.Size = new System.Drawing.Size(75, 75);
            this.btnUpdateShowBasketForm.TabIndex = 3;
            this.btnUpdateShowBasketForm.Text = "Yenile";
            this.btnUpdateShowBasketForm.UseVisualStyleBackColor = true;
            this.btnUpdateShowBasketForm.Click += new System.EventHandler(this.BtnUpdateShowBasketForm_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(218, 235);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Secilenin Sayisini Deyisdir :";
            // 
            // ShowTheBasketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 333);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnUpdateShowBasketForm);
            this.Controls.Add(this.btnDeleteFromBasketShow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwShowBasketOrder);
            this.Name = "ShowTheBasketForm";
            this.Text = "Sifaris Sebeti";
            this.Load += new System.EventHandler(this.ShowTheBasketForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwShowBasketOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwShowBasketOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteFromBasketShow;
        private System.Windows.Forms.Button btnUpdateShowBasketForm;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}