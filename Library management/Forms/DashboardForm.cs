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
    public partial class DashboardForm : Form
    {
        public Manager manager;
      
        public DashboardForm(Manager man)
        {
            manager = man;
            InitializeComponent();
        }


        #region Button Click Events

        //Books Form Open//
        private void BtnBooks_Click(object sender, EventArgs e)
        {
            BookForm bookForm = new BookForm();
            bookForm.ShowDialog();
        }

        //Managers Form Open//
        private void BtnManagers_Click(object sender, EventArgs e)
        {
            if (manager.Level == ManagerLevel.Admin)
            {
                ManagerForm managerForm = new ManagerForm();
                managerForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sadece Admin daxil ola biler!");
            }       
        }

        //Customers Form Open//
        private void BtnCustomers_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.ShowDialog();
        }

        //Order Form Open//
        private void Button1_Click(object sender, EventArgs e)
        {
            OrdersForm orderForm = new OrdersForm(manager);
            orderForm.ShowDialog();
        }

        #endregion

        private void ReturnsBooksShow_Click(object sender, EventArgs e)
        {
            BookReturnsShowForm bookReturnsShow = new BookReturnsShowForm();

            bookReturnsShow.ShowDialog();
        }

        private void BtnReports_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm();

            reportForm.ShowDialog();
        }
    }
}
