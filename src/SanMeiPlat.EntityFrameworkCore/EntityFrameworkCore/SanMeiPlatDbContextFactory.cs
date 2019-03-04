using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using SanMeiPlat.Configuration;
using SanMeiPlat.Web;

namespace SanMeiPlat.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class SanMeiPlatDbContextFactory : IDesignTimeDbContextFactory<SanMeiPlatDbContext>
    {
        public SanMeiPlatDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<SanMeiPlatDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            SanMeiPlatDbContextConfigurer.Configure(builder, configuration.GetConnectionString(SanMeiPlatConsts.ConnectionStringName));

            return new SanMeiPlatDbContext(builder.Options);
        }
    }
}
