using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using SuperRocket.AspNetCoreVue.Authorization;
using SuperRocket.AspNetCoreVue.Authorization.Roles;
using SuperRocket.AspNetCoreVue.Authorization.Users;
using SuperRocket.AspNetCoreVue.Editions;
using SuperRocket.AspNetCoreVue.MultiTenancy;

namespace SuperRocket.AspNetCoreVue.Identity
{
    public static class IdentityRegistrar
    {
        public static IdentityBuilder Register(IServiceCollection services)
        {
            services.AddLogging();

            return services.AddAbpIdentity<Tenant, User, Role>()
                .AddAbpTenantManager<TenantManager>()
                .AddAbpUserManager<UserManager>()
                .AddAbpRoleManager<RoleManager>()
                .AddAbpEditionManager<EditionManager>()
                .AddAbpUserStore<UserStore>()
                .AddAbpRoleStore<RoleStore>()
                .AddAbpLogInManager<LogInManager>()
                .AddAbpSignInManager<SignInManager>()
                .AddAbpSecurityStampValidator<SecurityStampValidator>()
                .AddAbpUserClaimsPrincipalFactory<UserClaimsPrincipalFactory>()
                .AddPermissionChecker<PermissionChecker>()
                .AddDefaultTokenProviders();
        }
    }
}
