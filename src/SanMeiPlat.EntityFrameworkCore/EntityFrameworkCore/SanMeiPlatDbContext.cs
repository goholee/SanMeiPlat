using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using SanMeiPlat.Authorization.Roles;
using SanMeiPlat.Authorization.Users;
using SanMeiPlat.MultiTenancy;

namespace SanMeiPlat.EntityFrameworkCore
{
    public class SanMeiPlatDbContext : AbpZeroDbContext<Tenant, Role, User, SanMeiPlatDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public SanMeiPlatDbContext(DbContextOptions<SanMeiPlatDbContext> options)
            : base(options)
        {
        }

        public DbSet<Courses.Courses> Courses { get; set; }
        public DbSet<CourseTypes.CourseTypes> courseTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CourseTypes.CourseTypes>().ToTable("CourseTypes", "SM");
            modelBuilder.Entity<Courses.Courses>().ToTable("Courses", "SM");

            base.OnModelCreating(modelBuilder);
        }




    }
}
