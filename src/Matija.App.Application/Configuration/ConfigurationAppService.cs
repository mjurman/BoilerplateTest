using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Matija.App.Configuration.Dto;

namespace Matija.App.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AppAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
