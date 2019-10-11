using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfoSalons.Contacts.Contacts.Dto
{
    public class PagesContactsRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}
