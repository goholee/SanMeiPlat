using System.Collections.Generic;
using SanMeiPlat.Roles.Dto;
using SanMeiPlat.Users.Dto;

namespace SanMeiPlat.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
