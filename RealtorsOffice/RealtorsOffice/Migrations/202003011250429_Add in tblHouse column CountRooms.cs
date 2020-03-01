namespace RealtorsOffice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddintblHousecolumnCountRooms : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Houses", "CountRooms", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Houses", "CountRooms");
        }
    }
}
