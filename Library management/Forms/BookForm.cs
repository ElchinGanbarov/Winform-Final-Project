using Library_management.Data;
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
    public partial class BookForm : Form
    {
        private BookDal _bookDal;
        private Book _book;
        private int id;
        public BookForm()
        {
            _bookDal = new BookDal();
            InitializeComponent();
        }
        #region FillMethods
        public void FillDataAdd()
        {
            List<Book> books = _bookDal.GetAll();

            DgvAddBooks.Rows.Clear();
            foreach (Book item in books)
            {
                DgvAddBooks.Rows.Add(item.Id, item.Name, item.Price, item.Count, item.Genre.Name);
            }
        }
        #endregion
        //Book Creat Action//
        private void BtnCreatBook_Click(object sender, EventArgs e)
        {
            BookCreatForm bookCreatForm = new BookCreatForm();
            bookCreatForm.AddBook += BookCreatForm_AddBook;
            bookCreatForm.ShowDialog();
        }

        //Book Add DataGridView with Event//
        private void BookCreatForm_AddBook(object sender, EventArgs e)
        {
            FillDataAdd();
        }


        #region EVENTS
        //Book Form Load//
        private void BookForm_Load(object sender, EventArgs e)
        {
            FillDataAdd();
        }
        //Book Deleted//
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("Əminsinizmi.?", "Silməyə", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    _bookDal.Delete(_book);
                    Reset();
                }
            }
            catch
            {
                MessageBox.Show("Bazada Bele bir Data Movcuddur");
            }
        }

        //Book Update//
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            BookCreatForm bookCreat = new BookCreatForm(true, _book);
            bookCreat.AddBook += BookCreatForm_AddBook;
            bookCreat.ShowDialog();
        }

        #endregion
        //DataGridView Row Header//
        private void DataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                id = (int)DgvAddBooks.Rows[e.RowIndex].Cells[0].Value;
                _book = _bookDal.GetById(id);
                SelectedLabel.Show();
                BtnDelete.Show();
                BtnUpdate.Show();
                SelectedName.Text = _book.Name;
            }
            catch { }
        }

         //Choose Book Reset//     
        private void Reset()
        {
            _book = null;
            SelectedName.Text = " ";
            BtnDelete.Show();
            BtnUpdate.Show();
            FillDataAdd();
        }
        //Genre Added//
        private void BtnGenre_Click(object sender, EventArgs e)
        {
            GenreForm genre = new GenreForm();

            genre.ShowDialog();
        }
    }
}
