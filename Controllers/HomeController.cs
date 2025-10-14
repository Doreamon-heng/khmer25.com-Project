using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using khmer25.com_project.Models;

namespace khmer25.com_project.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Category() => View("page/Category");
    public IActionResult NewProducts() => View("page/NewProducts");
    public IActionResult Promotion() => View("page/Promotion");
    public IActionResult Cart() => View("page/Cart");
    public IActionResult Profile() => View("components/Profile");
    public IActionResult Favorite() => View("components/Favorite");
    public IActionResult Delivery() => View("components/Delivery");
    public IActionResult Order() => View("components/Order");
    public IActionResult Contact() => View("components/Contact");
    public IActionResult InviteFriend() => View("components/InviteFriend");
    public IActionResult SignIn() => View("components/SignIn");




    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
