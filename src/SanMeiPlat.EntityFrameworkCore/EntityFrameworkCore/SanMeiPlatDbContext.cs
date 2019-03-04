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
    }
}
