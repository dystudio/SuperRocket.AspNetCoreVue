using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace SuperRocket.AspNetCoreVue.Controllers
{
    public abstract class AspNetCoreVueControllerBase: AbpController
    {
        protected AspNetCoreVueControllerBase()
        {
            LocalizationSourceName = AspNetCoreVueConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
