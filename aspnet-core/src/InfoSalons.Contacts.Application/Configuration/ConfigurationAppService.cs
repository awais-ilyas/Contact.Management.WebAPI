using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using InfoSalons.Contacts.Configuration.Dto;

namespace InfoSalons.Contacts.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ContactsAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
