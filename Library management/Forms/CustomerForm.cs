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
    public partial class CustomerForm : Form
    {
        private CustomerDal _customerDal;
        private int id;
        private Customer _customer;
        public CustomerForm()
        {
            _customerDal = new CustomerDal();
            InitializeComponent();
            FillDataCustomer();
        }

        #region FillMethods
        //FillMethods//
        private void FillDataCustomer()
        {
            List<Customer> customers = _customerDal.GetAll();
            DgvCustomerShow.Rows.Clear();
            foreach(Customer item in customers)
            {
                DgvCustomerShow.Rows.Add(item.Id, item.Name, item.Surname, item.Email, item.Phone, item.IdentityNumber);
            }
        }

        #endregion
        //Customer Datagridview add//
        private void CustomerCreatedForm_AddCustomer(object sender, EventArgs e)
        {
            FillDataCustomer();
        }

        #region Events

        //Create Customer//
        private void BtnCreatCustomer_Click(object sender, EventArgs e)
        {
            CustomerCreatedForm customerCreatedForm = new CustomerCreatedForm();
            customerCreatedForm.AddCustomer += CustomerCreatedForm_AddCustomer;
            customerCreatedForm.ShowDialog();
        }

        //Customer Deleted Database//
        private void BtnDeleted_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("Əminsinizmi.?", "Silməyə", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    _customerDal.Delete(_customer);
                    Reset();
                }
            }
            catch
            {
                MessageBox.Show("Bazada Bele Bir Data Movcuddur");
            }
           
        }
        //Customer Update Database//
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            CustomerCreatedForm customerUpdate = new CustomerCreatedForm(true, _customer);
            customerUpdate.AddCustomer += CustomerCreatedForm_AddCustomer;
            customerUpdate.ShowDialog();
        }

        #endregion

        //Choose Customer ResetMethods//
        private void Reset()
        {
            _customer = null;
            LblSelected.Hide();
            LblSelectedName.Hide();
            BtnDeleted.Hide();
            BtnUpdate.Hide();
            FillDataCustomer();

        }
        //Choose Customer Cell Click//
        private void DgvCustomerShow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = (int)DgvCustomerShow.Rows[e.RowIndex].Cells[0].Value;
                _customer = _customerDal.GetById(id);
                LblSelected.Show();
                LblSelectedName.Show();
                BtnDeleted.Show();
                BtnUpdate.Show();
                LblSelectedName.Text = _customer.Name + " " + _customer.Surname;
            }
            catch { }
        }
    }
}
