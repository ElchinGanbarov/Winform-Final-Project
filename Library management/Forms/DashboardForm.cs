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

        private void BtnBooks_Click(object sender, EventArgs e)
        {
            BookForm bookForm = new BookForm();

            bookForm.ShowDialog();
        }

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

        private void BtnCustomers_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();

            customerForm.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OrdersForm orderForm = new OrdersForm(manager);

            orderForm.ShowDialog();
        }
    }
}
