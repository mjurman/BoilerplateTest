using Abp.Authorization;
using Matija.App.Authorization.Roles;
using Matija.App.Authorization.Users;

namespace Matija.App.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
