namespace LocalBackend.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedTermLength : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Officials", "TermLength", c => c.String());
            AddColumn("dbo.Officials", "NextElection", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Officials", "NextElection");
            DropColumn("dbo.Officials", "TermLength");
        }
    }
}
