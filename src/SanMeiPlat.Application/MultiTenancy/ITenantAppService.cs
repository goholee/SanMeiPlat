using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SanMeiPlat.MultiTenancy.Dto;

namespace SanMeiPlat.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

