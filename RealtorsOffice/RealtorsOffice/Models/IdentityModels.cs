using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using RealtorsOffice.Entity.EntityModel;
using RealtorsOffice.Models.Communication;

namespace RealtorsOffice.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public DbSet<MoreInfoRealtor> MoreInfoRealtors { get; set; }

        public DbSet<RealtorApartment> RealtorApartments { get; set; }
        public DbSet<RealtorHouse> RealtorHouses { get; set; }
        public DbSet<RealtorNewApartment> RealtorNewApartments { get; set; }
        public DbSet<RealtorNewBuilding> RealtorNewBuildings { get; set; }

        public DbSet<ApartmentsModel> Apartments { get; set; }
        public DbSet<HouseModel> Houses { get; set; }
        public DbSet<NewBuildingModel> NewBuildings { get; set; }
        public DbSet<NewApartmentsModel> NewApartments { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}