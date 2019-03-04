﻿using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace SanMeiPlat.Localization
{
    public static class SanMeiPlatLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(SanMeiPlatConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(SanMeiPlatLocalizationConfigurer).GetAssembly(),
                        "SanMeiPlat.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
