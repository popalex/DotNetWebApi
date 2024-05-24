using Microsoft.AspNetCore.Mvc;

namespace DotNetWebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class MaybeController : ControllerBase
{
     private readonly ILogger<MaybeController> _logger;

    public MaybeController(ILogger<MaybeController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetMaybe")]
    public int Get()
    {
        Random rnd = new Random();
        int x = rnd.Next(10);

        _logger.LogWarning($"Generate random number {x}");

        if (x < 5)
            throw new InvalidDataException($"The number {x} is invalid!");

        return x;
    }
}
