using System.Threading.Tasks;
using SuperRocket.AspNetCoreVue.Configuration.Dto;

namespace SuperRocket.AspNetCoreVue.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
