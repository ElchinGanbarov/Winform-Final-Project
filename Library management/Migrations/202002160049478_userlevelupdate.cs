namespace Library_management.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userlevelupdate : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Managers", "Level");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Managers", "Level", c => c.Int(nullable: false));
        }
    }
}
