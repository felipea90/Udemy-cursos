using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using WebAPI.Domain;

namespace WebAPI.Repository
{
    public class Context : IdentityDbContext<User>
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<UserRole>(userRole =>
            {
                userRole.HasKey(ur => new { ur.UserId, ur.RoleId });
            });

            builder.Entity<Organization>(org =>
            {
                org.ToTable("Organizations");
                org.HasKey(x => x.Id);

                org.HasMany<User>()
                .WithOne()
                .HasForeignKey(x => x.OrgId)
                .IsRequired(false);
            });
        }
    }
}
