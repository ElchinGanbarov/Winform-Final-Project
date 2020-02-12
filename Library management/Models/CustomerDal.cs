using Library_management.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_management.Models
{
  public  class CustomerDal : IRepository<Customer>
    {
        public Customer GetById(int id)
        {
            using (LibraryDbContext _context = new LibraryDbContext())
            {

                return _context.Customers.Find(id);

            }
        }
        public List<Customer> GetByIdentify(string id)
        {
            using (LibraryDbContext _context = new LibraryDbContext())
            {
                return  _context.Customers.Where(p=>p.IdentityNumber.Contains(id)).ToList();
                
            }
        }
        public void Create(Customer customer)
        {
            using (LibraryDbContext _context = new LibraryDbContext())
            {
                var entity = _context.Entry(customer);
                entity.State = EntityState.Added;
                _context.SaveChanges();
            }
        }

        public void Delete(Customer customer)
        {
            using (LibraryDbContext _context = new LibraryDbContext())
            {
                var entity = _context.Entry(customer);
                entity.State = EntityState.Deleted;
                _context.SaveChanges();
            }
        }

        public List<Customer> GetAll()
        {
            using (LibraryDbContext _context = new LibraryDbContext())
            {
                return _context.Customers.ToList();
            }
        }

        public void Update(Customer customer)
        {
            using (LibraryDbContext _context = new LibraryDbContext())
            {
                var entity = _context.Entry(customer);
                entity.State = EntityState.Modified;
                _context.SaveChanges();
            }
        }
    }
}
