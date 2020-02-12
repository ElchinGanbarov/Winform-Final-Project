using Library_management.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_management.Models
{
    public class OrderDal : IRepository<Orders>
    {
        public void Create(Orders orders)
        {
            using (LibraryDbContext _context = new LibraryDbContext())
            {
                var entity = _context.Entry(orders);
                entity.State = EntityState.Added;
                _context.SaveChanges();
            }
        }

        public void Delete(Orders orders)
        {
            using (LibraryDbContext _context = new LibraryDbContext())
            {
                var entity = _context.Entry(orders);
                entity.State = EntityState.Deleted;
                _context.SaveChanges();
            }
        }

        public List<Orders> GetAll()
        {
            using (LibraryDbContext _context = new LibraryDbContext())
            {
                var result = _context.Orders.Include("Book").Include("Customer").Include("Manager").ToList();
                return result;
            }
        }

        public List<Orders> GetForBasket(int id)
        {
            using (LibraryDbContext _context = new LibraryDbContext())
            {
                var result = _context.Orders.Include("Books").Include("Customers").Include("Managers").Where(o => o.GivingTime.Value.Day == DateTime.Now.Day && o.CustomerId == id).ToList();
                return result;
            }
        }

        public void Update(Orders orders)
        {
            using (LibraryDbContext _context = new LibraryDbContext())
            {
                var entity = _context.Entry(orders);
                entity.State = EntityState.Modified;
                _context.SaveChanges();
            }
        }
    }
}

