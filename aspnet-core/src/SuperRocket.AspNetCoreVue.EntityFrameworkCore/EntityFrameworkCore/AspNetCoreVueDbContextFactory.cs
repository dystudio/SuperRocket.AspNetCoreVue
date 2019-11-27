using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using SuperRocket.AspNetCoreVue.Configuration;
using SuperRocket.AspNetCoreVue.Web;

namespace SuperRocket.AspNetCoreVue.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class AspNetCoreVueDbContextFactory : IDesignTimeDbContextFactory<AspNetCoreVueDbContext>
    {
        public AspNetCoreVueDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AspNetCoreVueDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            AspNetCoreVueDbContextConfigurer.Configure(builder, configuration.GetConnectionString(AspNetCoreVueConsts.ConnectionStringName));

            return new AspNetCoreVueDbContext(builder.Options);
        }
    }
}
