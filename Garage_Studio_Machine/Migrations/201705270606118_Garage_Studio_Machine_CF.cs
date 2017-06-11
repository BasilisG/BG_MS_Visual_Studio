namespace Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Garage_Studio_Machine_CF : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Unit", "Date_Ins", c => c.DateTime());
            AlterColumn("dbo.Unit", "Date_Upd", c => c.DateTime());
            AlterColumn("dbo.Vat", "Date_Ins", c => c.DateTime());
            AlterColumn("dbo.Vat", "Date_Upd", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Vat", "Date_Upd", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Vat", "Date_Ins", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Unit", "Date_Upd", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Unit", "Date_Ins", c => c.DateTime(nullable: false));
        }
    }
}
