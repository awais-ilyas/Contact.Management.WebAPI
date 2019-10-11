using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using InfoSalons.Contacts.Configuration;

namespace InfoSalons.Contacts.Web.Host.Startup
{
    [DependsOn(
       typeof(ContactsWebCoreModule))]
    public class ContactsWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ContactsWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ContactsWebHostModule).GetAssembly());
        }
    }
}
