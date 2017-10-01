namespace LocalBackend.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPlacementToOfficials : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Officials", "Placement", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Officials", "Placement");
        }
    }
}
