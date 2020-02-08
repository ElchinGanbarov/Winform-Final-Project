namespace Library_management.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerAndManagerUpdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Managers", "Password", c => c.String(nullable: false, maxLength: 100));
            DropColumn("dbo.Customers", "Password");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "Password", c => c.String(nullable: false, maxLength: 500));
            AlterColumn("dbo.Managers", "Password", c => c.String(nullable: false, maxLength: 500));
        }
    }
}
