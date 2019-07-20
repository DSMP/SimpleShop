namespace SklepAsp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductIdAsIdentity : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Products");
            AlterColumn("dbo.Products", "ProductId", c => c.Guid(nullable: false, identity: true));
            AddPrimaryKey("dbo.Products", "ProductId");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Products");
            AlterColumn("dbo.Products", "ProductId", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.Products", "ProductId");
        }
    }
}
