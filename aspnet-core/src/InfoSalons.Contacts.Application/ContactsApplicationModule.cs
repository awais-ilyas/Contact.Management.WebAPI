using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using InfoSalons.Contacts.Authorization;

namespace InfoSalons.Contacts
{
    [DependsOn(
        typeof(ContactsCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ContactsApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ContactsAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ContactsApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
