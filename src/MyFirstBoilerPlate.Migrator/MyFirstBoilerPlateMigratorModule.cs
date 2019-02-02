using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyFirstBoilerPlate.Configuration;
using MyFirstBoilerPlate.EntityFrameworkCore;
using MyFirstBoilerPlate.Migrator.DependencyInjection;

namespace MyFirstBoilerPlate.Migrator
{
    [DependsOn(typeof(MyFirstBoilerPlateEntityFrameworkModule))]
    public class MyFirstBoilerPlateMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public MyFirstBoilerPlateMigratorModule(MyFirstBoilerPlateEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(MyFirstBoilerPlateMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                MyFirstBoilerPlateConsts.ConnectionStringName
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
            IocManager.RegisterAssemblyByConvention(typeof(MyFirstBoilerPlateMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
