namespace Library_management.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ManagerStatusAdd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Managers", "Status", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Managers", "Status");
        }
    }
}
