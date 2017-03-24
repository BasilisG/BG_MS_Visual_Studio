namespace EF_Sample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Activities",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        DateInserted = c.DateTime(nullable: false),
                        ActivityTypeID = c.Int(nullable: false),
                        ContactID = c.Guid(nullable: false),
                        Comments = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ActivityTypes", t => t.ActivityTypeID)
                .ForeignKey("dbo.Contacts", t => t.ContactID)
                .Index(t => t.ActivityTypeID)
                .Index(t => t.ContactID);
            
            CreateTable(
                "dbo.ActivityTypes",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Code = c.String(maxLength: 50),
                        Description = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        FirstName = c.String(maxLength: 100),
                        LastName = c.String(maxLength: 100),
                        Comments = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Activities", "ContactID", "dbo.Contacts");
            DropForeignKey("dbo.Activities", "ActivityTypeID", "dbo.ActivityTypes");
            DropIndex("dbo.Activities", new[] { "ContactID" });
            DropIndex("dbo.Activities", new[] { "ActivityTypeID" });
            DropTable("dbo.Contacts");
            DropTable("dbo.ActivityTypes");
            DropTable("dbo.Activities");
        }
    }
}
