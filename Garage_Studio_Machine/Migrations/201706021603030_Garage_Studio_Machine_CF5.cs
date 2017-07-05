namespace ViewModels.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Garage_Studio_Machine_CF5 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Item", "ItemType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Item", "ItemType", c => c.Int(nullable: false));
        }
    }
}
