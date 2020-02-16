using Library_management.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_management.Models
{
  public  class ManagerDal : IRepository<Manager>
    {
        //Choose Manager Select Id//
        public Manager GetById(int id)
        {
            using (LibraryDbContext _context = new LibraryDbContext())
            {

                return _context.Managers.Find(id);

            }
        }
        //Manager Create Databse//
        public void Create(Manager manager)
        {
            using (LibraryDbContext _context = new LibraryDbContext())
            {
                var entity = _context.Entry(manager);
                entity.State = EntityState.Added; 
                _context.SaveChanges();
            }
        }
        //Manager Delete Database//
        public void Delete(Manager manager)
        {
            using (LibraryDbContext _context = new LibraryDbContext())
            {
                var entity = _context.Entry(manager);
                entity.State = EntityState.Deleted;
                _context.SaveChanges();
            }
        }
        //Manager Listed//
        public List<Manager> GetAll()
        {
            using (LibraryDbContext _context = new LibraryDbContext())
            {
                return _context.Managers.ToList();
            }
        }
        //Manager Update Database//
        public void Update(Manager manager)
        {
            using (LibraryDbContext _context = new LibraryDbContext())
            {
                var entity = _context.Entry(manager);
                entity.State = EntityState.Modified;
                _context.SaveChanges();
            }
        }
    }
}
