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
    public partial class OrdersForm : Form
    {
        private CustomerDal _customerDal;
        private BookDal _bookDal;
        private OrderDal _orderDal;
        private Manager _manager;
        int id;

        public OrdersForm(Manager manager)
        {
            _manager = manager;
            _orderDal = new OrderDal();
            _customerDal = new CustomerDal();
            _bookDal = new BookDal();
            InitializeComponent();
        }
     

        private void TxtCustomerIdentity_TextChanged(object sender, EventArgs e)
        {
            string identify = TxtCustomerIdentity.Text.Trim();
            List<Customer> customers = _customerDal.GetByIdentify(identify);
            dataGridView1.Rows.Clear();
            foreach (Customer item in customers)
            {
                dataGridView1.Rows.Add(item.Id, item.Name, item.Surname, item.Phone, item.Email, item.IdentityNumber);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            CustomerCreatedForm customerCreated = new CustomerCreatedForm();

            customerCreated.ShowDialog();


        }

        private void TbxSearchForBookOrder_TextChanged(object sender, EventArgs e)
        {
            string name = tbxSearchForBookOrder.Text.Trim();
            List<Book> books = _bookDal.FilterByName(name);
            dgwBookSearchForOrder.Rows.Clear();
            foreach (Book item in books)
            {
                dgwBookSearchForOrder.Rows.Add(item.Id, item.Name, item.Price, item.Count, item.Genre.Name);
            }
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            List<Customer>customers  = _customerDal.GetAll();
            dgwBookSearchForOrder.Rows.Clear();
            foreach(Customer item in customers)
            {
                dataGridView1.Rows.Add(item.Id, item.Name, item.Surname, item.Phone, item.Email,item.IdentityNumber);
            }
            List<Book> books = _bookDal.GetAll();
            dgwBookSearchForOrder.Rows.Clear();
            foreach(Book item in books)
            {
                dgwBookSearchForOrder.Rows.Add(item.Id, item.Name, item.Price, item.Count, item.Genre.Name);
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxIdentityOfCustomerOrderTime.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            id =(int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
        }

        private void DgwBookSearchForOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxBookNameOrderTime.Text = dgwBookSearchForOrder.CurrentRow.Cells[1].Value.ToString();
            if (string.IsNullOrEmpty(tbxBookCount.Text.Trim()))
            {
                tbxBookPriceOrderTime.Text = dgwBookSearchForOrder.CurrentRow.Cells[2].Value.ToString();
            }
            else
            {
                int power = Convert.ToInt32(tbxBookCount.Text.Trim());
                double price = Convert.ToDouble(dgwBookSearchForOrder.CurrentRow.Cells[2].Value);
                double result = power * price;
                tbxBookPriceOrderTime.Text = result.ToString();
            }

        }

        private void BtnOrderFinish_Click(object sender, EventArgs e)
        {

        }

        private void BtnBasket_Click(object sender, EventArgs e)
        {
            Orders order = new Orders
            {
                BookCount = wantedCountOfBook,
                CustomerId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                DeadLine = dtPckReturnTime.Value.Date,
                GivingTime = DateTime.Now,
                ManagerId = _manager.Id,
                BookId = Convert.ToInt32(dgwBookSearchForOrder.CurrentRow.Cells[0].Value), 
            };
          
            _orderDal.Create(order);
            tbxBookCount.Text = "";
            tbxBookPriceOrderTime.Text = "";
            dtPckReturnTime.Value = DateTime.Now;
        }

        private void TbxBookCount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int BookCount = Convert.ToInt32(dgwBookSearchForOrder.CurrentRow.Cells[3].Value);
                wantedCountOfBook = Convert.ToInt32(tbxBookCount.Text.Trim());
                if (string.IsNullOrEmpty(tbxBookCount.Text.Trim()))
                {
                    tbxBookPriceOrderTime.Text = dgwBookSearchForOrder.CurrentRow.Cells[2].Value.ToString();
                    tbxBookCount.Text = "";
                    wantedCountOfBook = 1;
                }
                else
                {
                    if (BookCount < wantedCountOfBook)
                    {
                        tbxBookPriceOrderTime.Text = dgwBookSearchForOrder.CurrentRow.Cells[2].Value.ToString();
                        tbxBookCount.Text = "";
                        wantedCountOfBook = 1;
                        MessageBox.Show("Kitabxanada Qeyd Etdiyiniz Sayida Kitab Qalmayib");
                    }
                    else
                    {
                        double price = Convert.ToDouble(tbxBookPriceOrderTime.Text);
                        int pow = Convert.ToInt32(tbxBookCount.Text.Trim());
                        double result = price * wantedCountOfBook * PowBook;
                        tbxBookPriceOrderTime.Text = result.ToString();
                    }
                }
            }
            catch (Exception)
            {
                tbxBookPriceOrderTime.Text = dgwBookSearchForOrder.CurrentRow.Cells[2].Value.ToString();
                tbxBookCount.Text = "";
                wantedCountOfBook = 1;
            }
        }
        DateTime choosenDate;
        int PowBook = 1;
        int wantedCountOfBook = 1;
        private void DtPckReturnTime_ValueChanged(object sender, EventArgs e)
        {
            tbxBookCount.Text = "";
            tbxBookPriceOrderTime.Text = dgwBookSearchForOrder.CurrentRow.Cells[2].Value.ToString();
            DateTime now = DateTime.Now.Date;
            choosenDate = dtPckReturnTime.Value.Date;
            TimeSpan betweenDays = choosenDate - now;
            if (betweenDays.Days > 0)
            {
                PowBook = betweenDays.Days;
                tbxBookCount.Enabled = true;
            }
            else if (betweenDays.Days == 0)
            {
                PowBook = 1;
            }
            else
            {
                PowBook = 1;
                tbxBookCount.Enabled = false;
                MessageBox.Show("Secdiyiniz tarix yalnisdir.");
            }
        }

        private void BtnShowBasket_Click(object sender, EventArgs e)
        {
            ShowTheBasketForm showTheBasket = new ShowTheBasketForm(id);
            showTheBasket.ShowDialog();

        }
    }
}
