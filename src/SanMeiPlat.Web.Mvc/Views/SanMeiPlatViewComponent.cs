using Abp.AspNetCore.Mvc.ViewComponents;

namespace SanMeiPlat.Web.Views
{
    public abstract class SanMeiPlatViewComponent : AbpViewComponent
    {
        protected SanMeiPlatViewComponent()
        {
            LocalizationSourceName = SanMeiPlatConsts.LocalizationSourceName;
        }
    }
}
