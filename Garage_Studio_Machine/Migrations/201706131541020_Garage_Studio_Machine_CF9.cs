namespace ViewModels.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Garage_Studio_Machine_CF9 : DbMigration
    {
        public override void Up()
        {
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customer", "ProffesionID", "dbo.Proffesion");
            DropIndex("dbo.Customer", new[] { "ProffesionID" });
            DropIndex("dbo.Customer", "IDX_UNQ_Customer_Code");
            DropTable("dbo.Customer");
        }
    }
}
