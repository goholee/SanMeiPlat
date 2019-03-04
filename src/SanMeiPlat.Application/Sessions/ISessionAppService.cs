using System.Threading.Tasks;
using Abp.Application.Services;
using SanMeiPlat.Sessions.Dto;

namespace SanMeiPlat.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
