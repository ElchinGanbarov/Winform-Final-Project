namespace Library_management.Forms
{
    partial class BookForm
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
            this.DgvAddBooks = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnCreatBook = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.SelectedLabel = new System.Windows.Forms.Label();
            this.SelectedName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAddBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvAddBooks
            // 
            this.DgvAddBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvAddBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAddBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.DgvAddBooks.Location = new System.Drawing.Point(12, 67);
            this.DgvAddBooks.Name = "DgvAddBooks";
            this.DgvAddBooks.Size = new System.Drawing.Size(580, 170);
            this.DgvAddBooks.TabIndex = 0;
            this.DgvAddBooks.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_RowHeaderMouseClick);
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
            this.Column3.HeaderText = "Qiymeti";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Sayi";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Janri";
            this.Column5.Name = "Column5";
            // 
            // BtnCreatBook
            // 
            this.BtnCreatBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreatBook.Location = new System.Drawing.Point(506, 37);
            this.BtnCreatBook.Name = "BtnCreatBook";
            this.BtnCreatBook.Size = new System.Drawing.Size(86, 27);
            this.BtnCreatBook.TabIndex = 1;
            this.BtnCreatBook.Text = "Kitab yarat";
            this.BtnCreatBook.UseVisualStyleBackColor = true;
            this.BtnCreatBook.Click += new System.EventHandler(this.BtnCreatBook_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.Location = new System.Drawing.Point(323, 37);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(75, 27);
            this.BtnUpdate.TabIndex = 2;
            this.BtnUpdate.Text = "Yenile";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Visible = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Location = new System.Drawing.Point(416, 37);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 27);
            this.BtnDelete.TabIndex = 3;
            this.BtnDelete.Text = "Sil";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Visible = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // SelectedLabel
            // 
            this.SelectedLabel.AutoSize = true;
            this.SelectedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SelectedLabel.Location = new System.Drawing.Point(12, 44);
            this.SelectedLabel.Name = "SelectedLabel";
            this.SelectedLabel.Size = new System.Drawing.Size(109, 16);
            this.SelectedLabel.TabIndex = 4;
            this.SelectedLabel.Text = "Secilmis kitab:";
            this.SelectedLabel.Visible = false;
            // 
            // SelectedName
            // 
            this.SelectedName.AutoSize = true;
            this.SelectedName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedName.ForeColor = System.Drawing.Color.Maroon;
            this.SelectedName.Location = new System.Drawing.Point(127, 44);
            this.SelectedName.Name = "SelectedName";
            this.SelectedName.Size = new System.Drawing.Size(0, 16);
            this.SelectedName.TabIndex = 5;
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.BackgroundImage = global::Library_management.Properties.Resources.books1;
            this.ClientSize = new System.Drawing.Size(773, 334);
            this.Controls.Add(this.SelectedName);
            this.Controls.Add(this.SelectedLabel);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnCreatBook);
            this.Controls.Add(this.DgvAddBooks);
            this.Name = "BookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookForm";
            this.Load += new System.EventHandler(this.BookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAddBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvAddBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button BtnCreatBook;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Label SelectedLabel;
        private System.Windows.Forms.Label SelectedName;
    }
}