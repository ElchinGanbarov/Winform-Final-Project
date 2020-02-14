namespace Library_management.Forms
{
    partial class BookReturnsShowForm
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
            this.BtnTodayReturn = new System.Windows.Forms.Button();
            this.BtnTomorrowReturn = new System.Windows.Forms.Button();
            this.BtnLast = new System.Windows.Forms.Button();
            this.DgvShowReturnBook = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtReturnBook = new System.Windows.Forms.TextBox();
            this.TxtBookCount = new System.Windows.Forms.TextBox();
            this.labeldefalt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvShowReturnBook)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnTodayReturn
            // 
            this.BtnTodayReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTodayReturn.Location = new System.Drawing.Point(48, 16);
            this.BtnTodayReturn.Margin = new System.Windows.Forms.Padding(4);
            this.BtnTodayReturn.Name = "BtnTodayReturn";
            this.BtnTodayReturn.Size = new System.Drawing.Size(153, 53);
            this.BtnTodayReturn.TabIndex = 0;
            this.BtnTodayReturn.Text = "Bu gun qaytaracaqlar";
            this.BtnTodayReturn.UseVisualStyleBackColor = true;
            this.BtnTodayReturn.Click += new System.EventHandler(this.BtnTodayReturn_Click);
            // 
            // BtnTomorrowReturn
            // 
            this.BtnTomorrowReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTomorrowReturn.Location = new System.Drawing.Point(266, 16);
            this.BtnTomorrowReturn.Margin = new System.Windows.Forms.Padding(4);
            this.BtnTomorrowReturn.Name = "BtnTomorrowReturn";
            this.BtnTomorrowReturn.Size = new System.Drawing.Size(153, 53);
            this.BtnTomorrowReturn.TabIndex = 0;
            this.BtnTomorrowReturn.Text = "Sabah qaytaracaqlar";
            this.BtnTomorrowReturn.UseVisualStyleBackColor = true;
            this.BtnTomorrowReturn.Click += new System.EventHandler(this.BtnTomorrowReturn_Click);
            // 
            // BtnLast
            // 
            this.BtnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLast.Location = new System.Drawing.Point(496, 16);
            this.BtnLast.Margin = new System.Windows.Forms.Padding(4);
            this.BtnLast.Name = "BtnLast";
            this.BtnLast.Size = new System.Drawing.Size(153, 53);
            this.BtnLast.TabIndex = 0;
            this.BtnLast.Text = "Gecikenler";
            this.BtnLast.UseVisualStyleBackColor = true;
            this.BtnLast.Click += new System.EventHandler(this.BtnLast_Click);
            // 
            // DgvShowReturnBook
            // 
            this.DgvShowReturnBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvShowReturnBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvShowReturnBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column6,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7});
            this.DgvShowReturnBook.Location = new System.Drawing.Point(47, 133);
            this.DgvShowReturnBook.Margin = new System.Windows.Forms.Padding(4);
            this.DgvShowReturnBook.Name = "DgvShowReturnBook";
            this.DgvShowReturnBook.Size = new System.Drawing.Size(700, 185);
            this.DgvShowReturnBook.TabIndex = 1;
            this.DgvShowReturnBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvShowReturnBook_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Musterinin adi";
            this.Column2.Name = "Column2";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Musterinin nomresi";
            this.Column6.Name = "Column6";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Kitabin adi";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Kitab sayisi";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Son tarix";
            this.Column5.Name = "Column5";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Kimlik nomresi";
            this.Column7.Name = "Column7";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kimlik nomresi:";
            // 
            // TxtReturnBook
            // 
            this.TxtReturnBook.Location = new System.Drawing.Point(163, 99);
            this.TxtReturnBook.Name = "TxtReturnBook";
            this.TxtReturnBook.Size = new System.Drawing.Size(164, 22);
            this.TxtReturnBook.TabIndex = 5;
            this.TxtReturnBook.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // TxtBookCount
            // 
            this.TxtBookCount.Enabled = false;
            this.TxtBookCount.Location = new System.Drawing.Point(266, 343);
            this.TxtBookCount.Name = "TxtBookCount";
            this.TxtBookCount.Size = new System.Drawing.Size(60, 22);
            this.TxtBookCount.TabIndex = 3;
            // 
            // labeldefalt
            // 
            this.labeldefalt.AutoSize = true;
            this.labeldefalt.Location = new System.Drawing.Point(44, 346);
            this.labeldefalt.Name = "labeldefalt";
            this.labeldefalt.Size = new System.Drawing.Size(221, 16);
            this.labeldefalt.TabIndex = 6;
            this.labeldefalt.Text = "Qaytarmali oldugu kitab sayisi:";
            // 
            // BookReturnsShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library_management.Properties.Resources.library_final_compressed_wide_5707cc1f65ec3744f568677ba5f2a08ded734a6c_s800_c85;
            this.ClientSize = new System.Drawing.Size(782, 399);
            this.Controls.Add(this.labeldefalt);
            this.Controls.Add(this.TxtReturnBook);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtBookCount);
            this.Controls.Add(this.DgvShowReturnBook);
            this.Controls.Add(this.BtnLast);
            this.Controls.Add(this.BtnTomorrowReturn);
            this.Controls.Add(this.BtnTodayReturn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BookReturnsShowForm";
            this.Text = "BookReturnsShowForm";
            ((System.ComponentModel.ISupportInitialize)(this.DgvShowReturnBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnTodayReturn;
        private System.Windows.Forms.Button BtnTomorrowReturn;
        private System.Windows.Forms.Button BtnLast;
        private System.Windows.Forms.DataGridView DgvShowReturnBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtReturnBook;
        private System.Windows.Forms.TextBox TxtBookCount;
        private System.Windows.Forms.Label labeldefalt;
    }
}