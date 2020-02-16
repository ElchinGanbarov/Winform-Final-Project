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
    public partial class ManagerForm : Form
    {
        public ManagerDal _managerDal;
        public int id;
        public Manager _manager;
        public ManagerForm()
        {
           
            _managerDal = new ManagerDal();
            InitializeComponent();
            FillDataManager();
        }

        #region FillMethods
        public void FillDataManager()
        {
            List<Manager> managers = _managerDal.GetAll();
            DgvManagerShow.Rows.Clear();
            foreach(Manager item in managers)
            {
                DgvManagerShow.Rows.Add(item.Id,item.Name, item.Surname, item.Age, item.Email,item.Phone);
            }
        }

        #endregion
        #region Events
        //Manager Create Events//
        private void Button1_Click(object sender, EventArgs e)
        {
                ManagerCreatedForm managerCreated = new ManagerCreatedForm();
                managerCreated.AddManager += ManagerCreated_AddManager;
                managerCreated.ShowDialog();  
        }
        //Manager Delete Event//
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("Əminsinizmi.?", "Silməyə", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    _managerDal.Delete(_manager);
                    Reset();
                }
            }
            catch
            {
                MessageBox.Show("Bazada Bele bir Data Movcuddur");
            }
        }

        //Manager Update Event//
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            ManagerCreatedForm managerUpdate = new ManagerCreatedForm(true, _manager);
            managerUpdate.AddManager += ManagerCreated_AddManager;
            managerUpdate.ShowDialog();
        }

        #endregion
        //Manager Created and Updata DataGriedView Add and Update//
        private void ManagerCreated_AddManager(object sender, EventArgs e)
        {
            FillDataManager();
        }
        //Coohe Manager Reset//
        private void Reset()
        {
            _manager = null;
            LblSelectedName.Text = " ";
            BtnDelete.Show();
            BtnUpdate.Show();
            FillDataManager();
        }
        //ManagerForm-DataGridView-Cell Click Choose Id//
        private void DgvManagerShow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = (int)DgvManagerShow.Rows[e.RowIndex].Cells[0].Value;
                _manager = _managerDal.GetById(id);
                LblSelected.Show();
                LblSelectedName.Show();
                BtnDelete.Show();
                BtnUpdate.Show();
                LblSelectedName.Text = _manager.Name + " " + _manager.Surname;
            }
            catch { }
        }
    }
}
