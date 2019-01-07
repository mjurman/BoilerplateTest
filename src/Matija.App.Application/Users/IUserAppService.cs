using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Matija.App.Roles.Dto;
using Matija.App.Users.Dto;

namespace Matija.App.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
