using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using InfoSalons.Contacts.MultiTenancy;

namespace InfoSalons.Contacts.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
