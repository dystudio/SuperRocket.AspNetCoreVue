using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace SuperRocket.AspNetCoreVue.Localization
{
    public static class AspNetCoreVueLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(AspNetCoreVueConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(AspNetCoreVueLocalizationConfigurer).GetAssembly(),
                        "SuperRocket.AspNetCoreVue.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
