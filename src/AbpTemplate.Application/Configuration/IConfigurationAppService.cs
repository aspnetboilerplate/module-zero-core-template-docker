using System.Threading.Tasks;
using AbpTemplate.Configuration.Dto;

namespace AbpTemplate.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
