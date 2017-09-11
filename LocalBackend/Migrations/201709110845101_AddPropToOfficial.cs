namespace LocalBackend.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPropToOfficial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Officials", "Municipality", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Officials", "Municipality");
        }
    }
}
