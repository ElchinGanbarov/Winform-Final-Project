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
    public partial class GenreForm : Form
    {
        private GenreDal _genreDal;
        public GenreForm()
        {
            _genreDal = new GenreDal();
            InitializeComponent();
        }

        //Save Genre Database//
        private void BtnSaveGenre_Click(object sender, EventArgs e)
        {
            Genre genre = new Genre
            {
                Name = TxtGenre.Text
            };
            _genreDal.Create(genre);
            TxtGenre.Clear();
            this.Close();
        }
        //Cancel Event//
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
