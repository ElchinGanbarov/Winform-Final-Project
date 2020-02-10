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
using CryptoHelper;

namespace Library_management.Forms
{
    public partial class ManagerCreatedForm : Form
    {
        public event EventHandler AddManager;
        private ManagerDal _managerDal;
        public bool _isUpdate;
        public Manager _manager;
        
        public ManagerCreatedForm(bool isUpdate=false,Manager manager=null)
        {
            _isUpdate = isUpdate;
            _manager = manager;
            _managerDal = new ManagerDal();
            InitializeComponent();
            if (_isUpdate)
            {
                FilUpdateData();
            }
        }

        #region FillMethods
        // Update Fill MEthods//
        public void FilUpdateData()
        {
            TxtName.Text = _manager.Name;
            TxtSurname.Text = _manager.Surname;
            TxtAge.Text = Convert.ToInt32(_manager.Age).ToString();
            TxtEmail.Text = _manager.Email;
            TxtPhone.Text = _manager.Phone;
            TxtPassword.Hide();
            LblPassword.Hide();
            BtnSave.Location = new System.Drawing.Point(24, 256);
            BtnCancel.Location = new System.Drawing.Point(94, 256);
            BtnSave.Text = "Update";
            this.Text = "Yenile";
        }

        #endregion
        #region Events
        //Save EVent Creat Manager//
        private void BtnSave_Click(object sender, EventArgs e)
        { 
            if (_isUpdate)
            {
                DialogResult r = MessageBox.Show("Əminsinizmi.?", "Yenilemeye", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    _manager.Name = TxtName.Text;
                    _manager.Surname = TxtSurname.Text;
                    _manager.Age = Convert.ToInt32(TxtAge.Text);
                    _manager.Phone = TxtPhone.Text;
                    _manager.Email = TxtEmail.Text;
                    MessageBox.Show("Melumat deisildi");
                    _managerDal.Update(_manager);
                    AddManager?.Invoke(_manager, new EventArgs());
                } 
            }
            else
            {
                if (!this.CheckInput())
                {
                    MessageBox.Show("Zehmet olmasa xanalari doldurun !", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!TxtAge.Text.IsNumber())
                {
                    MessageBox.Show("Yasi duzgun qeyd edin !", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!TxtEmail.Text.IsEmail())
                {
                    MessageBox.Show("Emaili duzgun qeyd edin !", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (_managerDal.GetAll().Any(m => m.Email == TxtEmail.Text))
                {
                    MessageBox.Show("Bu email artiq movcuddur !", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!TxtPhone.Text.IsNumber())
                {
                    MessageBox.Show("Duzgun nomre qeyd edin !", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Manager manager = new Manager
                {
                    Name = TxtName.Text,
                    Surname = TxtSurname.Text,
                    Age = Convert.ToInt32(TxtAge.Text),
                    Email = TxtEmail.Text,
                    Password = Crypto.HashPassword(TxtPassword.Text),
                    Phone = TxtPhone.Text,
                    Level = ManagerLevel.Moderator,
                    Status = true
                };
                _managerDal.Create(manager);
                MessageBox.Show("Isci elave edildi");
                AddManager?.Invoke(manager, new EventArgs());
            }
            this.Close();
        }
        //Cancel Event//
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
