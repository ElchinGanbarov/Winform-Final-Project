using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
namespace Library_management.Models
{
   public class Orders
    {
        public int Id { get; set; }   
        [Column(TypeName ="date")]
        public DateTime? GivingTime { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ReturnTime { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DeadLine { get; set; }
        public int? BookCount { get; set; }
        public decimal? LastMoney { get; set; }
        [ForeignKey("Managers")]
        public int? ManagerId { get; set; }
        [ForeignKey("Customers")]
        public int? CustomerId { get; set; }
        public Manager Managers { get; set; }
        public Customer Customers { get; set; }
        [ForeignKey("Books")]
        public int BookId { get; set; }
        public Book Books { get; set; }
        [Column(TypeName ="bit")]
        public bool Status { get; set; }


    }
}
