using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace InfoSalons.Contacts.Controllers
{
    public abstract class ContactsControllerBase: AbpController
    {
        protected ContactsControllerBase()
        {
            LocalizationSourceName = ContactsConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
