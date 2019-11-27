using Microsoft.AspNetCore.Antiforgery;
using SuperRocket.AspNetCoreVue.Controllers;

namespace SuperRocket.AspNetCoreVue.Web.Host.Controllers
{
    public class AntiForgeryController : AspNetCoreVueControllerBase
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
