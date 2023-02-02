using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Diagnostics.Eventing.Reader;

namespace Architecture_Final_4928.Models
{
    public class BookDbContext: DbContext
    {
        public DbSet<Book> Books { get; set; }

        public DbSet<Client> Clients { get; set; }
        public BookDbContext() : base("BooksDb")
        {

        }
        public static BookDbContext Create()
        {
            return new BookDbContext();
        }
    }
}