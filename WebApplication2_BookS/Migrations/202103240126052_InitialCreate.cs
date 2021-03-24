namespace WebApplication2_BookS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        BookID = c.String(nullable: false, maxLength: 128),
                        Title = c.String(),
                        Author = c.String(),
                        Edition = c.String(),
                        PublishYear = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BookID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Books");
        }
    }
}
