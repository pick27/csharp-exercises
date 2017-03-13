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
                "<select name='language'>" +
                "<option>English</option>" +            // hello
                "<option>French</option>" +             // bonjour
                "<option>Spanish</option>" +            // hola
                "<option>German</option>" +             // Hallo
                "<option>Latin</option>" +              // Salve 
                "</select>" +
                "<input type='submit' value='Greet me!' />" +
                "</form>";
            return Content(html, "text/html");

            //return Redirect("/Hello/Goodbye");
        }

        public static string CreateMessage(string name, string language)
        {
            string message = "";
            
            if (language == "English")
            {
                message = "Hello";
            }
            else if (language == "French")
            {
                message = "Bonjour";
            }
            else if (language == "Spanish")
            {
                message = "Hola";
            }
            else if (language == "German")
            {
                message = "Hallo";
            }
            else if (language == "Latin")
            {
                message = "Salve";
            }

            message = message + " " + name;

            return (message);
        }

        //  /Hello
        [Route("/Hello")]
        [HttpPost]
        public IActionResult Display(string name = "World", string language = "English")
        {
            int visits = 0;
            string temp = "";
            bool success;
            success = Request.Cookies.TryGetValue("bonjour", out temp);
            if (temp == null || temp.Length == 0)
            {
                temp = "0";
            }
            visits = int.Parse(temp) + 1;
            string whatToSay = "";
            if (name == "")
                name = "World";
            whatToSay = CreateMessage(name, language);
            whatToSay = "<h1>We hope this is what you asked for</h1>" +
                "<h2><b>" +
                whatToSay +
                "</b></h2>" +
                "<b>How many visits: " + visits + "</b>";

            Response.Cookies.Append("bonjour", visits.ToString());
            return Content(whatToSay, "text/html");
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
