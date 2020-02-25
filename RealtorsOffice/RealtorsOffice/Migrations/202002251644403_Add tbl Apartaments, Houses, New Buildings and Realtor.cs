namespace RealtorsOffice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddtblApartamentsHousesNewBuildingsandRealtor : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MoreInfoRealtors",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        NameCompany = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MoreInfoRealtors", "Id", "dbo.AspNetUsers");
            DropIndex("dbo.MoreInfoRealtors", new[] { "Id" });
            DropTable("dbo.MoreInfoRealtors");
        }
    }
}
