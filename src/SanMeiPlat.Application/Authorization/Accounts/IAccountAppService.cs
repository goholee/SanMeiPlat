using System.Threading.Tasks;
using Abp.Application.Services;
using SanMeiPlat.Authorization.Accounts.Dto;

namespace SanMeiPlat.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
