using asp_net_mvc_lab1.Models;
using Microsoft.AspNetCore.Mvc;

namespace asp_net_mvc_lab1.Controllers
{
    public class BlogController : Controller
    {
        private readonly ILogger<BlogController> _logger;

        public BlogController(ILogger<BlogController> logger) => _logger = logger;

        public static readonly List<BlogArticleViewModel> _articles = new()
        {
            new BlogArticleViewModel {
                Id = "1",
                Title = "Welcome to My Blog",
                Description = "A simple ASP.NET MVC app.",
                Content = "<p>First post about ASP.NET MVC — intro and goals.</p>"
            },
            new BlogArticleViewModel {
                Id = "2",
                Title = "Understanding MVC",
                Description = "Models, Views, and Controllers.",
                Content = "<p>We break down responsibilities and flow.</p>"
            },
            new BlogArticleViewModel {
                Id = "3",
                Title = "Basic routing",
                Description = "How routing works in ASP.NET Core.",
                Content = "<p>Minimal routing examples and tips.</p>"
            }
        };

        public IActionResult Index() => View(_articles);

        public IActionResult Article(string id)
        {
            if (string.IsNullOrWhiteSpace(id)) return NotFound();

            var post = _articles.FirstOrDefault(p => p.Id.Equals(id, StringComparison.OrdinalIgnoreCase));
            if (post == null) return NotFound();

            return View(post);
        }
    }
}
