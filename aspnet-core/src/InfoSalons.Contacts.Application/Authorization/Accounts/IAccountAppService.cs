using System.Threading.Tasks;
using Abp.Application.Services;
using InfoSalons.Contacts.Authorization.Accounts.Dto;

namespace InfoSalons.Contacts.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
