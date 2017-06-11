namespace Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Unit",
                c => new
                    {
                        UnitID = c.Guid(nullable: false),
                        Code = c.String(nullable: false, maxLength: 50),
                        Description = c.String(nullable: false, maxLength: 200),
                        UserID = c.Guid(nullable: false),
                        Date_Ins = c.DateTime(nullable: false),
                        Date_Upd = c.DateTime(nullable: false),
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
                        Date_Ins = c.DateTime(nullable: false),
                        Date_Upd = c.DateTime(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.VatID)
                .Index(t => t.Code, unique: true, name: "IDX_UNQ_Vat_Code");
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Vat", "IDX_UNQ_Vat_Code");
            DropIndex("dbo.Unit", "IDX_Unit_Code");
            DropTable("dbo.Vat");
            DropTable("dbo.Unit");
        }
    }
}
