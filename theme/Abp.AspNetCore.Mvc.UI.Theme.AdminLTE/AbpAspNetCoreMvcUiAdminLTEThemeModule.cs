using Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.Bundling;
using Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.Localization;
using Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.Toolbars;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AspNetCore.Mvc.UI.Bundling;
using Volo.Abp.AspNetCore.Mvc.UI.MultiTenancy;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Bundling;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Toolbars;
using Volo.Abp.AspNetCore.Mvc.UI.Theming;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Abp.AspNetCore.Mvc.UI.Theme.AdminLTE
{
    [DependsOn(
        typeof(AbpAspNetCoreMvcUiThemeSharedModule),
        typeof(AbpAspNetCoreMvcUiMultiTenancyModule)
        )]
    public class AbpAspNetCoreMvcUiAdminLTEThemeModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(AbpAspNetCoreMvcUiAdminLTEThemeModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpThemingOptions>(options =>
            {
                options.Themes.Add<AdminLTETheme>();

                // 应用主体风格
                options.DefaultThemeName = AdminLTETheme.Name;
            });

            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<AbpAspNetCoreMvcUiAdminLTEThemeModule>("Abp.AspNetCore.Mvc.UI.Theme.AdminLTE");
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Add<AdminLTEResource>("en")
                    .AddVirtualJson("/Localization/AdminLTE");
            });

            Configure<AbpToolbarOptions>(options =>
            {
                options.Contributors.Add(new AdminLTEThemeMainTopToolbarContributor());
            });

            Configure<RazorPagesOptions>(options =>
            {
                options.Conventions.AuthorizePage("/index");
            });

            Configure<AbpBundlingOptions>(options =>
            {
                options
                    .StyleBundles
                    .Add(AdminLTEThemeBundles.Styles.Global, bundle =>
                    {
                        bundle
                            .AddBaseBundles(StandardBundles.Styles.Global)
                            .AddContributors(typeof(AdminThemeGlobalStyleContributor));
                    });

                options
                    .ScriptBundles
                    .Add(AdminLTEThemeBundles.Scripts.Global, bundle =>
                    {
                        bundle
                            .AddBaseBundles(StandardBundles.Scripts.Global)
                            .AddContributors(typeof(AdminLTEThemeGlobalScriptContributor));
                    });
            });
        }
    }
}
