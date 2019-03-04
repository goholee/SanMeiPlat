using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SanMeiPlat.Authorization;

namespace SanMeiPlat
{
    [DependsOn(
        typeof(SanMeiPlatCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class SanMeiPlatApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<SanMeiPlatAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(SanMeiPlatApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
