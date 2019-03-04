using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SanMeiPlat.Configuration;

namespace SanMeiPlat.Web.Startup
{
    [DependsOn(typeof(SanMeiPlatWebCoreModule))]
    public class SanMeiPlatWebMvcModule : AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public SanMeiPlatWebMvcModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<SanMeiPlatNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SanMeiPlatWebMvcModule).GetAssembly());
        }
    }
}
