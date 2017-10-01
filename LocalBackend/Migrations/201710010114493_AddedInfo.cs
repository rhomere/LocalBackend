namespace LocalBackend.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedInfo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Municipalities", "Info", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Municipalities", "Info");
        }
    }
}
