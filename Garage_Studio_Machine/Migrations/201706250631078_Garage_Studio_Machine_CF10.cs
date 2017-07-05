namespace ViewModels.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Garage_Studio_Machine_CF10 : DbMigration
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
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Color", "IDX_Color_Descr");
            DropTable("dbo.Color");
        }
    }
}
