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
    public partial class BookReturnForm : Form
    {
        public event EventHandler BookAdd;
        private OrderDal _orderDal;
        private Orders _order;
        private int _id;
        private decimal _bookPrice;
        private int _bookCount;
        private Book _book;
        private BookDal _bookDal;
        public BookReturnForm()
        {
            _bookDal = new BookDal();
            _orderDal = new OrderDal();
            InitializeComponent();
            FillDataOrder();
        }

        //Order DatagridwievAdd//
        private void FillDataOrder()
        {
           List<Orders> orders = _orderDal.GetForAllReturnOrders();
            dgwShowBasketOrder.Rows.Clear();
            foreach (Orders item in orders)
            {
                dgwShowBasketOrder.Rows.Add(item.Id, item.Books.Name, item.BookCount, item.Books.Price, item.Customers.Name, item.Customers.IdentityNumber, item.GivingTime, item.DeadLine, item.Managers.Name);
            }
        }

        private void DgwShowBasketOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _bookCount = Convert.ToInt32(dgwShowBasketOrder.CurrentRow.Cells[2].Value);
                _id = (int)dgwShowBasketOrder.Rows[e.RowIndex].Cells[0].Value;
                _order = _orderDal.GetById(_id);
                //MessageBox.Show(_order.BookId.ToString());
                _book = _bookDal.GetById(_order.BookId);
                _bookPrice = Convert.ToDecimal(dgwShowBasketOrder.CurrentRow.Cells[3].Value);
                DateTime deadline = _order.DeadLine.Value.Date;
                DateTime returndate = DtpReturnValue.Value.Date;

                TimeSpan diff1 = returndate - deadline;
                int diffdays = diff1.Days;
                decimal lastmoney;
                decimal bookprice = Convert.ToDecimal(_bookPrice);


                if (diffdays > 0)
                {
                    lastmoney = ((bookprice / 2) / 100) * diffdays * _bookCount;
                    _order.LastMoney = lastmoney;
                }
                else
                {
                    _order.LastMoney = _bookPrice * _bookCount;
                }

                _order.ReturnTime = deadline;
                _order.Status = true;
                TxtLastMoney.Text = _order.LastMoney.ToString();
            }
            catch { }
           

        }
        //The Customer Find for Identify number//
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            string identify = TxtOrderCustomer.Text.Trim();
            List<Orders> orders = _orderDal.GetByIdentify(identify);
            dgwShowBasketOrder.Rows.Clear();
            foreach (Orders item in orders)
            {
                dgwShowBasketOrder.Rows.Add(item.Id, item.Books.Name, item.BookCount, item.Books.Price, item.Customers.Name, item.Customers.IdentityNumber, item.GivingTime, item.DeadLine, item.Managers.Name);
            };

        }
        //Order-Closed//
        private void BtnOrderFinish_Click(object sender, EventArgs e)
        {
            _orderDal.Update(_order);
            TxtLastMoney.Text = "";
            _book.Count += _bookCount;
            _bookDal.Update(_book);
            BookAdd?.Invoke(_book, new EventArgs());
            FillDataOrder();
        }

        //Date time picker change Events-Count the last money//
        private void DtpReturnValue_ValueChanged(object sender, EventArgs e)
        {
            DateTime deadline = _order.DeadLine.Value.Date;
            DateTime returndate = DtpReturnValue.Value.Date;

            TimeSpan diff1 = returndate - deadline;
            int diffdays = diff1.Days;
            decimal lastmoney;
            decimal bookprice = Convert.ToDecimal(_bookPrice);


            if (diffdays>0)
            {
                lastmoney = bookprice * _bookCount + (((bookprice / 2) / 100) * diffdays);
                _order.LastMoney = lastmoney;
            }
            else if (diffdays < 0)
            {
                MessageBox.Show("Secdiyiniz tarix yanlisdir");
            }
            else
            {
                _order.LastMoney = _bookPrice * _bookCount;
            }
            TxtLastMoney.Text = _order.LastMoney.ToString();
        }
    }
}
