namespace ReviewProjectWeek5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdjustContext : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categories", "Name");
        }
    }
}
