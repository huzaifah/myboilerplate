using System.Threading.Tasks;
using Abp.Application.Services;
using MyFirstBoilerPlate.Authorization.Accounts.Dto;

namespace MyFirstBoilerPlate.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
