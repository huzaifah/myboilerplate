using Abp.AutoMapper;
using MyFirstBoilerPlate.Authentication.External;

namespace MyFirstBoilerPlate.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
