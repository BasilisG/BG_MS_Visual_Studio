namespace Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Garage_Studio_Machine_CF8 : DbMigration
    {
        public override void Up()
        {
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
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Proffesion", "IDX_UNQ_Proffession_Descr");
            DropTable("dbo.Proffesion");
        }
    }
}
