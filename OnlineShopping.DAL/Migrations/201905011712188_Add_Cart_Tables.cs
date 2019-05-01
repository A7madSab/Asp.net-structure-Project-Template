namespace OnlineShopping.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Cart_Tables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Key = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Product", "Cart_ID", c => c.Int());
            CreateIndex("dbo.Product", "Cart_ID");
            AddForeignKey("dbo.Product", "Cart_ID", "dbo.Carts", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Product", "Cart_ID", "dbo.Carts");
            DropIndex("dbo.Product", new[] { "Cart_ID" });
            DropColumn("dbo.Product", "Cart_ID");
            DropTable("dbo.Carts");
        }
    }
}
