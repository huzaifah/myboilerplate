using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using MyFirstBoilerPlate.EntityFrameworkCore.Seed;

namespace MyFirstBoilerPlate.EntityFrameworkCore
{
    [DependsOn(
        typeof(MyFirstBoilerPlateCoreModule), 
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class MyFirstBoilerPlateEntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void PreInitialize()
        {
            if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<MyFirstBoilerPlateDbContext>(options =>
                {
                    if (options.ExistingConnection != null)
                    {
                        MyFirstBoilerPlateDbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                    }
                    else
                    {
                        MyFirstBoilerPlateDbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                    }
                });
            }
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyFirstBoilerPlateEntityFrameworkModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            if (!SkipDbSeed)
            {
                SeedHelper.SeedHostDb(IocManager);
            }
        }
    }
}
