using Abp.Application.Services;
using Abp.Application.Services.Dto;
using InfoSalons.Contacts.MultiTenancy.Dto;

namespace InfoSalons.Contacts.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

