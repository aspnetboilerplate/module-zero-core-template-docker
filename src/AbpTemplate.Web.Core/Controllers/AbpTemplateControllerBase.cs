using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace AbpTemplate.Controllers
{
    public abstract class AbpTemplateControllerBase: AbpController
    {
        protected AbpTemplateControllerBase()
        {
            LocalizationSourceName = AbpTemplateConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
