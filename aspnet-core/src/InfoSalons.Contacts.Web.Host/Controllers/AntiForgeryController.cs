using Microsoft.AspNetCore.Antiforgery;
using InfoSalons.Contacts.Controllers;

namespace InfoSalons.Contacts.Web.Host.Controllers
{
    public class AntiForgeryController : ContactsControllerBase
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
