using Microsoft.AspNetCore.Mvc;

using VestgrensaSkjerm.Common.Models;
using VestgrensaSkjerm.Data;
using VestgrensaSkjerm.Services;

namespace VestgrensaSkjerm.Controllers;

[ApiController]
[Route("[controller]")]
public class ResidentController : ControllerBase
{
    private readonly ILogger<ResidentController> _logger;
    private readonly ResidentService _residentService;
    public ResidentController(ILogger<ResidentController> logger, ResidentService residentService)
    {
        _logger = logger;
        _residentService = residentService;
    }

    [HttpPost(Name = "AddResident")]
    public async Task<ActionResult> AddResident(Resident resident)
    {
        // Insert to DB via Service here in a try / catch
        Console.Write("Adding Resident..." + resident.Name + "\n");
        
        // Validate

        // Creating new resident and return
        Resident res = await _residentService.addResident(resident);
        
        return Ok(res);
    }

    [HttpGet(Name = "GetResidentList")]
    public async Task<ActionResult> GetResidentList()
    {
        IEnumerable<Resident> residentList = await _residentService.getResidentList();
        
        return Ok(residentList);
    }
    
}