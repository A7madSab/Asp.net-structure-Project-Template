namespace OnlineShopping.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Cart_Table : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Item", "Product_ID", "dbo.Product");
            DropIndex("dbo.Item", new[] { "Product_ID" });
            DropColumn("dbo.Item", "Product_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Item", "Product_ID", c => c.Int());
            CreateIndex("dbo.Item", "Product_ID");
            AddForeignKey("dbo.Item", "Product_ID", "dbo.Product", "ID");
        }
    }
}
