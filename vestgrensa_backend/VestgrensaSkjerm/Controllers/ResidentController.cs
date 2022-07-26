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

    [HttpPost("AddResident")]
    public async Task<ActionResult> AddResident(Resident resident)
    {
        Console.Write("Adding Resident..." + resident.Name + "\n");

        // Creating new resident and return
        Resident res = await _residentService.addResident(resident);
        
        return Ok(res);
    }

    [HttpGet("GetResidentList")]
    public async Task<ActionResult> GetResidentList()
    {
        IEnumerable<Resident> residentList = await _residentService.getResidentList();
        
        return Ok(residentList);
    }

    [HttpGet("GetResident")]
    public async Task<ActionResult> GetResident(string? name, int? id = null)
    {
        if (id == null && name == null)
        {
            Console.Write("Bad Request: No parameters were given\n");
            return BadRequest("Please provide parameters");
        }

        IEnumerable<Resident> residents;
        
        if (id != null)
        {
            Console.Write("Searching resident by ID\n");
            residents = await _residentService.getResidentByID(id);
            return Ok(residents);
        }
        
        Console.Write("Searching resident by Name\n");
        residents = await _residentService.getResidentByName(name);
        return Ok(residents);
        
    }

    [HttpDelete("RemoveResident")]
    public async Task<ActionResult> RemoveResident(int id)
    {
        resident = await _residentService.removeResident(id);
        return Ok(resident);
    }

}