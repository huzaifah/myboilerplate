using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace MyFirstBoilerPlate.Localization
{
    public static class MyFirstBoilerPlateLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(MyFirstBoilerPlateConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(MyFirstBoilerPlateLocalizationConfigurer).GetAssembly(),
                        "MyFirstBoilerPlate.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
