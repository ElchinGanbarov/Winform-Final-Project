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
    public partial class CustomerCreatedForm : Form
    {
        public event EventHandler AddCustomer;
        private CustomerDal _customerDal;
        private Customer _customer;
        private bool _isUpdate;
        public CustomerCreatedForm(bool isupdate=false,Customer customer=null)
        {
            _isUpdate = isupdate;
            _customer = customer;
            _customerDal = new CustomerDal();
            InitializeComponent();
            if (_isUpdate)
            {
                FilUpdateData();
            }
        }

        //Customer Update Method//
        public void FilUpdateData()
        {
            TxtName.Text = _customer.Name;
            TxtSuranme.Text = _customer.Surname;
            TxtEmail.Text = _customer.Email;
            TxtPhone.Text = _customer.Phone;
            TxtIdentify.Text = _customer.IdentityNumber;
            BtnSave.Text = "Update";
            this.Text = "Yenile";
        }
        //Cancel Button Click//
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Customer Add Database//
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (_isUpdate)
            {
                DialogResult r = MessageBox.Show("Əminsinizmi.?", "Yenilemeye", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    _customer.Name = TxtName.Text;
                    _customer.Surname = TxtSuranme.Text;
                    _customer.Email = TxtEmail.Text;
                    _customer.Phone = TxtPhone.Text;
                    _customer.IdentityNumber = TxtIdentify.Text;
                    MessageBox.Show("Melumat yenilendi");
                    _customerDal.Update(_customer);
                    AddCustomer?.Invoke(_customer, new EventArgs());

                }
                
            }
            else
            {
                if (!this.CheckInput())
                {
                    MessageBox.Show("Zehmet olmasa xanalari doldurun !", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!TxtEmail.Text.IsEmail())
                {
                    MessageBox.Show("Emaili duzgun qeyd edin !", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!TxtPhone.Text.IsNumber())
                {
                    MessageBox.Show("Nomreni duzgun qeyd edin !", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!TxtIdentify.Text.IsNumber() || TxtIdentify.Text.Length != 8 )
                {
                    MessageBox.Show("Kimlik nomresini duzgun qeyd edin !", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                List<Customer> customers = _customerDal.GetAll();
                foreach(Customer item in customers)
                {
                    if (item.IdentityNumber == TxtIdentify.Text)
                    {
                        MessageBox.Show(" Bele Kimlik nomresi Qeyd edilibdir !", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                         return;
                    }
                }

                //if ( _customerDal.GetByIdentifyNumber(TxtIdentify.Text))
                //{
                //    MessageBox.Show(" Bele Kimlik nomresi Qeyd edilibdir !", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return;
                //}

                if (_customerDal.GetAll().Any(m => m.Email == TxtEmail.Text))
                {
                    MessageBox.Show("Bu email artiq movcuddur !", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Customer customer = new Customer
                {
                    Name = TxtName.Text,
                    Surname = TxtSuranme.Text,
                    Email = TxtEmail.Text,
                    Phone = TxtPhone.Text,
                    IdentityNumber = TxtIdentify.Text
                };
                MessageBox.Show("Musteri elave edildi");
                _customerDal.Create(customer);
                AddCustomer?.Invoke(customer, new EventArgs());

            }

           
            this.Close();

        }

     
    }
}
