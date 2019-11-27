using System.Collections.Generic;

namespace SuperRocket.AspNetCoreVue.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
