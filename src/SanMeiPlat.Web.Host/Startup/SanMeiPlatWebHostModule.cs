using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SanMeiPlat.Configuration;

namespace SanMeiPlat.Web.Host.Startup
{
    [DependsOn(
       typeof(SanMeiPlatWebCoreModule))]
    public class SanMeiPlatWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public SanMeiPlatWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SanMeiPlatWebHostModule).GetAssembly());
        }
    }
}
