using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SuperRocket.AspNetCoreVue.Authorization;

namespace SuperRocket.AspNetCoreVue
{
    [DependsOn(
        typeof(AspNetCoreVueCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AspNetCoreVueApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<AspNetCoreVueAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(AspNetCoreVueApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
