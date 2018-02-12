using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using AbpTemplate.Configuration.Dto;

namespace AbpTemplate.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AbpTemplateAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
