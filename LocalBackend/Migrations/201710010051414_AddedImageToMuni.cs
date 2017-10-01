namespace LocalBackend.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedImageToMuni : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Municipalities", "ImageUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Municipalities", "ImageUrl");
        }
    }
}
