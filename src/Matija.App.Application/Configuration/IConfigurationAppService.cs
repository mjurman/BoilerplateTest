using System.Threading.Tasks;
using Matija.App.Configuration.Dto;

namespace Matija.App.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
