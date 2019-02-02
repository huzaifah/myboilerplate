using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyFirstBoilerPlate.Authorization;

namespace MyFirstBoilerPlate
{
    [DependsOn(
        typeof(MyFirstBoilerPlateCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MyFirstBoilerPlateApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MyFirstBoilerPlateAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(MyFirstBoilerPlateApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
