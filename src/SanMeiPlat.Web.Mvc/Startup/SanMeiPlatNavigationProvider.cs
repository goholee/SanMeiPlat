using Abp.Application.Navigation;
using Abp.Localization;
using SanMeiPlat.Authorization;

namespace SanMeiPlat.Web.Startup
{
    /// <summary>
    /// This class defines menus for the application.
    /// </summary>
    public class SanMeiPlatNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu
                .AddItem(
                    new MenuItemDefinition(
                        PageNames.Home,
                        L("HomePage"),
                        url: "",
                        icon: "home",
                        requiresAuthentication: true
                    )
                )
                .AddItem(
                    new MenuItemDefinition(
                        PageNames.About,
                        L("About"),
                        url: "About",
                        icon: "info"
                    )
                )
                .AddItem( //==== 一级菜单 课程中心====
                    new MenuItemDefinition(
                        "MultiLevelMenu",
                        new FixedLocalizableString("课程中心"),
                        icon: "menu"
                    )
                    .AddItem( //---- 二级菜单 课程管理----
                        new MenuItemDefinition(
                            PageNames.Courses,
                            new FixedLocalizableString("课程管理"),
                            url: "Courses?skipCount=0&maxResultCount=10",
                            icon: "local_offer"
                        )
                    )
                    .AddItem( //---- 二级菜单 班级管理----
                        new MenuItemDefinition(
                            PageNames.Courses,
                            new FixedLocalizableString("班级管理"),
                            url: "Courses?skipCount=0&maxResultCount=10",
                            icon: "local_offer"
                        )
                    )
                ).AddItem( //==== 一级菜单 系统管理====
                    new MenuItemDefinition(
                        "MultiLevelMenu",
                        new FixedLocalizableString("系统管理"),
                        icon: "menu"
                    ).AddItem( //---- 二级菜单 课程类型----
                        new MenuItemDefinition(
                            PageNames.CourseTypes,
                            new FixedLocalizableString("课程类型"),
                            url: "CourseTypes?skipCount=0&maxResultCount=10",
                            icon: "local_offer"
                        )
                    ).AddItem( //---- 二级菜单 租户（禁用）----
                        new MenuItemDefinition(
                            PageNames.Tenants,
                            L("Tenants"),
                            url: "Tenants",
                            icon: "business",
                            requiredPermissionName: PermissionNames.Pages_Tenants
                        )
                    ).AddItem( //---- 二级菜单 用户----
                        new MenuItemDefinition(
                            PageNames.Users,
                            L("Users"),
                            url: "Users",
                            icon: "people",
                            requiredPermissionName: PermissionNames.Pages_Users
                        )
                    ).AddItem( //---- 二级菜单 角色----
                        new MenuItemDefinition(
                            PageNames.Roles,
                            L("Roles"),
                            url: "Roles",
                            icon: "local_offer",
                            requiredPermissionName: PermissionNames.Pages_Roles
                        )
                    )
                ).AddItem( // 一级菜单  多级菜单
                    new MenuItemDefinition(
                        "MultiLevelMenu",
                        L("MultiLevelMenu"),
                        icon: "menu"
                    ).AddItem(
                        new MenuItemDefinition(
                            "AspNetBoilerplate",
                            new FixedLocalizableString("ASP.NET Boilerplate")
                        ).AddItem(
                            new MenuItemDefinition(
                                "AspNetBoilerplateHome",
                                new FixedLocalizableString("Home"),
                                url: "https://aspnetboilerplate.com?ref=abptmpl"
                            )
                        ).AddItem(
                            new MenuItemDefinition(
                                "AspNetBoilerplateTemplates",
                                new FixedLocalizableString("Templates"),
                                url: "https://aspnetboilerplate.com/Templates?ref=abptmpl"
                            )
                        ).AddItem(
                            new MenuItemDefinition(
                                "AspNetBoilerplateSamples",
                                new FixedLocalizableString("Samples"),
                                url: "https://aspnetboilerplate.com/Samples?ref=abptmpl"
                            )
                        ).AddItem(
                            new MenuItemDefinition(
                                "AspNetBoilerplateDocuments",
                                new FixedLocalizableString("Documents"),
                                url: "https://aspnetboilerplate.com/Pages/Documents?ref=abptmpl"
                            )
                        )
                    ).AddItem(
                        new MenuItemDefinition(
                            "AspNetZero",
                            new FixedLocalizableString("ASP.NET Zero")
                        ).AddItem(
                            new MenuItemDefinition(
                                "AspNetZeroHome",
                                new FixedLocalizableString("Home"),
                                url: "https://aspnetzero.com?ref=abptmpl"
                            )
                        ).AddItem(
                            new MenuItemDefinition(
                                "AspNetZeroDescription",
                                new FixedLocalizableString("Description"),
                                url: "https://aspnetzero.com/?ref=abptmpl#description"
                            )
                        ).AddItem(
                            new MenuItemDefinition(
                                "AspNetZeroFeatures",
                                new FixedLocalizableString("Features"),
                                url: "https://aspnetzero.com/?ref=abptmpl#features"
                            )
                        ).AddItem(
                            new MenuItemDefinition(
                                "AspNetZeroPricing",
                                new FixedLocalizableString("Pricing"),
                                url: "https://aspnetzero.com/?ref=abptmpl#pricing"
                            )
                        ).AddItem(
                            new MenuItemDefinition(
                                "AspNetZeroFaq",
                                new FixedLocalizableString("Faq"),
                                url: "https://aspnetzero.com/Faq?ref=abptmpl"
                            )
                        ).AddItem(
                            new MenuItemDefinition(
                                "AspNetZeroDocuments",
                                new FixedLocalizableString("Documents"),
                                url: "https://aspnetzero.com/Documents?ref=abptmpl"
                            )
                        )
                    )
                );
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, SanMeiPlatConsts.LocalizationSourceName);
        }
    }
}
