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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserProfile>()
                .HasMany<UserProfile>(s => s.Followed)
                .WithMany(c => c.Followers)
                .Map(cs =>
                {
                    cs.MapLeftKey("User_Id");
                    cs.MapRightKey("FollowedUser_Id");
                    cs.ToTable("Follows");
                });
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}