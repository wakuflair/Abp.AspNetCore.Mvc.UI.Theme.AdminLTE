# Abp.AspNetCore.Mvc.UI.Theme.AdminLTE

[![NuGet](https://img.shields.io/nuget/v/Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.svg?style=flat-square)](https://www.nuget.org/packages/Abp.AspNetCore.Mvc.UI.Theme.AdminLTE)
[![NuGet Download](https://img.shields.io/nuget/dt/Abp.AspNetCore.Mvc.UI.Theme.AdminLTE.svg?style=flat-square)](https://www.nuget.org/packages/Abp.AspNetCore.Mvc.UI.Theme.AdminLTE)

An [ABP](http://abp.io) theme module based on [AdminLTE](https://adminlte.io/)

![demo](doc/images/demo.png)

# How to use

1. Install nuget package
    
    * Web project:

        `Install-Package Abp.AspNetCore.Mvc.UI.Theme.AdminLTE`

1. Replace theme module depend

    * Web project:

        ``` csharp
        ...
        [DependsOn(
            ...
            // typeof(AbpAspNetCoreMvcUiBasicThemeModule),
            typeof(AbpAspNetCoreMvcUiAdminLTEThemeModule),
            ...
        ]
        public class YourWebModule : AbpModule
        {
            ...
        }
        ```

1. Enjoy
