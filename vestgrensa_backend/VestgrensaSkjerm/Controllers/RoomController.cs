using Microsoft.AspNetCore.Mvc;
using VestgrensaSkjerm.Services;
using Microsoft.EntityFrameworkCore;
using VestgrensaSkjerm.Common.Models;
using VestgrensaSkjerm.Common.Parameters;
namespace VestgrensaSkjerm.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RoomController : ControllerBase
    {
        private readonly ILogger<RoomController> _logger;
        private readonly RoomService _roomService;
        public RoomController(ILogger<RoomController> logger, RoomService roomService)
        {
            _logger = logger;
            _roomService = roomService;

        }
        [HttpPost("AddRoom")]
        public async Task<ActionResult> AddRoom([FromQuery] Room room)
        {

            return Ok("WOW");
        }
    }
}
