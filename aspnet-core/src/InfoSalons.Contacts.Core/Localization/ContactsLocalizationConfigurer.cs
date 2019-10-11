using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace InfoSalons.Contacts.Localization
{
    public static class ContactsLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(ContactsConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(ContactsLocalizationConfigurer).GetAssembly(),
                        "InfoSalons.Contacts.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
