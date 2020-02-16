using Library_management.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_management.Models
{
   public class GenreDal
    {
        //Choose Genre Select ID//
        public Genre GetById(int id)
        {
            using (LibraryDbContext _context = new LibraryDbContext())
            {

                return _context.Genres.Find(id);

            }
        }
        //Genre Create Database//
        public void Create(Genre genre)
        {
            using (LibraryDbContext _context = new LibraryDbContext())
            {
                _context.Genres.Add(genre);
                _context.SaveChanges();
            }
        }
        //Genre Listed//
        public List<Genre> GetGenreList()
        {
            using (LibraryDbContext _context=new LibraryDbContext())
            {
                List<Genre> genres = _context.Genres.ToList();
                return genres;
            }
        }
    }
}
