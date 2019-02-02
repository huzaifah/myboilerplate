using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MyFirstBoilerPlate.MultiTenancy.Dto;

namespace MyFirstBoilerPlate.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

