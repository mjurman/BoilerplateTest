using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Matija.App.MultiTenancy.Dto;

namespace Matija.App.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

