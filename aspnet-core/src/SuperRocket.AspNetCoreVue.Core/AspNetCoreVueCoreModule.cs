using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Timing;
using Abp.Zero;
using Abp.Zero.Configuration;
using SuperRocket.AspNetCoreVue.Authorization.Roles;
using SuperRocket.AspNetCoreVue.Authorization.Users;
using SuperRocket.AspNetCoreVue.Configuration;
using SuperRocket.AspNetCoreVue.Localization;
using SuperRocket.AspNetCoreVue.MultiTenancy;
using SuperRocket.AspNetCoreVue.Timing;

namespace SuperRocket.AspNetCoreVue
{
    [DependsOn(typeof(AbpZeroCoreModule))]
    public class AspNetCoreVueCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            // Declare entity types
            Configuration.Modules.Zero().EntityTypes.Tenant = typeof(Tenant);
            Configuration.Modules.Zero().EntityTypes.Role = typeof(Role);
            Configuration.Modules.Zero().EntityTypes.User = typeof(User);

            AspNetCoreVueLocalizationConfigurer.Configure(Configuration.Localization);

            // Enable this line to create a multi-tenant application.
            Configuration.MultiTenancy.IsEnabled = AspNetCoreVueConsts.MultiTenancyEnabled;

            // Configure roles
            AppRoleConfig.Configure(Configuration.Modules.Zero().RoleManagement);

            Configuration.Settings.Providers.Add<AppSettingProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AspNetCoreVueCoreModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<AppTimes>().StartupTime = Clock.Now;
        }
    }
}
