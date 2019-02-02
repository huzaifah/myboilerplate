using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MyFirstBoilerPlate.Authorization.Roles;
using MyFirstBoilerPlate.Authorization.Users;
using MyFirstBoilerPlate.MultiTenancy;
using MyFirstBoilerPlate.Tasks;

namespace MyFirstBoilerPlate.EntityFrameworkCore
{
    public class MyFirstBoilerPlateDbContext : AbpZeroDbContext<Tenant, Role, User, MyFirstBoilerPlateDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Task> Tasks { get; set; }

        public MyFirstBoilerPlateDbContext(DbContextOptions<MyFirstBoilerPlateDbContext> options)
            : base(options)
        {
        }
    }
}
