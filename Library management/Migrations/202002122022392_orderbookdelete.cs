namespace Library_management.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class orderbookdelete : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.OrderBooks", "BookId", "dbo.Books");
            DropForeignKey("dbo.OrderBooks", "OrdersId", "dbo.Orders");
            DropIndex("dbo.OrderBooks", new[] { "BookId" });
            DropIndex("dbo.OrderBooks", new[] { "OrdersId" });
            DropTable("dbo.OrderBooks");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.OrderBooks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BookId = c.Int(),
                        OrdersId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.OrderBooks", "OrdersId");
            CreateIndex("dbo.OrderBooks", "BookId");
            AddForeignKey("dbo.OrderBooks", "OrdersId", "dbo.Orders", "Id");
            AddForeignKey("dbo.OrderBooks", "BookId", "dbo.Books", "Id");
        }
    }
}
