using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace InfoSalons.Contacts.EntityFrameworkCore
{
    public static class ContactsDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ContactsDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ContactsDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
