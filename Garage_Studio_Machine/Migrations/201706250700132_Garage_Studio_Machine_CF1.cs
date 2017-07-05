namespace Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Garage_Studio_Machine_CF1 : DbMigration
    {
        public override void Up()
        {
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
            DropIndex("dbo.VehicleType", "IDX_VehicleType_Code");
            DropTable("dbo.VehicleType");
        }
    }
}
