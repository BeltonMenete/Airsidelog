using AirsideLog.Models;
using Microsoft.AspNetCore.Mvc;

namespace AirsideLog.Controllers;

[ApiController]
public class AppController : ControllerBase
{
    [HttpGet(Endpoints.App.Open)]
    public IActionResult OpenApp()
    {
        return Ok(new App() { Message = "Wellcome to the App" });
    }
}

public class App
{
    public string Message { get; set; } = string.Empty;
}