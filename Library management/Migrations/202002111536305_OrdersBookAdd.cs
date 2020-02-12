namespace Library_management.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrdersBookAdd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "BookId", c => c.Int(nullable: false));
            CreateIndex("dbo.Orders", "BookId");
            AddForeignKey("dbo.Orders", "BookId", "dbo.Books", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "BookId", "dbo.Books");
            DropIndex("dbo.Orders", new[] { "BookId" });
            DropColumn("dbo.Orders", "BookId");
        }
    }
}
