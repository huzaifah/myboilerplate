using System.Threading.Tasks;
using Abp.Application.Services;
using MyFirstBoilerPlate.Sessions.Dto;

namespace MyFirstBoilerPlate.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
