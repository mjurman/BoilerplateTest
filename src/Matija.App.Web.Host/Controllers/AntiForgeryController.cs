using Microsoft.AspNetCore.Antiforgery;
using Matija.App.Controllers;

namespace Matija.App.Web.Host.Controllers
{
    public class AntiForgeryController : AppControllerBase
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
