using System.Threading.Tasks;
using Abp.Application.Services;
using SuperRocket.AspNetCoreVue.Authorization.Accounts.Dto;

namespace SuperRocket.AspNetCoreVue.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
