using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SuperRocket.AspNetCoreVue.MultiTenancy.Dto;

namespace SuperRocket.AspNetCoreVue.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

