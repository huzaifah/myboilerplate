using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using MyFirstBoilerPlate.Configuration.Dto;

namespace MyFirstBoilerPlate.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MyFirstBoilerPlateAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
