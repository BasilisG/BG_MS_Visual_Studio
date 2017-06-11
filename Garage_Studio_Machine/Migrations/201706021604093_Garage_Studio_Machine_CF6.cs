namespace Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Garage_Studio_Machine_CF6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Item", "ItemType", c => c.Guid(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Item", "ItemType");
        }
    }
}
