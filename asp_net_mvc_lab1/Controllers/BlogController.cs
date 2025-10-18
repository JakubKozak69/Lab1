using asp_net_mvc_lab1.Models;
using Microsoft.AspNetCore.Mvc;

namespace asp_net_mvc_lab1.Controllers
{
    public class BlogController : Controller
    {
        private readonly ILogger<BlogController> _logger;

        public BlogController(ILogger<BlogController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(new BlogViewModel()
            {
                Title = "Welcome to My Blog",
                Description = "This is a simple blog application built with ASP.NET MVC."
            });
        }
    }
}
