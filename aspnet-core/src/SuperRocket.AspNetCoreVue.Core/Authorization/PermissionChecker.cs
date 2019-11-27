using Abp.Authorization;
using SuperRocket.AspNetCoreVue.Authorization.Roles;
using SuperRocket.AspNetCoreVue.Authorization.Users;

namespace SuperRocket.AspNetCoreVue.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
