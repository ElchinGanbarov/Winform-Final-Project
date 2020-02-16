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
        //Choose Book Select Id//
        public Book GetById(int id)
        {
            using (LibraryDbContext _context = new LibraryDbContext())
            {

                return _context.Books.Find(id);
               
            }
        }
        //Search Book Filter//
        public List<Book> FilterByName(string name)
        {
            using (LibraryDbContext _context = new LibraryDbContext())
            {

                return _context.Books.Where(p => p.Name.Contains(name)).Include("Genre").ToList();

            }
        }
        //Book Create Database//
        public void Create(Book entity)
        {
            using (LibraryDbContext _context=new LibraryDbContext())
            {
                _context.Books.Add(entity);
                _context.SaveChanges();
            }
        }
        //Book Delete Database//
        public void Delete(Book book)
        {
            using (LibraryDbContext _context = new LibraryDbContext())
            {
                    var entity = _context.Entry(book);
                    entity.State = EntityState.Deleted;
                   _context.SaveChanges();
            }
        }
        //Book Listed//
        public List<Book> GetAll()
        {
            using (LibraryDbContext _context = new LibraryDbContext())
            {
                return _context.Books.Include("Genre").ToList();
            }
        }
        //Book Update Database//
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
