namespace Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Garage_Studio_Machine_CF3 : DbMigration
    {
        public override void Up()
        {
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vehicle", "VehicleTypeID", "dbo.VehicleType");
            DropForeignKey("dbo.Vehicle", "ColorID", "dbo.Color");
            DropIndex("dbo.Vehicle", new[] { "ColorID" });
            DropIndex("dbo.Vehicle", new[] { "VehicleTypeID" });
            DropIndex("dbo.Vehicle", "IDX_UNQ_Vehicle_NumberPlate");
            DropTable("dbo.Vehicle");
        }
    }
}
