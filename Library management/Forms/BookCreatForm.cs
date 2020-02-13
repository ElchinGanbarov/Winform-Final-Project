using Library_management.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library_management.Models;

namespace Library_management.Forms
{
    public partial class BookCreatForm : Form
    {
        private GenreDal _genreDal;
        private BookDal _bookDal;
        public event EventHandler AddBook;
        public bool _isUpdate;
        public Book _book;

        //BookCreatForm Constructor//
        public BookCreatForm(bool isupdate = false,Book book=null)
        {
            _isUpdate = isupdate;
            _book = book;
            _bookDal = new BookDal();
            _genreDal = new GenreDal();
            InitializeComponent();
            FillGenreAdd();
            if (_isUpdate)
            {
                FilUpdateData();
            }
            
        }

        
        #region FillData

        //Combobox Add Genres
        public void FillGenreAdd()
        {
            List<Genre> genres = _genreDal.GetGenreList();
            foreach(Genre item in genres)
            {
                CmbCombobox combobox = new CmbCombobox
                {
                    Id = item.Id,
                    Name = item.Name
                };
                CmbGenre.Items.Add(combobox);
            }
        }
        
        //Update Methods//
        public void FilUpdateData()
        {
            TxtBookName.Text = _book.Name;
            TxtPrice.Text =_book.Price.ToString();
            TxtCount.Text =_book.Count.ToString();
            Genre genre = _genreDal.GetById(_book.GenreId);
            CmbGenre.SelectedItem = new CmbCombobox
            {
                Id =genre.Id,
                Name =genre.Name
            };
            CmbGenre.Text = genre.Name;

            BtnSave.Text = "Update";
            this.Text = "Yenile";
        }

        #endregion
        // Book Create Event//       
        private void BtnSave_Click(object sender, EventArgs e)
        {
          //Book Update Event//
            CmbCombobox select = CmbGenre.SelectedItem as CmbCombobox;
            if (_isUpdate)
            { 
                _book.Name = TxtBookName.Text;
                _book.Price = Convert.ToDecimal(TxtPrice.Text);
                _book.Count = Convert.ToInt32(TxtCount.Text);
                _book.GenreId = select.Id;
                _bookDal.Update(_book);
                AddBook?.Invoke(_book, new EventArgs());
                MessageBox.Show("Melumat Deisildi");

               
            }
            else
            {
                if (!this.CheckInput() || CmbGenre.SelectedItem == null)
                {
                    MessageBox.Show("Xanalari doldurun");
                    return;
                }
                Book book = new Book
                {
                    Name = TxtBookName.Text,
                    Price = Convert.ToDecimal(TxtPrice.Text),
                    Count = Convert.ToInt32(TxtCount.Text),
                    GenreId = select.Id
                };
                _bookDal.Create(book);
                MessageBox.Show("Melumat elave edildi");
                AddBook?.Invoke(book, new EventArgs());
            }
            this.Close();
        }
        // Cancal Event//
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
