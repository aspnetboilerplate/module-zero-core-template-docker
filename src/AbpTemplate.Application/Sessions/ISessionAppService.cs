using System.Threading.Tasks;
using Abp.Application.Services;
using AbpTemplate.Sessions.Dto;

namespace AbpTemplate.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
