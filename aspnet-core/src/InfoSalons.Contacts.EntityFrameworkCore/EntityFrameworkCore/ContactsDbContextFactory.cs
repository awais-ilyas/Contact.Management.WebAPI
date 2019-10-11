using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using InfoSalons.Contacts.Configuration;
using InfoSalons.Contacts.Web;

namespace InfoSalons.Contacts.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ContactsDbContextFactory : IDesignTimeDbContextFactory<ContactsDbContext>
    {
        public ContactsDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ContactsDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ContactsDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ContactsConsts.ConnectionStringName));

            return new ContactsDbContext(builder.Options);
        }
    }
}
