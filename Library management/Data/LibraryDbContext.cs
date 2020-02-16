using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Library_management.Models;

namespace Library_management.Data
{
  public class LibraryDbContext:DbContext
    {
        //ConnectionString Name =>LibraryDbContext//
        public LibraryDbContext() : base("LibraryDbContext")
        {

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Orders> Orders { get; set; }

    }
}
