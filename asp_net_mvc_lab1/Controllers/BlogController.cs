using asp_net_mvc_lab1.Models;
using Microsoft.AspNetCore.Mvc;

namespace asp_net_mvc_lab1.Controllers
{
    public class BlogController : Controller
    {
        private readonly ILogger<BlogController> _logger;

        // Statyczna lista przykładowych artykułów — dokładnie jak w labie (na potrzeby przykładu). 
        public static readonly List<BlogArticleViewModel> _articles = new()
        {
            new BlogArticleViewModel { Title = "Welcome to My Blog", Description = "A simple ASP.NET MVC app." },
            new BlogArticleViewModel { Title = "Understanding MVC",   Description = "Models, Views, and Controllers." },
            new BlogArticleViewModel { Title = "Basic routing",       Description = "How routing works in ASP.NET Core." }
        };

        public BlogController(ILogger<BlogController> logger) => _logger = logger;

        public IActionResult Index()
        {
            return View(_articles);
        }
    }
}
