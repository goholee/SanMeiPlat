using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace SanMeiPlat.Controllers
{
    public abstract class SanMeiPlatControllerBase: AbpController
    {
        protected SanMeiPlatControllerBase()
        {
            LocalizationSourceName = SanMeiPlatConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
