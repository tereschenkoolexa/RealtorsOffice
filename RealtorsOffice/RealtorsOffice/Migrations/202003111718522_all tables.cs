namespace RealtorsOffice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alltables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Apartments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        CountRooms = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Square = c.Double(nullable: false),
                        Parking = c.Boolean(nullable: false),
                        Warming = c.Boolean(nullable: false),
                        Repair = c.Boolean(nullable: false),
                        Picture = c.String(),
                        Floor = c.Int(nullable: false),
                        DistrictName = c.String(nullable: false),
                        StreetName = c.String(nullable: false),
                        City = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tblRealtorApartment",
                c => new
                    {
                        RealtorId = c.String(nullable: false, maxLength: 128),
                        ApartmentlId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.RealtorId, t.ApartmentlId })
                .ForeignKey("dbo.MoreInfoRealtors", t => t.RealtorId, cascadeDelete: true)
                .ForeignKey("dbo.Apartments", t => t.ApartmentlId, cascadeDelete: true)
                .Index(t => t.RealtorId)
                .Index(t => t.ApartmentlId);
            
            CreateTable(
                "dbo.MoreInfoRealtors",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        PhoneNumber = c.String(nullable: false),
                        NameCompany = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.tblRealtorHouse",
                c => new
                    {
                        RealtorId = c.String(nullable: false, maxLength: 128),
                        HouseId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.RealtorId, t.HouseId })
                .ForeignKey("dbo.Houses", t => t.HouseId, cascadeDelete: true)
                .ForeignKey("dbo.MoreInfoRealtors", t => t.RealtorId, cascadeDelete: true)
                .Index(t => t.RealtorId)
                .Index(t => t.HouseId);
            
            CreateTable(
                "dbo.Houses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        CountRooms = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Square = c.Double(nullable: false),
                        Parking = c.Boolean(nullable: false),
                        Warming = c.Boolean(nullable: false),
                        Repair = c.Boolean(nullable: false),
                        Picture = c.String(nullable: false),
                        DistrictName = c.String(nullable: false),
                        StreetName = c.String(nullable: false),
                        Floors = c.Int(nullable: false),
                        City = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tblRealtorNewApartment",
                c => new
                    {
                        RealtorId = c.String(nullable: false, maxLength: 128),
                        NewApartmentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.RealtorId, t.NewApartmentId })
                .ForeignKey("dbo.tblNewApartmentsModel", t => t.NewApartmentId, cascadeDelete: true)
                .ForeignKey("dbo.MoreInfoRealtors", t => t.RealtorId, cascadeDelete: true)
                .Index(t => t.RealtorId)
                .Index(t => t.NewApartmentId);
            
            CreateTable(
                "dbo.tblNewApartmentsModel",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        CountRooms = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Square = c.Double(nullable: false),
                        Picture = c.String(nullable: false),
                        Floor = c.Int(nullable: false),
                        IdBuilding = c.Int(nullable: false),
                        NewBuildingOf_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.NewBuildings", t => t.NewBuildingOf_Id)
                .Index(t => t.NewBuildingOf_Id);
            
            CreateTable(
                "dbo.NewBuildings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        StreetName = c.String(nullable: false),
                        DistrictName = c.String(nullable: false),
                        Picture = c.String(nullable: false),
                        Floors = c.Int(nullable: false),
                        Parking = c.Boolean(nullable: false),
                        Warming = c.Boolean(nullable: false),
                        ConstructionStatus = c.Boolean(nullable: false),
                        DateOfConstructed = c.Int(nullable: false),
                        City = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tblRealtorNewBuilding",
                c => new
                    {
                        RealtorId = c.String(nullable: false, maxLength: 128),
                        NewBuildingId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.RealtorId, t.NewBuildingId })
                .ForeignKey("dbo.MoreInfoRealtors", t => t.RealtorId, cascadeDelete: true)
                .ForeignKey("dbo.NewBuildings", t => t.NewBuildingId, cascadeDelete: true)
                .Index(t => t.RealtorId)
                .Index(t => t.NewBuildingId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.tblRealtorApartment", "ApartmentlId", "dbo.Apartments");
            DropForeignKey("dbo.tblRealtorApartment", "RealtorId", "dbo.MoreInfoRealtors");
            DropForeignKey("dbo.MoreInfoRealtors", "Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.tblRealtorNewApartment", "RealtorId", "dbo.MoreInfoRealtors");
            DropForeignKey("dbo.tblRealtorNewApartment", "NewApartmentId", "dbo.tblNewApartmentsModel");
            DropForeignKey("dbo.tblRealtorNewBuilding", "NewBuildingId", "dbo.NewBuildings");
            DropForeignKey("dbo.tblRealtorNewBuilding", "RealtorId", "dbo.MoreInfoRealtors");
            DropForeignKey("dbo.tblNewApartmentsModel", "NewBuildingOf_Id", "dbo.NewBuildings");
            DropForeignKey("dbo.tblRealtorHouse", "RealtorId", "dbo.MoreInfoRealtors");
            DropForeignKey("dbo.tblRealtorHouse", "HouseId", "dbo.Houses");
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.tblRealtorNewBuilding", new[] { "NewBuildingId" });
            DropIndex("dbo.tblRealtorNewBuilding", new[] { "RealtorId" });
            DropIndex("dbo.tblNewApartmentsModel", new[] { "NewBuildingOf_Id" });
            DropIndex("dbo.tblRealtorNewApartment", new[] { "NewApartmentId" });
            DropIndex("dbo.tblRealtorNewApartment", new[] { "RealtorId" });
            DropIndex("dbo.tblRealtorHouse", new[] { "HouseId" });
            DropIndex("dbo.tblRealtorHouse", new[] { "RealtorId" });
            DropIndex("dbo.MoreInfoRealtors", new[] { "Id" });
            DropIndex("dbo.tblRealtorApartment", new[] { "ApartmentlId" });
            DropIndex("dbo.tblRealtorApartment", new[] { "RealtorId" });
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.tblRealtorNewBuilding");
            DropTable("dbo.NewBuildings");
            DropTable("dbo.tblNewApartmentsModel");
            DropTable("dbo.tblRealtorNewApartment");
            DropTable("dbo.Houses");
            DropTable("dbo.tblRealtorHouse");
            DropTable("dbo.MoreInfoRealtors");
            DropTable("dbo.tblRealtorApartment");
            DropTable("dbo.Apartments");
        }
    }
}
