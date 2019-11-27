using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using SuperRocket.AspNetCoreVue.Authorization.Roles;
using SuperRocket.AspNetCoreVue.Authorization.Users;
using SuperRocket.AspNetCoreVue.MultiTenancy;

namespace SuperRocket.AspNetCoreVue.EntityFrameworkCore
{
    public class AspNetCoreVueDbContext : AbpZeroDbContext<Tenant, Role, User, AspNetCoreVueDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public AspNetCoreVueDbContext(DbContextOptions<AspNetCoreVueDbContext> options)
            : base(options)
        {
        }
    }
}
