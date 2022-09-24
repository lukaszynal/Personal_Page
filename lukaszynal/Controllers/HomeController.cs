using lukaszynal.Models;
using lukaszynal.Models.ViewModels;
using lukaszynal.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace lukaszynal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> Logger;
        private readonly JsonFileService RepositoryService;

        public HomeController(ILogger<HomeController> logger, JsonFileService repositoryService)
        {
            Logger = logger;
            RepositoryService = repositoryService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Projects(string projectName = "TodoList Application")
        {
            return View(new ProjectsViewModel(RepositoryService, projectName));
        }

        public IActionResult Courses()
        {
            return View(new CoursesViewModel(RepositoryService));
        }

        public IActionResult Resume()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}