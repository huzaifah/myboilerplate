using Abp.Authorization;
using MyFirstBoilerPlate.Authorization.Roles;
using MyFirstBoilerPlate.Authorization.Users;

namespace MyFirstBoilerPlate.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
