using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LezzetAvcısıBlog.Models;

namespace LezzetAvcısıBlog.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var context = new WebContext();
        var kullanici = context.Kullanici.ToList();
        return View(kullanici);
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

