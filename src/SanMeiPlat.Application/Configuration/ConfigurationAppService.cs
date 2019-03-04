using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using SanMeiPlat.Configuration.Dto;

namespace SanMeiPlat.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : SanMeiPlatAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
