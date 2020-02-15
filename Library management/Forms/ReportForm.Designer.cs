namespace Library_management.Forms
{
    partial class ReportForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.DgvStartTime = new System.Windows.Forms.DateTimePicker();
            this.DgvEndTime = new System.Windows.Forms.DateTimePicker();
            this.dgwReportOrder = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnExcelExport = new System.Windows.Forms.Button();
            this.LblCount = new System.Windows.Forms.Label();
            this.LblReturnCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwReportOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baslama vaxdi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bitme vaxdi:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 43);
            this.button1.TabIndex = 3;
            this.button1.Text = "Sifarislerin listesi:";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // DgvStartTime
            // 
            this.DgvStartTime.Location = new System.Drawing.Point(133, 9);
            this.DgvStartTime.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.DgvStartTime.Name = "DgvStartTime";
            this.DgvStartTime.Size = new System.Drawing.Size(126, 20);
            this.DgvStartTime.TabIndex = 4;
            this.DgvStartTime.ValueChanged += new System.EventHandler(this.DgvStartTime_ValueChanged);
            // 
            // DgvEndTime
            // 
            this.DgvEndTime.Location = new System.Drawing.Point(133, 38);
            this.DgvEndTime.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.DgvEndTime.Name = "DgvEndTime";
            this.DgvEndTime.Size = new System.Drawing.Size(126, 20);
            this.DgvEndTime.TabIndex = 5;
            this.DgvEndTime.ValueChanged += new System.EventHandler(this.DgvEndTime_ValueChanged);
            // 
            // dgwReportOrder
            // 
            this.dgwReportOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwReportOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwReportOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column9,
            this.Column7});
            this.dgwReportOrder.Location = new System.Drawing.Point(15, 116);
            this.dgwReportOrder.Name = "dgwReportOrder";
            this.dgwReportOrder.Size = new System.Drawing.Size(864, 201);
            this.dgwReportOrder.TabIndex = 6;
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
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Kitabin sayisi";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Odenilen Mebleg";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Musterinin adi";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Musterinin kimlik nomresi";
            this.Column6.Name = "Column6";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Istifadeci adi";
            this.Column9.Name = "Column9";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Son tarix:";
            this.Column7.Name = "Column7";
            // 
            // BtnExcelExport
            // 
            this.BtnExcelExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcelExport.Location = new System.Drawing.Point(154, 67);
            this.BtnExcelExport.Name = "BtnExcelExport";
            this.BtnExcelExport.Size = new System.Drawing.Size(92, 43);
            this.BtnExcelExport.TabIndex = 7;
            this.BtnExcelExport.Text = "Excele export et";
            this.BtnExcelExport.UseVisualStyleBackColor = true;
            this.BtnExcelExport.Visible = false;
            this.BtnExcelExport.Click += new System.EventHandler(this.BtnExcelExport_Click);
            // 
            // LblCount
            // 
            this.LblCount.AutoSize = true;
            this.LblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCount.Location = new System.Drawing.Point(15, 333);
            this.LblCount.Name = "LblCount";
            this.LblCount.Size = new System.Drawing.Size(115, 16);
            this.LblCount.TabIndex = 8;
            this.LblCount.Text = "Umumi mebleg:";
            // 
            // LblReturnCount
            // 
            this.LblReturnCount.AutoSize = true;
            this.LblReturnCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblReturnCount.Location = new System.Drawing.Point(130, 333);
            this.LblReturnCount.Name = "LblReturnCount";
            this.LblReturnCount.Size = new System.Drawing.Size(0, 16);
            this.LblReturnCount.TabIndex = 9;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library_management.Properties.Resources.report;
            this.ClientSize = new System.Drawing.Size(1147, 438);
            this.Controls.Add(this.LblReturnCount);
            this.Controls.Add(this.LblCount);
            this.Controls.Add(this.BtnExcelExport);
            this.Controls.Add(this.dgwReportOrder);
            this.Controls.Add(this.DgvEndTime);
            this.Controls.Add(this.DgvStartTime);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgwReportOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker DgvStartTime;
        private System.Windows.Forms.DateTimePicker DgvEndTime;
        private System.Windows.Forms.DataGridView dgwReportOrder;
        private System.Windows.Forms.Button BtnExcelExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label LblCount;
        private System.Windows.Forms.Label LblReturnCount;
    }
}