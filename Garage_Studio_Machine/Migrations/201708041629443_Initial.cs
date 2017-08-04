namespace Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Color",
                c => new
                    {
                        ColorID = c.Guid(nullable: false),
                        Description = c.String(nullable: false, maxLength: 50),
                        Date_Ins = c.DateTime(),
                        Date_Upd = c.DateTime(),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.ColorID)
                .Index(t => t.Description, unique: true, name: "IDX_Color_Descr");
            
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        CustomerID = c.Guid(nullable: false),
                        Code = c.String(nullable: false, maxLength: 50),
                        TaxName = c.String(maxLength: 200),
                        TaxNumber = c.String(maxLength: 20),
                        FirstName = c.String(maxLength: 100),
                        LastName = c.String(maxLength: 100),
                        ProffesionID = c.Guid(nullable: false),
                        AdrStreet = c.String(maxLength: 100),
                        AdrNumber = c.String(maxLength: 20),
                        AdrCity = c.String(maxLength: 100),
                        AdrDistrict = c.String(maxLength: 100),
                        AdrZipCode = c.String(maxLength: 20),
                        AdrPhone1 = c.String(maxLength: 50),
                        AdrPhone2 = c.String(maxLength: 50),
                        AdrPhone3 = c.String(maxLength: 50),
                        AdrFax = c.String(maxLength: 50),
                        AdrEmail = c.String(maxLength: 100),
                        Comment = c.String(maxLength: 500),
                        AlertMessage = c.String(maxLength: 500),
                        UserID = c.Guid(nullable: false),
                        Date_Ins = c.DateTime(),
                        Date_Upd = c.DateTime(),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.CustomerID)
                .ForeignKey("dbo.Proffesion", t => t.ProffesionID)
                .Index(t => t.Code, unique: true, name: "IDX_UNQ_Customer_Code")
                .Index(t => t.ProffesionID);
            
            CreateTable(
                "dbo.Proffesion",
                c => new
                    {
                        ProffesionID = c.Guid(nullable: false),
                        Description = c.String(nullable: false, maxLength: 200),
                        UserID = c.Guid(nullable: false),
                        Date_Ins = c.DateTime(),
                        Date_Upd = c.DateTime(),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.ProffesionID)
                .Index(t => t.Description, unique: true, name: "IDX_UNQ_Proffession_Descr");
            
            CreateTable(
                "dbo.Item",
                c => new
                    {
                        ItemID = c.Guid(nullable: false),
                        Code = c.String(nullable: false, maxLength: 50),
                        Description = c.String(nullable: false, maxLength: 200),
                        isActive = c.Boolean(nullable: false),
                        ItemTypeID = c.Guid(nullable: false),
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
                .ForeignKey("dbo.ItemType", t => t.ItemTypeID)
                .ForeignKey("dbo.Unit", t => t.UnitID)
                .ForeignKey("dbo.Vat", t => t.VatID)
                .Index(t => t.Code, unique: true, name: "IDX_UNQ_Item_Code")
                .Index(t => t.ItemTypeID)
                .Index(t => t.UnitID)
                .Index(t => t.VatID);
            
            CreateTable(
                "dbo.ItemType",
                c => new
                    {
                        ItemTypeID = c.Guid(nullable: false),
                        Code = c.String(nullable: false, maxLength: 50),
                        Description = c.String(nullable: false, maxLength: 100),
                        Date_Ins = c.DateTime(),
                        Date_Upd = c.DateTime(),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.ItemTypeID)
                .Index(t => t.Code, unique: true, name: "IDX_ItemType_Code");
            
            CreateTable(
                "dbo.Unit",
                c => new
                    {
                        UnitID = c.Guid(nullable: false),
                        Code = c.String(nullable: false, maxLength: 50),
                        Description = c.String(nullable: false, maxLength: 200),
                        UserID = c.Guid(nullable: false),
                        Date_Ins = c.DateTime(),
                        Date_Upd = c.DateTime(),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.UnitID)
                .Index(t => t.Code, unique: true, name: "IDX_Unit_Code");
            
            CreateTable(
                "dbo.Vat",
                c => new
                    {
                        VatID = c.Guid(nullable: false),
                        Code = c.String(nullable: false, maxLength: 50),
                        Description = c.String(nullable: false, maxLength: 200),
                        VatRate_1 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        VatRate_2 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        VatRate_3 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        UserID = c.Guid(nullable: false),
                        Date_Ins = c.DateTime(),
                        Date_Upd = c.DateTime(),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.VatID)
                .Index(t => t.Code, unique: true, name: "IDX_UNQ_Vat_Code");
            
            CreateTable(
                "dbo.Vehicle",
                c => new
                    {
                        VehicleID = c.Guid(nullable: false),
                        NumberPlate = c.String(nullable: false, maxLength: 50),
                        Description = c.String(nullable: false, maxLength: 200),
                        VehicleTypeID = c.Guid(nullable: false),
                        ColorID = c.Guid(nullable: false),
                        ModelID = c.Guid(nullable: false),
                        EngineCubic = c.Double(nullable: false),
                        FirstDate = c.DateTime(nullable: false),
                        NumberDoors = c.Int(nullable: false),
                        NumberChassis = c.String(maxLength: 100),
                        NumberEngine = c.String(maxLength: 100),
                        Comments = c.String(maxLength: 2048),
                        UserID = c.Guid(nullable: false),
                        Date_Ins = c.DateTime(),
                        Date_Upd = c.DateTime(),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.VehicleID)
                .ForeignKey("dbo.Color", t => t.ColorID)
                .ForeignKey("dbo.VehicleType", t => t.VehicleTypeID)
                .Index(t => t.NumberPlate, unique: true, name: "IDX_UNQ_Vehicle_NumberPlate")
                .Index(t => t.VehicleTypeID)
                .Index(t => t.ColorID);
            
            CreateTable(
                "dbo.VehicleType",
                c => new
                    {
                        VehicleTypeID = c.Guid(nullable: false),
                        Code = c.String(nullable: false, maxLength: 50),
                        Description = c.String(nullable: false, maxLength: 100),
                        Date_Ins = c.DateTime(),
                        Date_Upd = c.DateTime(),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.VehicleTypeID)
                .Index(t => t.Code, unique: true, name: "IDX_VehicleType_Code");
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vehicle", "VehicleTypeID", "dbo.VehicleType");
            DropForeignKey("dbo.Vehicle", "ColorID", "dbo.Color");
            DropForeignKey("dbo.Item", "VatID", "dbo.Vat");
            DropForeignKey("dbo.Item", "UnitID", "dbo.Unit");
            DropForeignKey("dbo.Item", "ItemTypeID", "dbo.ItemType");
            DropForeignKey("dbo.Customer", "ProffesionID", "dbo.Proffesion");
            DropIndex("dbo.VehicleType", "IDX_VehicleType_Code");
            DropIndex("dbo.Vehicle", new[] { "ColorID" });
            DropIndex("dbo.Vehicle", new[] { "VehicleTypeID" });
            DropIndex("dbo.Vehicle", "IDX_UNQ_Vehicle_NumberPlate");
            DropIndex("dbo.Vat", "IDX_UNQ_Vat_Code");
            DropIndex("dbo.Unit", "IDX_Unit_Code");
            DropIndex("dbo.ItemType", "IDX_ItemType_Code");
            DropIndex("dbo.Item", new[] { "VatID" });
            DropIndex("dbo.Item", new[] { "UnitID" });
            DropIndex("dbo.Item", new[] { "ItemTypeID" });
            DropIndex("dbo.Item", "IDX_UNQ_Item_Code");
            DropIndex("dbo.Proffesion", "IDX_UNQ_Proffession_Descr");
            DropIndex("dbo.Customer", new[] { "ProffesionID" });
            DropIndex("dbo.Customer", "IDX_UNQ_Customer_Code");
            DropIndex("dbo.Color", "IDX_Color_Descr");
            DropTable("dbo.VehicleType");
            DropTable("dbo.Vehicle");
            DropTable("dbo.Vat");
            DropTable("dbo.Unit");
            DropTable("dbo.ItemType");
            DropTable("dbo.Item");
            DropTable("dbo.Proffesion");
            DropTable("dbo.Customer");
            DropTable("dbo.Color");
        }
    }
}
