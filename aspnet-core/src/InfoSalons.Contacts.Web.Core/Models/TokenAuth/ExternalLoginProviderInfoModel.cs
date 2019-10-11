using Abp.AutoMapper;
using InfoSalons.Contacts.Authentication.External;

namespace InfoSalons.Contacts.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
