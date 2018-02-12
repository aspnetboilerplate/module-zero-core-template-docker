using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AbpTemplate.MultiTenancy.Dto;

namespace AbpTemplate.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
