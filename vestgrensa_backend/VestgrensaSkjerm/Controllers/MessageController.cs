using Microsoft.AspNetCore.Mvc;

using VestgrensaSkjerm.Common.Models;
using VestgrensaSkjerm.Common.Parameters;
using VestgrensaSkjerm.Services;

namespace VestgrensaSkjerm.Controllers;

[ApiController]
[Route("[controller]")]
public class MessageController: ControllerBase
{
    private readonly ILogger<MessageController> _logger;
    private readonly MessageService _messageService;
    public MessageController(ILogger<MessageController> logger, MessageService messageService)
    {
        _logger = logger;
        _messageService = messageService;
    }

    [HttpPost("AddMessage")]
    public async Task<ActionResult> AddMessage ([FromBody] Message message)
    {

        // Creating new message and return
        Message res = await _messageService.addMessage(message);
        
        
        return Ok(res);
    }

    [HttpGet("GetMessageList")]
    public async Task<ActionResult> GetMessageList()
    {

        IEnumerable<Message> messages = await _messageService.getMessageList();
        return Ok();
    }
}