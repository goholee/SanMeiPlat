using Microsoft.AspNetCore.Antiforgery;
using SanMeiPlat.Controllers;

namespace SanMeiPlat.Web.Host.Controllers
{
    public class AntiForgeryController : SanMeiPlatControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
