using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using LibrarySystem.Application.Interfaces;
using LibrarySystem.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LibrarySystem.Mvc.Models;

namespace LibrarySystem.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAnswersService _answersService;
        public HomeController(ILogger<HomeController> logger, IAnswersService answersService)
        {
            _logger = logger;
            _answersService = answersService;
        }

        public IActionResult Index()
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
        public async Task<IActionResult> Answer()
        {
            var model = await _answersService.GetAnswers();
            return View(model);
        }
    }
}
