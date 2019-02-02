using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MyFirstBoilerPlate.EntityFrameworkCore
{
    public static class MyFirstBoilerPlateDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MyFirstBoilerPlateDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MyFirstBoilerPlateDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
