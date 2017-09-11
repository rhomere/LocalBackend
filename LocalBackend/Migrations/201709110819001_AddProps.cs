namespace LocalBackend.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProps : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Municipalities", "Population", c => c.String());
            AddColumn("dbo.Municipalities", "MuniCode", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Municipalities", "MuniCode");
            DropColumn("dbo.Municipalities", "Population");
        }
    }
}
