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
    public partial class BookReturnsShowForm : Form
    {
        private OrderDal _orderDal;
        private Orders orders;
        public BookReturnsShowForm()
        {
            _orderDal = new OrderDal();
            InitializeComponent();
        }

        private void BtnTodayReturn_Click(object sender, EventArgs e)
        {
            List<Orders> orders = _orderDal.GetAll();
            DgvShowReturnBook.Rows.Clear();
            foreach (Orders item in orders)
            {
                if (item.DeadLine.Value == DateTime.Now.Date && item.Status==false)
                {
                    DgvShowReturnBook.Rows.Add(item.Id, item.Customers.Name,item.Customers.Phone,item.Books.Name, item.BookCount, item.DeadLine,item.Customers.IdentityNumber);
                }
            }
            labeldefalt.Show();
            TxtBookCount.Show();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string identify = TxtReturnBook.Text.Trim();
                List<Orders> orders = _orderDal.GetByIdentify(identify);
                DgvShowReturnBook.Rows.Clear();
                foreach (Orders item in orders)
                {
                    if (item.DeadLine.Value == DateTime.Now.Date && item.Status == false)
                    {
                        DgvShowReturnBook.Rows.Add(item.Id, item.Customers.Name, item.Customers.Phone, item.Books.Name, item.BookCount, item.DeadLine, item.Customers.IdentityNumber);
                    }
                };
                int a = (int)DgvShowReturnBook.CurrentRow.Cells[4].Value;
            }
            catch { }
            
            
        }

        private void BtnTomorrowReturn_Click(object sender, EventArgs e)
        {
            List<Orders> orders = _orderDal.GetAll();
            DgvShowReturnBook.Rows.Clear();
            foreach (Orders item in orders)
            {
                if (item.DeadLine.Value == DateTime.Now.Date.AddDays(1) && item.Status == false)
                {
                    DgvShowReturnBook.Rows.Add(item.Id, item.Customers.Name, item.Customers.Phone, item.Books.Name, item.BookCount, item.DeadLine, item.Customers.IdentityNumber);
                }
            }
            TxtBookCount.Text = "";
            labeldefalt.Hide();
            TxtBookCount.Hide();
        }

        private void BtnLast_Click(object sender, EventArgs e)
        {
            List<Orders> orders = _orderDal.GetAll();
            DgvShowReturnBook.Rows.Clear();
            foreach (Orders item in orders)
            {
                if (item.DeadLine.Value < DateTime.Now.Date && item.Status == false)
                {
                    DgvShowReturnBook.Rows.Add(item.Id, item.Customers.Name, item.Customers.Phone, item.Books.Name, item.BookCount, item.DeadLine, item.Customers.IdentityNumber);
                }
            }
            TxtBookCount.Text = "";
            labeldefalt.Hide();
            TxtBookCount.Hide();
        }
        int a;
        private void DgvShowReturnBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                List<Orders> orders = _orderDal.GetByIdentify(Convert.ToString(DgvShowReturnBook.CurrentRow.Cells[6].Value));
                foreach (Orders item in orders)
                {
                    if (item.DeadLine.Value == DateTime.Now.Date && item.Status == false)
                    {
                        a += Convert.ToInt32(item.BookCount);
                        TxtBookCount.Text = a.ToString();
                    }
                }
                a = 0;
            }
            catch { }
        }

    }
}
