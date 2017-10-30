namespace Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Garage_Studio_Machine_CF : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TrnServiceRow",
                c => new
                    {
                        TrnServiceRowID = c.Guid(nullable: false),
                        TrnServiceHeaderID = c.Guid(nullable: false),
                        LineNumber = c.Int(nullable: false),
                        ItemTypeID = c.Guid(nullable: false),
                        ItemID = c.Guid(nullable: false),
                        QtyA = c.Double(nullable: false),
                        UnitPrice = c.Double(nullable: false),
                        GrossValue = c.Double(nullable: false),
                        ItemDiscountPcnt = c.Double(nullable: false),
                        ItemDiscountValue = c.Double(nullable: false),
                        NetValue = c.Double(nullable: false),
                        VatID = c.Guid(nullable: false),
                        VatValue = c.Double(nullable: false),
                        VatPcnt = c.Double(nullable: false),
                        TotalValue = c.Double(nullable: false),
                        Comments = c.String(),
                        UserID = c.Guid(nullable: false),
                        Date_Ins = c.DateTime(),
                        Date_Upd = c.DateTime(),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.TrnServiceRowID)
                .ForeignKey("dbo.Item", t => t.ItemID)
                .ForeignKey("dbo.TrnServiceHeader", t => t.TrnServiceHeaderID)
                .Index(t => t.TrnServiceHeaderID)
                .Index(t => t.ItemID);
            
            CreateTable(
                "dbo.TrnServiceHeader",
                c => new
                    {
                        TrnServiceHeaderID = c.Guid(nullable: false),
                        DateTrnIssue = c.DateTime(nullable: false),
                        DateTrnIn = c.DateTime(nullable: false),
                        DateTrnOut = c.DateTime(nullable: false),
                        DateTrnPrint = c.DateTime(nullable: false),
                        CustomerID = c.Guid(nullable: false),
                        VehicleID = c.Guid(nullable: false),
                        Kilometers = c.Int(nullable: false),
                        Comments = c.String(maxLength: 2048),
                        UserID = c.Guid(nullable: false),
                        Date_Ins = c.DateTime(),
                        Date_Upd = c.DateTime(),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.TrnServiceHeaderID)
                .ForeignKey("dbo.Customer", t => t.CustomerID)
                .ForeignKey("dbo.Vehicle", t => t.VehicleID)
                .Index(t => new { t.CustomerID, t.VehicleID, t.DateTrnIssue }, name: "IDX_TrnServiceHeader_Composite1");
            
            AddColumn("dbo.Item", "TrnServiceHeader_TrnServiceHeaderID", c => c.Guid());
            CreateIndex("dbo.Item", "TrnServiceHeader_TrnServiceHeaderID");
            AddForeignKey("dbo.Item", "TrnServiceHeader_TrnServiceHeaderID", "dbo.TrnServiceHeader", "TrnServiceHeaderID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TrnServiceHeader", "VehicleID", "dbo.Vehicle");
            DropForeignKey("dbo.TrnServiceRow", "TrnServiceHeaderID", "dbo.TrnServiceHeader");
            DropForeignKey("dbo.Item", "TrnServiceHeader_TrnServiceHeaderID", "dbo.TrnServiceHeader");
            DropForeignKey("dbo.TrnServiceHeader", "CustomerID", "dbo.Customer");
            DropForeignKey("dbo.TrnServiceRow", "ItemID", "dbo.Item");
            DropIndex("dbo.TrnServiceHeader", "IDX_TrnServiceHeader_Composite1");
            DropIndex("dbo.TrnServiceRow", new[] { "ItemID" });
            DropIndex("dbo.TrnServiceRow", new[] { "TrnServiceHeaderID" });
            DropIndex("dbo.Item", new[] { "TrnServiceHeader_TrnServiceHeaderID" });
            DropColumn("dbo.Item", "TrnServiceHeader_TrnServiceHeaderID");
            DropTable("dbo.TrnServiceHeader");
            DropTable("dbo.TrnServiceRow");
        }
    }
}
