using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace ASP.Net_MVC_Routing.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Settings()
        {
            string? controller = RouteData.Values["controller"]!.ToString();
            string? action = RouteData.Values["action"]!.ToString();
            string? id = RouteData.Values["id"]!.ToString();
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("<html>");
            stringBuilder.AppendLine($"<h1>Controller: {controller}</h1>");
            stringBuilder.AppendLine($"<h1>Action: {action}</h1>");
            stringBuilder.AppendLine($"<h1>Id: {id}</h1>");
            stringBuilder.AppendLine("</html>");
            return Content(stringBuilder.ToString(), "text/html");
        }
    }
}
