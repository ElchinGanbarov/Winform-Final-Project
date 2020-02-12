namespace Library_management.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class orderscolumntype : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Orders", "GivingTime", c => c.DateTime(storeType: "date"));
            AlterColumn("dbo.Orders", "ReturnTime", c => c.DateTime(storeType: "date"));
            AlterColumn("dbo.Orders", "DeadLine", c => c.DateTime(storeType: "date"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orders", "DeadLine", c => c.DateTime());
            AlterColumn("dbo.Orders", "ReturnTime", c => c.DateTime());
            AlterColumn("dbo.Orders", "GivingTime", c => c.DateTime());
        }
    }
}
