using Library_management.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_management.Models
{
  public  class BookDal : IRepository<Book>
    {
        public Book GetById(int id)
        {
            using (LibraryDbContext _context = new LibraryDbContext())
            {

                return _context.Books.Find(id);
               
            }
        }
        public void Create(Book entity)
        {
            using (LibraryDbContext _context=new LibraryDbContext())
            {
                _context.Books.Add(entity);
                _context.SaveChanges();
            }
        }

        public void Delete(Book book)
        {
            using (LibraryDbContext _context = new LibraryDbContext())
            {
                    var entity = _context.Entry(book);
                    entity.State = EntityState.Deleted;
                   _context.SaveChanges();
            }
        }

        public List<Book> GetAll()
        {
            using (LibraryDbContext _context = new LibraryDbContext())
            {
                return _context.Books.Include("Genre").ToList();
            }
        }

        public void Update(Book book)
        {
            using (LibraryDbContext _context = new LibraryDbContext())
            {
                var entity = _context.Entry(book);
                entity.State = EntityState.Modified;
                _context.SaveChanges();
            }
        }
    }
}
