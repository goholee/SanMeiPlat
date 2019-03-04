using Abp.Authorization;
using SanMeiPlat.Authorization.Roles;
using SanMeiPlat.Authorization.Users;

namespace SanMeiPlat.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
