using Abp.Authorization;
using InfoSalons.Contacts.Authorization.Roles;
using InfoSalons.Contacts.Authorization.Users;

namespace InfoSalons.Contacts.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
