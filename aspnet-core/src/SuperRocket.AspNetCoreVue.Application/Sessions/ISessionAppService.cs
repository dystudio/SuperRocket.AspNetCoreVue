using System.Threading.Tasks;
using Abp.Application.Services;
using SuperRocket.AspNetCoreVue.Sessions.Dto;

namespace SuperRocket.AspNetCoreVue.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
