using Microsoft.AspNet.Mvc;

namespace MvcWebApi06.Controllers 
{

    public class HomeController
    {
        public IActionResult Index()
        {
            return new ViewResult();
        }

        public IActionResult Getnet()
        {
            return new ViewResult();
        }
    }

}
