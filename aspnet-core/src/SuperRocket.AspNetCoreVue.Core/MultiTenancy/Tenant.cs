using Abp.MultiTenancy;
using SuperRocket.AspNetCoreVue.Authorization.Users;

namespace SuperRocket.AspNetCoreVue.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
