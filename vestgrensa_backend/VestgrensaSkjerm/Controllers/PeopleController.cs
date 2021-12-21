using Microsoft.AspNetCore.Mvc;
using VestgrensaSkjerm.Common.Models;

namespace VestgrensaSkjerm.Controllers;

[ApiController]
[Route("[controller]")]
public class PeopleController : ControllerBase
{
    private readonly ILogger<PeopleController> _logger;

    public PeopleController(ILogger<PeopleController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetPeople")]
    public async Task<IActionResult> Get()
    {
        List<People> result = new List<People>();
        People Henrik = new People();
        Henrik.Age = 22;
        Henrik.Name = "Henrik";
        Henrik.Studyprogramme = "Programmering og Systemarkitektur";
        result.Add(Henrik);
        
        return Ok(Henrik);
    }
}