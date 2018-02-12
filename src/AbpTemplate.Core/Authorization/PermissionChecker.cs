using Abp.Authorization;
using AbpTemplate.Authorization.Roles;
using AbpTemplate.Authorization.Users;

namespace AbpTemplate.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
