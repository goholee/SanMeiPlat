using System.Threading.Tasks;
using SanMeiPlat.Configuration.Dto;

namespace SanMeiPlat.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
