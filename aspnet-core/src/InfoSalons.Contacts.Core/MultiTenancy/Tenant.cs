using Abp.MultiTenancy;
using InfoSalons.Contacts.Authorization.Users;

namespace InfoSalons.Contacts.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
