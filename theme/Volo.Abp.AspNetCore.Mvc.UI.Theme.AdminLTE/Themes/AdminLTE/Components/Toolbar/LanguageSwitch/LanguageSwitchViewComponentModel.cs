using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Localization;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.Themes.AdminLTE.Components.Toolbar
{
    public class LanguageSwitchViewComponentModel
    {
        public LanguageInfo CurrentLanguage { get; set; }

        public List<LanguageInfo> OtherLanguages { get; set; }
    }
}
