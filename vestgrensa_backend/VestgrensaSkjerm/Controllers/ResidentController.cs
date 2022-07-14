using Microsoft.AspNetCore.Mvc;

using VestgrensaSkjerm.Common.Models;
using VestgrensaSkjerm.Data;

namespace VestgrensaSkjerm.Controllers;

[ApiController]
[Route("[controller]")]
public class ResidentController : ControllerBase
{
    private readonly ILogger<ResidentController> _logger;
    private readonly VestgrensaDataContext db;
    public ResidentController(ILogger<ResidentController> logger, VestgrensaDataContext d)
    {
        db = d;
        _logger = logger;
    }

    [HttpPost(Name = "AddResident")]
    public ActionResult AddResident(Resident resident)
    {
        // Insert to DB via Service here in a try / catch
        Console.Write("Adding Resident..." + resident.Name + "\n");
        db.Residents.Add(resident);

        db.SaveChanges();
        



        return Ok(resident);
    }
    
}