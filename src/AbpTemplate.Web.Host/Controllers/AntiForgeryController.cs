using Microsoft.AspNetCore.Antiforgery;
using AbpTemplate.Controllers;

namespace AbpTemplate.Web.Host.Controllers
{
    public class AntiForgeryController : AbpTemplateControllerBase
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
