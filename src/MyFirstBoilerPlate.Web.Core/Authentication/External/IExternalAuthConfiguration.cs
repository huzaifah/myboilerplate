using System.Collections.Generic;

namespace MyFirstBoilerPlate.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
