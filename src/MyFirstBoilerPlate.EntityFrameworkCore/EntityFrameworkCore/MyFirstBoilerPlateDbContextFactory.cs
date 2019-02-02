using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using MyFirstBoilerPlate.Configuration;
using MyFirstBoilerPlate.Web;

namespace MyFirstBoilerPlate.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class MyFirstBoilerPlateDbContextFactory : IDesignTimeDbContextFactory<MyFirstBoilerPlateDbContext>
    {
        public MyFirstBoilerPlateDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MyFirstBoilerPlateDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            MyFirstBoilerPlateDbContextConfigurer.Configure(builder, configuration.GetConnectionString(MyFirstBoilerPlateConsts.ConnectionStringName));

            return new MyFirstBoilerPlateDbContext(builder.Options);
        }
    }
}
