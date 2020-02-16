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
        //Choose Customer Select Id//
        public Customer GetById(int id)
        {
            using (LibraryDbContext _context = new LibraryDbContext())
            {

                return _context.Customers.Find(id);

            }
        }
        //Choose Customer Select Identify Number//
        public List<Customer> GetByIdentify(string id)
        {
            using (LibraryDbContext _context = new LibraryDbContext())
            {
                return  _context.Customers.Where(p=>p.IdentityNumber.Contains(id)).ToList();
                
            }
        }
        //Create Customer Database//
        public void Create(Customer customer)
        {
            using (LibraryDbContext _context = new LibraryDbContext())
            {
                var entity = _context.Entry(customer);
                entity.State = EntityState.Added;
                _context.SaveChanges();
            }
        }
        //Delete Customer Databse//
        public void Delete(Customer customer)
        {
            using (LibraryDbContext _context = new LibraryDbContext())
            {
                var entity = _context.Entry(customer);
                entity.State = EntityState.Deleted;
                _context.SaveChanges();
            }
        }
        //Customer Listed//
        public List<Customer> GetAll()
        {
            using (LibraryDbContext _context = new LibraryDbContext())
            {
                return _context.Customers.ToList();
            }
        }
        //Customer Update Database//
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
