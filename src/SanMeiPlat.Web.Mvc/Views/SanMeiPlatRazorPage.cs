using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace SanMeiPlat.Web.Views
{
    public abstract class SanMeiPlatRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected SanMeiPlatRazorPage()
        {
            LocalizationSourceName = SanMeiPlatConsts.LocalizationSourceName;
        }
    }
}
