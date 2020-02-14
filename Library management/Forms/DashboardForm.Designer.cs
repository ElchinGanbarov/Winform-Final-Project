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
            this.BtnBooks = new System.Windows.Forms.Button();
            this.BtnManagers = new System.Windows.Forms.Button();
            this.BtnCustomers = new System.Windows.Forms.Button();
            this.BtnReports = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ReturnsBooksShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnBooks
            // 
            this.BtnBooks.BackColor = System.Drawing.Color.Tan;
            this.BtnBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBooks.ForeColor = System.Drawing.Color.Navy;
            this.BtnBooks.Location = new System.Drawing.Point(12, 73);
            this.BtnBooks.Name = "BtnBooks";
            this.BtnBooks.Size = new System.Drawing.Size(118, 45);
            this.BtnBooks.TabIndex = 1;
            this.BtnBooks.Text = "Kitablar";
            this.BtnBooks.UseVisualStyleBackColor = false;
            this.BtnBooks.Click += new System.EventHandler(this.BtnBooks_Click);
            // 
            // BtnManagers
            // 
            this.BtnManagers.BackColor = System.Drawing.Color.Tan;
            this.BtnManagers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnManagers.ForeColor = System.Drawing.Color.Navy;
            this.BtnManagers.Location = new System.Drawing.Point(12, 12);
            this.BtnManagers.Name = "BtnManagers";
            this.BtnManagers.Size = new System.Drawing.Size(118, 44);
            this.BtnManagers.TabIndex = 2;
            this.BtnManagers.Text = "Idareciler";
            this.BtnManagers.UseVisualStyleBackColor = false;
            this.BtnManagers.Click += new System.EventHandler(this.BtnManagers_Click);
            // 
            // BtnCustomers
            // 
            this.BtnCustomers.BackColor = System.Drawing.Color.Tan;
            this.BtnCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCustomers.ForeColor = System.Drawing.Color.Navy;
            this.BtnCustomers.Location = new System.Drawing.Point(12, 133);
            this.BtnCustomers.Name = "BtnCustomers";
            this.BtnCustomers.Size = new System.Drawing.Size(118, 42);
            this.BtnCustomers.TabIndex = 3;
            this.BtnCustomers.Text = "Musteriler";
            this.BtnCustomers.UseVisualStyleBackColor = false;
            this.BtnCustomers.Click += new System.EventHandler(this.BtnCustomers_Click);
            // 
            // BtnReports
            // 
            this.BtnReports.BackColor = System.Drawing.Color.Tan;
            this.BtnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnReports.Location = new System.Drawing.Point(12, 303);
            this.BtnReports.Name = "BtnReports";
            this.BtnReports.Size = new System.Drawing.Size(118, 46);
            this.BtnReports.TabIndex = 4;
            this.BtnReports.Text = "Hesabatlar";
            this.BtnReports.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tan;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(13, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "Sifarisler";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ReturnsBooksShow
            // 
            this.ReturnsBooksShow.BackColor = System.Drawing.Color.Tan;
            this.ReturnsBooksShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnsBooksShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ReturnsBooksShow.Location = new System.Drawing.Point(12, 231);
            this.ReturnsBooksShow.Name = "ReturnsBooksShow";
            this.ReturnsBooksShow.Size = new System.Drawing.Size(118, 66);
            this.ReturnsBooksShow.TabIndex = 4;
            this.ReturnsBooksShow.Text = "Kitab qaytaranlari izleme";
            this.ReturnsBooksShow.UseVisualStyleBackColor = false;
            this.ReturnsBooksShow.Click += new System.EventHandler(this.ReturnsBooksShow_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library_management.Properties.Resources.library_100616524_large;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(652, 357);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ReturnsBooksShow);
            this.Controls.Add(this.BtnReports);
            this.Controls.Add(this.BtnCustomers);
            this.Controls.Add(this.BtnManagers);
            this.Controls.Add(this.BtnBooks);
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnBooks;
        private System.Windows.Forms.Button BtnManagers;
        private System.Windows.Forms.Button BtnCustomers;
        private System.Windows.Forms.Button BtnReports;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ReturnsBooksShow;
    }
}