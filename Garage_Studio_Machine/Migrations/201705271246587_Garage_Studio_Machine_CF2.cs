namespace Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Garage_Studio_Machine_CF2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Item",
                c => new
                    {
                        ItemID = c.Guid(nullable: false),
                        Code = c.String(nullable: false, maxLength: 50),
                        Description = c.String(nullable: false, maxLength: 200),
                        isActive = c.Boolean(nullable: false),
                        ItemType = c.Int(nullable: false),
                        UnitID = c.Guid(nullable: false),
                        VatID = c.Guid(nullable: false),
                        CostPrice = c.Double(nullable: false),
                        LastCostPrice = c.Double(nullable: false),
                        GrossPrice = c.Double(nullable: false),
                        RetailPrice = c.Double(nullable: false),
                        Pricce2 = c.Double(nullable: false),
                        Pricce3 = c.Double(nullable: false),
                        Pricce4 = c.Double(nullable: false),
                        Pricce5 = c.Double(nullable: false),
                        ItemDiscount = c.Double(nullable: false),
                        ItemMaxDiscount = c.Double(nullable: false),
                        Comments = c.String(),
                        AlertMessage = c.String(),
                        BrandNameID = c.Guid(nullable: false),
                        GroupCode = c.String(maxLength: 100),
                        RefCode = c.String(maxLength: 100),
                        Barcode1 = c.String(maxLength: 50),
                        Barcode2 = c.String(maxLength: 50),
                        Barcode3 = c.String(maxLength: 50),
                        UserID = c.Guid(nullable: false),
                        Date_Ins = c.DateTime(),
                        Date_Upd = c.DateTime(),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.ItemID)
                .ForeignKey("dbo.Unit", t => t.UnitID)
                .ForeignKey("dbo.Vat", t => t.VatID)
                .Index(t => t.Code, unique: true, name: "IDX_UNQ_Item_Code")
                .Index(t => t.UnitID)
                .Index(t => t.VatID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Item", "VatID", "dbo.Vat");
            DropForeignKey("dbo.Item", "UnitID", "dbo.Unit");
            DropIndex("dbo.Item", new[] { "VatID" });
            DropIndex("dbo.Item", new[] { "UnitID" });
            DropIndex("dbo.Item", "IDX_UNQ_Item_Code");
            DropTable("dbo.Item");
        }
    }
}
