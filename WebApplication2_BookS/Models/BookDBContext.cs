using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WebApplication2_BookS.Models
{
    public partial class BookDBContext : DbContext
    {
        public BookDBContext()
            : base("name=BookDBContext")
        {
        }

        public DbSet<Book> Books { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
