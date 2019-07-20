namespace SklepAsp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GuidForProduct : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Products");

            DropColumn("dbo.Products", "ProductId");
            AddColumn("dbo.Products", "ProductId", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.Products", "ProductId");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Products");

            DropColumn("dbo.Products", "ProductId");
            AddColumn("dbo.Products", "ProductId", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Products", "ProductId");
        }
    }
}
