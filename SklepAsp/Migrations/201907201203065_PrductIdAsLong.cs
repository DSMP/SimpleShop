namespace SklepAsp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PrductIdAsLong : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Products");
            DropColumn("dbo.Products", "ProductId");
            AddColumn("dbo.Products", "ProductId", c => c.Long(nullable: false, identity: true));
            AddPrimaryKey("dbo.Products", "ProductId");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Products");
            DropColumn("dbo.Products", "ProductId");
            AddColumn("dbo.Products", "ProductId", c => c.Guid(nullable: false, identity: true));
            AddPrimaryKey("dbo.Products", "ProductId");
        }
    }
}
