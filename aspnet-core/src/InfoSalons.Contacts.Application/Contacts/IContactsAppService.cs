using Abp.Application.Services;
using InfoSalons.Contacts.Contacts.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfoSalons.Contacts.Contacts
{
    public interface IContactsAppService : IAsyncCrudAppService<ContactDto, int, PagesContactsRequestDto, CreateContactDto, UpdateContactDto>
    {
    }
}
