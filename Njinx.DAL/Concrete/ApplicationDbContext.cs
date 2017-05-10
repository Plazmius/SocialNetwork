using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using Njinx.Core.Entities;

namespace Njinx.DAL.Concrete
{

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        //TODO: add repos
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Follow> Follows { get; set; }

        public ApplicationDbContext()
            : base("NjinxConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}