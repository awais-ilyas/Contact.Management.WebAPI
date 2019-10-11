using System.Collections.Generic;

namespace InfoSalons.Contacts.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
