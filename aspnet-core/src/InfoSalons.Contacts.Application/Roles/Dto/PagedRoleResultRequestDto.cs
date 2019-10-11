using Abp.Application.Services.Dto;

namespace InfoSalons.Contacts.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

