using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace SanMeiPlat.EntityFrameworkCore
{
    public static class SanMeiPlatDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<SanMeiPlatDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<SanMeiPlatDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
