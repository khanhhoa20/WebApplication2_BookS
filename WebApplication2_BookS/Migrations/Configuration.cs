namespace WebApplication2_BookS.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication2_BookS.Models.BookDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "WebApplication2_BookS.Models.BookDBContext";
        }

        protected override void Seed(WebApplication2_BookS.Models.BookDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Books.AddOrUpdate(c => c.BookID,
    
                new Models.Book { BookID = @"8980075329379", Title= @"Tâm Tĩnh Lặng, Miệng Mỉm Cười", Author = @"Dịch giả N.T.Loan", Edition = "1" ,PublishYear=2020,Price=200000, Quantity=2000},
                new Models.Book { BookID = @"2436636288761", Title = @"Trên Đường Băng", Author = @"Tony Buổi Sáng", Edition = "2", PublishYear = 2017, Price = 100000, Quantity = 1000 }
                );
        }
    }
}
