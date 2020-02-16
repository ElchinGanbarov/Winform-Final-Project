namespace Library_management.Forms
{
    partial class CustomerForm
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
            this.DgvCustomerShow = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblSelected = new System.Windows.Forms.Label();
            this.LblSelectedName = new System.Windows.Forms.Label();
            this.BtnCreatCustomer = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDeleted = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCustomerShow)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvCustomerShow
            // 
            this.DgvCustomerShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvCustomerShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCustomerShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.DgvCustomerShow.Location = new System.Drawing.Point(28, 51);
            this.DgvCustomerShow.Name = "DgvCustomerShow";
            this.DgvCustomerShow.Size = new System.Drawing.Size(552, 150);
            this.DgvCustomerShow.TabIndex = 0;
            this.DgvCustomerShow.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCustomerShow_CellClick);
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
            this.Column4.HeaderText = "Email";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Phone";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Kimlik Nomresi";
            this.Column6.Name = "Column6";
            // 
            // LblSelected
            // 
            this.LblSelected.AutoSize = true;
            this.LblSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSelected.Location = new System.Drawing.Point(25, 32);
            this.LblSelected.Name = "LblSelected";
            this.LblSelected.Size = new System.Drawing.Size(125, 16);
            this.LblSelected.TabIndex = 1;
            this.LblSelected.Text = "Secilmis musteri:";
            this.LblSelected.Visible = false;
            // 
            // LblSelectedName
            // 
            this.LblSelectedName.AutoSize = true;
            this.LblSelectedName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSelectedName.Location = new System.Drawing.Point(156, 32);
            this.LblSelectedName.Name = "LblSelectedName";
            this.LblSelectedName.Size = new System.Drawing.Size(0, 16);
            this.LblSelectedName.TabIndex = 2;
            this.LblSelectedName.Visible = false;
            // 
            // BtnCreatCustomer
            // 
            this.BtnCreatCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreatCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnCreatCustomer.Location = new System.Drawing.Point(492, 12);
            this.BtnCreatCustomer.Name = "BtnCreatCustomer";
            this.BtnCreatCustomer.Size = new System.Drawing.Size(88, 38);
            this.BtnCreatCustomer.TabIndex = 3;
            this.BtnCreatCustomer.Text = "Musteri yarat";
            this.BtnCreatCustomer.UseVisualStyleBackColor = true;
            this.BtnCreatCustomer.Click += new System.EventHandler(this.BtnCreatCustomer_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.Location = new System.Drawing.Point(411, 12);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(75, 38);
            this.BtnUpdate.TabIndex = 4;
            this.BtnUpdate.Text = "Yenile";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Visible = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDeleted
            // 
            this.BtnDeleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleted.Location = new System.Drawing.Point(330, 12);
            this.BtnDeleted.Name = "BtnDeleted";
            this.BtnDeleted.Size = new System.Drawing.Size(75, 38);
            this.BtnDeleted.TabIndex = 5;
            this.BtnDeleted.Text = "Sil";
            this.BtnDeleted.UseVisualStyleBackColor = true;
            this.BtnDeleted.Visible = false;
            this.BtnDeleted.Click += new System.EventHandler(this.BtnDeleted_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::Library_management.Properties.Resources.png_customer_268x275_increase_customer_satisfaction_268;
            this.ClientSize = new System.Drawing.Size(638, 265);
            this.Controls.Add(this.BtnDeleted);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnCreatCustomer);
            this.Controls.Add(this.LblSelectedName);
            this.Controls.Add(this.LblSelected);
            this.Controls.Add(this.DgvCustomerShow);
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerForm";
            ((System.ComponentModel.ISupportInitialize)(this.DgvCustomerShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvCustomerShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label LblSelected;
        private System.Windows.Forms.Label LblSelectedName;
        private System.Windows.Forms.Button BtnCreatCustomer;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDeleted;
    }
}