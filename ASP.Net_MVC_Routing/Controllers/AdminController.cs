using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace ASP.Net_MVC_Routing.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            string? controller = RouteData.Values["controller"]!.ToString();
            string? action = RouteData.Values["action"]!.ToString();
            StringBuilder sb = new StringBuilder();
            sb.Append($"<html><ul>");
            sb.Append($"<li>Controller: {controller}</li>");
            sb.Append($"<li>Action: {action}</li>");
            sb.Append("</ul></html>");
            return Content(sb.ToString(), "text/html");
        }
        public IActionResult IndexSetup()
        {
            string? controller = RouteData.Values["controller"]!.ToString();
            string? action = RouteData.Values["action"]!.ToString();
            StringBuilder sb = new StringBuilder();
            sb.Append($"<html><ul>");
            sb.Append($"<li>Controller: {controller}</li>");
            sb.Append($"<li>Action: {action}</li>");
            sb.Append("</ul></html>");
            return Content(sb.ToString(), "text/html");
        }
    }
}
