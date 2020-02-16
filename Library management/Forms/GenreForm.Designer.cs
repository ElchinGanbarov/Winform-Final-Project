namespace Library_management.Forms
{
    partial class GenreForm
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
            this.LblGenre = new System.Windows.Forms.Label();
            this.TxtGenre = new System.Windows.Forms.TextBox();
            this.BtnSaveGenre = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblGenre
            // 
            this.LblGenre.AutoSize = true;
            this.LblGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGenre.Location = new System.Drawing.Point(23, 13);
            this.LblGenre.Name = "LblGenre";
            this.LblGenre.Size = new System.Drawing.Size(80, 16);
            this.LblGenre.TabIndex = 0;
            this.LblGenre.Text = "Janrin adi:";
            // 
            // TxtGenre
            // 
            this.TxtGenre.Location = new System.Drawing.Point(26, 42);
            this.TxtGenre.Name = "TxtGenre";
            this.TxtGenre.Size = new System.Drawing.Size(123, 20);
            this.TxtGenre.TabIndex = 1;
            // 
            // BtnSaveGenre
            // 
            this.BtnSaveGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveGenre.Location = new System.Drawing.Point(26, 79);
            this.BtnSaveGenre.Name = "BtnSaveGenre";
            this.BtnSaveGenre.Size = new System.Drawing.Size(62, 25);
            this.BtnSaveGenre.TabIndex = 2;
            this.BtnSaveGenre.Text = "Save";
            this.BtnSaveGenre.UseVisualStyleBackColor = true;
            this.BtnSaveGenre.Click += new System.EventHandler(this.BtnSaveGenre_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(94, 79);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(62, 25);
            this.BtnCancel.TabIndex = 2;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // GenreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(194, 120);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSaveGenre);
            this.Controls.Add(this.TxtGenre);
            this.Controls.Add(this.LblGenre);
            this.Name = "GenreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GenreForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblGenre;
        private System.Windows.Forms.TextBox TxtGenre;
        private System.Windows.Forms.Button BtnSaveGenre;
        private System.Windows.Forms.Button BtnCancel;
    }
}