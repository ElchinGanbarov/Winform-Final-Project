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

namespace Library_management.Forms
{
    public partial class ReportForm : Form
    {
        private OrderDal _orderDal;
        public ReportForm()
        {
            _orderDal = new OrderDal();
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DateTime endtime = DgvEndTime.Value.Date;
            DateTime starttime = DgvStartTime.Value.Date;
            List<Orders> orders = _orderDal.GetAll();
            dgwReportOrder.Rows.Clear();
            foreach(Orders item in orders)
            {
            
                if (item.Status == true && starttime < item.ReturnTime.Value && item.ReturnTime.Value < endtime )
                {
                    
                    dgwReportOrder.Rows.Add(item.Id, item.Books.Name, item.BookCount, item.Books.Price, item.Customers.Name, item.Customers.IdentityNumber, item.Managers.Name, item.ReturnTime);
                }
            }
        }
    }
}
