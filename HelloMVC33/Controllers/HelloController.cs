using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloMVC33.Controllers
{
    public class HelloController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            string html = "<form method='post'>" +
                "<input type='text' name='name' />" +
                "<input type='submit' value='Greet me!' />" +
                "</form>";
            return Content(html, "text/html");

            //return Redirect("/Hello/Goodbye");
        }

        //  /Hello
        [Route("/Hello")]
        [HttpPost]
        public IActionResult Display(string name = "World")
        {
            return Content(string.Format("<h1>Hello {0}</h1>", name), "text/html");
        }

        // handle requests to /Hello/Chris  (URL segment)
        [Route("/Hello/{name}")]
        public IActionResult Index2(string name)
        {

            return Content(string.Format("<h1>Hello {0}</h1>", name), "text/html");
        }

        //   /Hello/Goodbye
        //  //   alter it to be /Hello/Aloha
        //  [Route("/Hello/Aloha")]
        public IActionResult Goodbye()
        {
            return Content("Goodbye");
        }
    }
}
