using System.Threading.Tasks;
using InfoSalons.Contacts.Configuration.Dto;

namespace InfoSalons.Contacts.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
