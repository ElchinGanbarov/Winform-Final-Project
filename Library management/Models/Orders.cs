using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_management.Models
{
   public class Orders
    {
        public int Id { get; set; }
        public DateTime? GivingTime { get; set; }
        public DateTime? ReturnTime { get; set; }
        public DateTime? DeadLine { get; set; }
        public int? BookCount { get; set; }
        public decimal? LastMoney { get; set; }
        public int? ManagerId { get; set; }
        public int? CustomerId { get; set; }
        public Manager Manager { get; set; }
        public Customer Customer { get; set; }
        public List<OrderBook> OrderBooks { get; set; }

    }
}
