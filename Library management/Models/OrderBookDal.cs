using Library_management.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_management.Models
{
    public class OrderBookDal : IRepository<OrderBook>
    {
        public void Create(OrderBook orderbook)
        {
            using (LibraryDbContext _context = new LibraryDbContext())
            {
                var entity = _context.Entry(orderbook);
                entity.State = EntityState.Added;
                _context.SaveChanges();
            }
        }

        public void Delete(OrderBook entity)
        {
            throw new NotImplementedException();
        }

        public List<OrderBook> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(OrderBook entity)
        {
            throw new NotImplementedException();
        }
    }
}
