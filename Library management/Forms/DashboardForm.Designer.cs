namespace Library_management.Forms
{
    partial class DashboardForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnBooks = new System.Windows.Forms.Button();
            this.BtnManagers = new System.Windows.Forms.Button();
            this.BtnCustomers = new System.Windows.Forms.Button();
            this.BtnReports = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // BtnBooks
            // 
            this.BtnBooks.BackColor = System.Drawing.Color.Tan;
            this.BtnBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBooks.ForeColor = System.Drawing.Color.Navy;
            this.BtnBooks.Location = new System.Drawing.Point(12, 12);
            this.BtnBooks.Name = "BtnBooks";
            this.BtnBooks.Size = new System.Drawing.Size(87, 35);
            this.BtnBooks.TabIndex = 1;
            this.BtnBooks.Text = "Kitablar";
            this.BtnBooks.UseVisualStyleBackColor = false;
            this.BtnBooks.Click += new System.EventHandler(this.BtnBooks_Click);
            // 
            // BtnManagers
            // 
            this.BtnManagers.BackColor = System.Drawing.Color.Tan;
            this.BtnManagers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnManagers.ForeColor = System.Drawing.Color.Navy;
            this.BtnManagers.Location = new System.Drawing.Point(105, 12);
            this.BtnManagers.Name = "BtnManagers";
            this.BtnManagers.Size = new System.Drawing.Size(87, 35);
            this.BtnManagers.TabIndex = 2;
            this.BtnManagers.Text = "Idareciler";
            this.BtnManagers.UseVisualStyleBackColor = false;
            this.BtnManagers.Click += new System.EventHandler(this.BtnManagers_Click);
            // 
            // BtnCustomers
            // 
            this.BtnCustomers.BackColor = System.Drawing.Color.Tan;
            this.BtnCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCustomers.ForeColor = System.Drawing.Color.Navy;
            this.BtnCustomers.Location = new System.Drawing.Point(198, 12);
            this.BtnCustomers.Name = "BtnCustomers";
            this.BtnCustomers.Size = new System.Drawing.Size(83, 35);
            this.BtnCustomers.TabIndex = 3;
            this.BtnCustomers.Text = "Musteriler";
            this.BtnCustomers.UseVisualStyleBackColor = false;
            this.BtnCustomers.Click += new System.EventHandler(this.BtnCustomers_Click);
            // 
            // BtnReports
            // 
            this.BtnReports.BackColor = System.Drawing.Color.Tan;
            this.BtnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnReports.Location = new System.Drawing.Point(287, 12);
            this.BtnReports.Name = "BtnReports";
            this.BtnReports.Size = new System.Drawing.Size(86, 35);
            this.BtnReports.TabIndex = 4;
            this.BtnReports.Text = "Hesabatlar";
            this.BtnReports.UseVisualStyleBackColor = false;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 398);
            this.Controls.Add(this.BtnReports);
            this.Controls.Add(this.BtnCustomers);
            this.Controls.Add(this.BtnManagers);
            this.Controls.Add(this.BtnBooks);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnBooks;
        private System.Windows.Forms.Button BtnManagers;
        private System.Windows.Forms.Button BtnCustomers;
        private System.Windows.Forms.Button BtnReports;
    }
}