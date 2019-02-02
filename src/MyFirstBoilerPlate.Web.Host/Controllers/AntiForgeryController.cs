using Microsoft.AspNetCore.Antiforgery;
using MyFirstBoilerPlate.Controllers;

namespace MyFirstBoilerPlate.Web.Host.Controllers
{
    public class AntiForgeryController : MyFirstBoilerPlateControllerBase
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
