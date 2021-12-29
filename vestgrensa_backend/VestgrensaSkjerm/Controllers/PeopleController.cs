using Microsoft.AspNetCore.Mvc;
using VestgrensaSkjerm.Common.Models;
using VestgrensaSkjerm.Data;
using VestgrensaSkjerm.Services;

namespace VestgrensaSkjerm.Controllers;

[ApiController]
[Route("[controller]")]
public class PeopleController : ControllerBase
{
    private readonly ILogger<PeopleController> _logger;
    private readonly PeopleService _peopleService;
    public PeopleController(ILogger<PeopleController> logger, PeopleService peopleService)
    {
        _logger = logger;
        _peopleService = peopleService;
    }

    [HttpGet(Name = "GetPeople")]
    public async Task<IActionResult> Get()
    {

        List<People> result = await _peopleService.GetPeople();

        return Ok(result);
    }

    [HttpPost(Name = "InsertPerson")]
    public async Task<IActionResult> Insert(String name, String program, int age, String birthday, String roomID)
    {
        String[] dates = birthday.Split("-");
        DateTime d = new DateTime(Int32.Parse(dates[2]), Int32.Parse(dates[1]), Int32.Parse(dates[0]));
        People p = new People{Age = age, Birthday = d.ToUniversalTime(), Name = name, Studyprogramme = program, RoomID = roomID};
        
        People inserted = await _peopleService.Insert(p);

        return Ok(inserted);
    }

    [HttpDelete(Name = "DeletePerson")]
    public async Task<IActionResult> Delete()
    {
        return Ok();
    }
    
    
    [HttpPut(Name = "UpdatePerson")]
    public async Task<IActionResult> Update()
    {
        return Ok();
    }
}