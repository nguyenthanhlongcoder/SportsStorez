using Microsoft.AspNetCore.Mvc;
namespace SportStores.Controllers
{
    public class ErrorController : Controller
    {
        public ViewResult Error() => View();
    }
}