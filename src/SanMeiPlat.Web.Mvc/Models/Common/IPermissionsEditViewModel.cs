using System.Collections.Generic;
using SanMeiPlat.Roles.Dto;

namespace SanMeiPlat.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}