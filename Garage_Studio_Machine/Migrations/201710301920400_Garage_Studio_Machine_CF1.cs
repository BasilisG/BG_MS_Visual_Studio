namespace Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Garage_Studio_Machine_CF1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Item", "TrnServiceHeader_TrnServiceHeaderID", "dbo.TrnServiceHeader");
            DropIndex("dbo.Item", new[] { "TrnServiceHeader_TrnServiceHeaderID" });
            DropColumn("dbo.Item", "TrnServiceHeader_TrnServiceHeaderID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Item", "TrnServiceHeader_TrnServiceHeaderID", c => c.Guid());
            CreateIndex("dbo.Item", "TrnServiceHeader_TrnServiceHeaderID");
            AddForeignKey("dbo.Item", "TrnServiceHeader_TrnServiceHeaderID", "dbo.TrnServiceHeader", "TrnServiceHeaderID");
        }
    }
}
