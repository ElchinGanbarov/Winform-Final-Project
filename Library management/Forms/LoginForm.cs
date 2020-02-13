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
using Library_management.Data;
using Library_management.Models;

namespace Library_management.Forms
{
    public partial class LoginForm : Form
    {
        private readonly LibraryDbContext _dbContext;
        public LoginForm()
        {
            InitializeComponent();
            _dbContext = new LibraryDbContext();
        }
        //Dashboard Creat //
        private void Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtEmail.Text))
            {
                MessageBox.Show("E-poçt yazın");
                return;
            }
            if (string.IsNullOrEmpty(TxtPassword.Text))
            {
                MessageBox.Show("Şifrə yazın");
                return;
            }
            //Manager Login for Password and UserName//
            Manager manager = _dbContext.Managers.FirstOrDefault(m => m.Status && m.Email == TxtEmail.Text);
            if (manager != null && Crypto.VerifyHashedPassword(manager.Password, TxtPassword.Text))
            {
                DashboardForm dashboard = new DashboardForm(manager);
                dashboard.Show();
                this.Hide();
                return;
                
            }
            else
            {
                MessageBox.Show("E-poçt və ya şifrə yalnışdır", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
