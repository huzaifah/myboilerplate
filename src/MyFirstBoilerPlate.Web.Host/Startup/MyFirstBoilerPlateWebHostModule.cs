using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyFirstBoilerPlate.Configuration;

namespace MyFirstBoilerPlate.Web.Host.Startup
{
    [DependsOn(
       typeof(MyFirstBoilerPlateWebCoreModule))]
    public class MyFirstBoilerPlateWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public MyFirstBoilerPlateWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyFirstBoilerPlateWebHostModule).GetAssembly());
        }
    }
}
