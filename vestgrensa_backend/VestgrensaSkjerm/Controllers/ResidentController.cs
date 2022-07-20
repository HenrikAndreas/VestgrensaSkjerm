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
        if (id != null && name != null)
        {
            // Search by id?? Or throw error
        }
        
        if (id != null)
        {
            Console.Write("Searching resident by ID\n");
        } else if (name != null)
        {
            Console.Write("Searching resident by Name\n");
        }

        IEnumerable<Resident> residents = await _residentService.getResident(name);

        return Ok(residents);
    }

}