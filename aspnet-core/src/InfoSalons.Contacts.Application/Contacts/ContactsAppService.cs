using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using Abp.Extensions;
using Abp.Linq.Extensions;
using Abp.UI;
using InfoSalons.Contacts.Contacts.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoSalons.Contacts.Contacts
{
    public class ContactsAppService : AsyncCrudAppService<Contact, ContactDto, int, PagesContactsRequestDto, CreateContactDto, UpdateContactDto>, IContactsAppService
    {
        private readonly IRepository<Contact, int> _contactsRepository;
        public ContactsAppService(IRepository<Contact, int> contactsRepository) : base(contactsRepository)
        {
            _contactsRepository = contactsRepository;
        }

        public override async Task<ContactDto> Create(CreateContactDto input)
        {
            var data = ObjectMapper.Map<Contact>(input);

            data.CreationTime = DateTime.Now;

            data.LastModificationTime = DateTime.Now;

            await _contactsRepository.InsertAsync(data);

            await CurrentUnitOfWork.SaveChangesAsync();

            return MapToEntityDto(data);
        }

        protected override IQueryable<Contact> ApplySorting(IQueryable<Contact> query, PagesContactsRequestDto input)
        {
            return query.OrderByDescending(x => x.CreationTime);
        }

        protected override IQueryable<Contact> CreateFilteredQuery(PagesContactsRequestDto input)
        {
            var data = Repository.GetAll()
                .WhereIf(!input.Keyword.IsNullOrWhiteSpace(),
                            x => x.FirstName.Contains(input.Keyword)
                            || x.LastName.Contains(input.Keyword)
                            || x.JobTitle.Contains(input.Keyword)
                            || x.Company.Equals(input.Keyword));

            return data;
        }

        private async Task<Contact> Get(int id)
        {
            var webhook = await _contactsRepository.FirstOrDefaultAsync(w => w.Id == id);
            if (webhook == null)
            {
                throw new EntityNotFoundException(typeof(Contact), id);
            }
            return webhook;
        }

        public override async Task<ContactDto> Update(UpdateContactDto input)
        {
            var webhook = await Get(input.Id);

            webhook = ObjectMapper.Map(input, webhook);

            webhook.LastModificationTime = DateTime.Now;

            await _contactsRepository.UpdateAsync(webhook);

            await CurrentUnitOfWork.SaveChangesAsync();

            return await Get(input);
        }

        public override async Task Delete(EntityDto<int> input)
        {
            var webhook = await Get(input.Id);

            await _contactsRepository.DeleteAsync(webhook);

            await CurrentUnitOfWork.SaveChangesAsync();
        }

    }
}
