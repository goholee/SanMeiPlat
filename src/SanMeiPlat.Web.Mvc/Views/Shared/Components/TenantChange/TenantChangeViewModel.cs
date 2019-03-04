using Abp.AutoMapper;
using SanMeiPlat.Sessions.Dto;

namespace SanMeiPlat.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
