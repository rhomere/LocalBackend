namespace LocalBackend.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPropsToMuni : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Municipalities", "MuniName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Municipalities", "MuniName");
        }
    }
}
