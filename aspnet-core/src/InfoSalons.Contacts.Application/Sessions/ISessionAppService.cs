using System.Threading.Tasks;
using Abp.Application.Services;
using InfoSalons.Contacts.Sessions.Dto;

namespace InfoSalons.Contacts.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
