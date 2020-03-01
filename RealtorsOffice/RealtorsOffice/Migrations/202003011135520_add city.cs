namespace RealtorsOffice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Apartments", "City", c => c.String(nullable: false));
            AddColumn("dbo.Houses", "City", c => c.String(nullable: false));
            AddColumn("dbo.NewBuildings", "City", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.NewBuildings", "City");
            DropColumn("dbo.Houses", "City");
            DropColumn("dbo.Apartments", "City");
        }
    }
}
