using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using SuperRocket.AspNetCoreVue.Configuration.Dto;

namespace SuperRocket.AspNetCoreVue.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AspNetCoreVueAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
