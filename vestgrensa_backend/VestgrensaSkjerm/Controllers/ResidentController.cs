using Microsoft.AspNetCore.Mvc;

using VestgrensaSkjerm.Common.Models;

namespace VestgrensaSkjerm.Controllers;

[ApiController]
[Route("[controller]")]
public class ResidentController : ControllerBase
{
    private readonly ILogger<ResidentController> _logger;

    public ResidentController(ILogger<ResidentController> logger)
    {
        _logger = logger;
    }

    [HttpPost(Name = "AddResident")]
    public ActionResult AddResident(Resident resident)
    {
        // Insert to DB via Service here in a try / catch
        
        return Ok(resident);
    }
    
    [HttpGet(Name = "GetResidentList")]
    public IEnumerable<Resident> GetResidentList()
    {
        return Enumerable.Range(1, 5).Select(index => new Resident
            {
                
            })
            .ToArray();
    }
}