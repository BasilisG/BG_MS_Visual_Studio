namespace Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Garage_Studio_Machine_CF4 : DbMigration
    {
        public override void Up()
        {
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
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.ItemType", "IDX_ItemType_Code");
            DropTable("dbo.ItemType");
        }
    }
}
