using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using InfoSalons.Contacts.Authorization.Roles;
using InfoSalons.Contacts.Authorization.Users;
using InfoSalons.Contacts.MultiTenancy;
using InfoSalons.Contacts.Contacts;

namespace InfoSalons.Contacts.EntityFrameworkCore
{
    public class ContactsDbContext : AbpZeroDbContext<Tenant, Role, User, ContactsDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public virtual DbSet<Contact> InfoSalonsContacts { get; set; }


        public ContactsDbContext(DbContextOptions<ContactsDbContext> options)
            : base(options)
        {
        }
    }
}
