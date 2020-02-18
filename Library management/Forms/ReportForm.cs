using Library_management.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using System.IO;

namespace Library_management.Forms
{
    public partial class ReportForm : Form
    {
        private OrderDal _orderDal;
        private List<Orders> orders;
        private  decimal a;
        private string path;
        public ReportForm()
        {
            _orderDal = new OrderDal();
            InitializeComponent();
        }

        //Show the Report return book//
        private void Button1_Click(object sender, EventArgs e)
        {
            DateTime endtime = DgvEndTime.Value.Date;
            DateTime starttime = DgvStartTime.Value.Date;
            orders = _orderDal.GetAll();
            dgwReportOrder.Rows.Clear();
            foreach(Orders item in orders)
            {
            
                if (item.Status == true && starttime < item.ReturnTime.Value && item.ReturnTime.Value < endtime )
                {
                    
                    dgwReportOrder.Rows.Add(item.Id, item.Books.Name, item.BookCount, item.LastMoney, item.Customers.Name, item.Customers.IdentityNumber, item.Managers.Name, item.ReturnTime);
                    a += Convert.ToDecimal(item.LastMoney);
                   
                }
            }
            LblReturnCount.Text = a.ToString();
            BtnExcelExport.Show();
            BtnLocation.Show();

        }

        //Excel Export//
        private void BtnExcelExport_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgwReportOrder.Rows.Count > 0)
                {
                    var workbook = new XLWorkbook();
                    var worksheet = workbook.Worksheets.Add("Sample Sheet");
                    for (int i = 1; i < dgwReportOrder.Columns.Count; i++)
                    {
                        worksheet.Cell(1, i).SetValue(dgwReportOrder.Columns[i].HeaderText);
                        worksheet.Column(i).Width = 20;

                    }
                    for (int i = 0; i < dgwReportOrder.Rows.Count - 1; i++)
                    {
                        for (int j = 1; j < dgwReportOrder.Columns.Count; j++)
                        {
                            worksheet.Cell(i + 2, j).SetValue(dgwReportOrder.Rows[i].Cells[j].Value.ToString());

                        }
                    }
                    workbook.SaveAs(path);
                    MessageBox.Show("Cedvel Excele Export edildi");
                }
            }
            catch
            {
                MessageBox.Show("Zehmet olmasa fayili baglayin");
                MessageBox.Show("@"+path);
            }
        }
        //End Time DatePicker Value Change//
        private void DgvEndTime_ValueChanged(object sender, EventArgs e)
        {
            a = 0;
        }
        //Start Time DatePicker Value Change//
        private void DgvStartTime_ValueChanged(object sender, EventArgs e)
        {
            a = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                path = folderBrowserDialog1.SelectedPath.ToString()+ @"\Excel.xlsx";
            }
            BtnExcelExport.Enabled = true;
        }
    }
}
