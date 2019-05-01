namespace OnlineShopping.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Normalize : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Item", "Price1", c => c.Single(nullable: false));
            AddColumn("dbo.Item", "Price2", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Item", "Price2");
            DropColumn("dbo.Item", "Price1");
        }
    }
}
