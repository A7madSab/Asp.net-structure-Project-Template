namespace OnlineShopping.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_Product_table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Item", "Product_ID", c => c.Int());
            CreateIndex("dbo.Item", "Product_ID");
            AddForeignKey("dbo.Item", "Product_ID", "dbo.Product", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Item", "Product_ID", "dbo.Product");
            DropIndex("dbo.Item", new[] { "Product_ID" });
            DropColumn("dbo.Item", "Product_ID");
            DropTable("dbo.Product");
        }
    }
}
