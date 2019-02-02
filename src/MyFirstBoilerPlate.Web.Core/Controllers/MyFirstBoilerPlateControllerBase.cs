using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace MyFirstBoilerPlate.Controllers
{
    public abstract class MyFirstBoilerPlateControllerBase: AbpController
    {
        protected MyFirstBoilerPlateControllerBase()
        {
            LocalizationSourceName = MyFirstBoilerPlateConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
