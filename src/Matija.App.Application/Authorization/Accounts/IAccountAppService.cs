using System.Threading.Tasks;
using Abp.Application.Services;
using Matija.App.Authorization.Accounts.Dto;

namespace Matija.App.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
