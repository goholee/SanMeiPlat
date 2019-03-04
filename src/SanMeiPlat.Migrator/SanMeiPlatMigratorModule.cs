using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SanMeiPlat.Configuration;
using SanMeiPlat.EntityFrameworkCore;
using SanMeiPlat.Migrator.DependencyInjection;

namespace SanMeiPlat.Migrator
{
    [DependsOn(typeof(SanMeiPlatEntityFrameworkModule))]
    public class SanMeiPlatMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public SanMeiPlatMigratorModule(SanMeiPlatEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(SanMeiPlatMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                SanMeiPlatConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SanMeiPlatMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
