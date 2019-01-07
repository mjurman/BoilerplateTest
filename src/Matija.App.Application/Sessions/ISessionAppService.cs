using System.Threading.Tasks;
using Abp.Application.Services;
using Matija.App.Sessions.Dto;

namespace Matija.App.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
