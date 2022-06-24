using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Dotnet_Portfolio.Models;

namespace Dotnet_Portfolio.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet("")]
    public IActionResult Home()
    {
        return View("Home");
    }
}
