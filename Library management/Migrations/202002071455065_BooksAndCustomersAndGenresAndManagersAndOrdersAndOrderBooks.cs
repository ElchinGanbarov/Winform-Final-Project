namespace Library_management.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BooksAndCustomersAndGenresAndManagersAndOrdersAndOrderBooks : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Price = c.Decimal(nullable: false, storeType: "money"),
                        Count = c.Int(nullable: false),
                        GenreId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Genres", t => t.GenreId, cascadeDelete: true)
                .Index(t => t.GenreId);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Surname = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 500),
                        Phone = c.String(nullable: false, maxLength: 50),
                        IdentityNumber = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GivingTime = c.DateTime(),
                        ReturnTime = c.DateTime(),
                        DeadLine = c.DateTime(),
                        BookCount = c.Int(),
                        LastMoney = c.Decimal(precision: 18, scale: 2),
                        ManagerId = c.Int(),
                        CustomerId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId)
                .ForeignKey("dbo.Managers", t => t.ManagerId)
                .Index(t => t.ManagerId)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.Managers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Surname = c.String(nullable: false, maxLength: 50),
                        Age = c.Int(nullable: false),
                        Email = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 500),
                        Phone = c.String(nullable: false, maxLength: 50),
                        Level = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OrderBooks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BookId = c.Int(),
                        OrdersId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.BookId)
                .ForeignKey("dbo.Orders", t => t.OrdersId)
                .Index(t => t.BookId)
                .Index(t => t.OrdersId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderBooks", "OrdersId", "dbo.Orders");
            DropForeignKey("dbo.OrderBooks", "BookId", "dbo.Books");
            DropForeignKey("dbo.Orders", "ManagerId", "dbo.Managers");
            DropForeignKey("dbo.Orders", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Books", "GenreId", "dbo.Genres");
            DropIndex("dbo.OrderBooks", new[] { "OrdersId" });
            DropIndex("dbo.OrderBooks", new[] { "BookId" });
            DropIndex("dbo.Orders", new[] { "CustomerId" });
            DropIndex("dbo.Orders", new[] { "ManagerId" });
            DropIndex("dbo.Books", new[] { "GenreId" });
            DropTable("dbo.OrderBooks");
            DropTable("dbo.Managers");
            DropTable("dbo.Orders");
            DropTable("dbo.Customers");
            DropTable("dbo.Genres");
            DropTable("dbo.Books");
        }
    }
}
