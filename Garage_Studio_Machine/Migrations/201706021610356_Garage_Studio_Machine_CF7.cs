namespace Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Garage_Studio_Machine_CF7 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Item", "ItemTypeID", c => c.Guid(nullable: false));
            CreateIndex("dbo.Item", "ItemTypeID");
            AddForeignKey("dbo.Item", "ItemTypeID", "dbo.ItemType", "ItemTypeID");
            DropColumn("dbo.Item", "ItemType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Item", "ItemType", c => c.Guid(nullable: false));
            DropForeignKey("dbo.Item", "ItemTypeID", "dbo.ItemType");
            DropIndex("dbo.Item", new[] { "ItemTypeID" });
            DropColumn("dbo.Item", "ItemTypeID");
        }
    }
}
