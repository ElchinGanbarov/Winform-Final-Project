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

        public Orders GetById(int id)
        {
            using (LibraryDbContext _context = new LibraryDbContext())
            {

                return _context.Orders.Find(id);

            }
        }
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
                var result = _context.Orders.Include("Books").Include("Customers").Include("Managers").OrderBy(p => p.Customers.Name).ToList();
                return result;
            }
        }

        public List<Orders> GetForBasket(int id)
        {
            using (LibraryDbContext _context = new LibraryDbContext())
            {
                var result = _context.Orders.Include("Books").Include("Customers").Include("Managers").Where(o => o.GivingTime.Value.Day == DateTime.Now.Day && o.CustomerId == id && o.Status==false).ToList();
                return result;
            }
        }

        public List<Orders> GetForAllReturnOrders()
        {
            using (LibraryDbContext _context = new LibraryDbContext())
            {
                var result = _context.Orders.Include("Books").Include("Customers").Include("Managers").Where(o => o.Status == false).ToList();
                return result;
            }
        }
        public List<Orders> GetByIdentify(string id)
        {
            using (LibraryDbContext _context = new LibraryDbContext())
            {
                return _context.Orders.Include("Books").Include("Customers").Include("Managers").Where(p => p.Customers.IdentityNumber.Contains(id) && p.Status==false).ToList();

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

