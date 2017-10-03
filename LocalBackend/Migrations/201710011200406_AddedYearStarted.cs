namespace LocalBackend.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedYearStarted : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Officials", "YearStarted", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Officials", "YearStarted");
        }
    }
}
