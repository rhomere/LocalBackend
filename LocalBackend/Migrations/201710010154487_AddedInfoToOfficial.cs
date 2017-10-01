namespace LocalBackend.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedInfoToOfficial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Officials", "Info", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Officials", "Info");
        }
    }
}
