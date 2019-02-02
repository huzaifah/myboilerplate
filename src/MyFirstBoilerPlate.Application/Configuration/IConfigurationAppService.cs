using System.Threading.Tasks;
using MyFirstBoilerPlate.Configuration.Dto;

namespace MyFirstBoilerPlate.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
