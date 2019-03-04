using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using SanMeiPlat.Controllers;

namespace SanMeiPlat.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : SanMeiPlatControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
