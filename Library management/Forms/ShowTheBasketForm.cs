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
    public partial class ShowTheBasketForm : Form
    {
        private OrderDal _orderDal;
        private int _id;
        private Orders orders;
        public ShowTheBasketForm(int id)
        {
            _id = id;
            _orderDal = new OrderDal();
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders
            {
                Id = Convert.ToInt32(dgwShowBasketOrder.CurrentRow.Cells[0].Value)
            };
            _orderDal.Delete(orders);
            LoadAllDataForTheBasket();
        }

        private void ShowTheBasketForm_Load(object sender, EventArgs e)
        {
            LoadAllDataForTheBasket();
        }

        private void LoadAllDataForTheBasket()
        {
            List<Orders> orders = _orderDal.GetForBasket(_id);
            dgwShowBasketOrder.Rows.Clear();
            foreach (Orders item in orders)
            {
                dgwShowBasketOrder.Rows.Add(item.Id, item.Books.Name, item.BookCount, item.Books.Price, item.Customers.Name, item.Customers.IdentityNumber, item.GivingTime, item.DeadLine, item.Managers.Name);
            }
        }

        private void DgwShowBasketOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDeleteFromBasketShow.Enabled = true;
            btnUpdateShowBasketForm.Enabled = true;
            textBox1.Text = dgwShowBasketOrder.CurrentRow.Cells[2].Value.ToString();

        }

        //
        private void BtnUpdateShowBasketForm_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgwShowBasketOrder.CurrentRow.Cells[0].Value);
            orders = _orderDal.GetById(id);
            orders.BookCount = Convert.ToInt32(textBox1.Text);
            _orderDal.Update(orders);
            LoadAllDataForTheBasket();
        }
    }
}
