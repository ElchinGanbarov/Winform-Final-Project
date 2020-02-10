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
        public Manager GetById(int id)
        {
            using (LibraryDbContext _context = new LibraryDbContext())
            {

                return _context.Managers.Find(id);

            }
        }
        public void Create(Manager manager)
        {
            using (LibraryDbContext _context = new LibraryDbContext())
            {
                var entity = _context.Entry(manager);
                entity.State = EntityState.Added; 
                _context.SaveChanges();
            }
        }

        public void Delete(Manager manager)
        {
            using (LibraryDbContext _context = new LibraryDbContext())
            {
                var entity = _context.Entry(manager);
                entity.State = EntityState.Deleted;
                _context.SaveChanges();
            }
        }

        public List<Manager> GetAll()
        {
            using (LibraryDbContext _context = new LibraryDbContext())
            {
                return _context.Managers.ToList();
            }
        }

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
