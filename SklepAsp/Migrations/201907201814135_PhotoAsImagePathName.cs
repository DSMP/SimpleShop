namespace SklepAsp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PhotoAsImagePathName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Image", c => c.String());
            DropColumn("dbo.Products", "Photo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Photo", c => c.Binary());
            DropColumn("dbo.Products", "Image");
        }
    }
}
