namespace RealtorsOffice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addnamecolumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Apartments", "Name", c => c.String(nullable: false));
            AddColumn("dbo.Houses", "Name", c => c.String(nullable: false));
            AddColumn("dbo.tblNewApartmentsModel", "Name", c => c.String(nullable: false));
            AddColumn("dbo.NewBuildings", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.NewBuildings", "Name");
            DropColumn("dbo.tblNewApartmentsModel", "Name");
            DropColumn("dbo.Houses", "Name");
            DropColumn("dbo.Apartments", "Name");
        }
    }
}
