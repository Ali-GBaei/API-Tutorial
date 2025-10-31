using Microsoft.AspNetCore.Mvc;

namespace APITutorial.Controllers;

public class ApiExamplesController : Controller
{
    private readonly ILogger<ApiExamplesController> _logger;

    public ApiExamplesController(ILogger<ApiExamplesController> logger)
    {
        _logger = logger;
    }

    public IActionResult RestBasics()
    {
        return View();
    }

    public IActionResult Authentication()
    {
        return View();
    }

    public IActionResult GitHub()
    {
        return View();
    }

    public IActionResult OpenWeather()
    {
        return View();
    }

    public IActionResult JSONPlaceholder()
    {
        return View();
    }
}
