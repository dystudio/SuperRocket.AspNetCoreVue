using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SuperRocket.AspNetCoreVue.Configuration;

namespace SuperRocket.AspNetCoreVue.Web.Host.Startup
{
    [DependsOn(
       typeof(AspNetCoreVueWebCoreModule))]
    public class AspNetCoreVueWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public AspNetCoreVueWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AspNetCoreVueWebHostModule).GetAssembly());
        }
    }
}
