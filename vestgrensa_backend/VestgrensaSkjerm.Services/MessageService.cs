using Microsoft.EntityFrameworkCore;
using VestgrensaSkjerm.Common.Models;
using VestgrensaSkjerm.Common.Parameters;
using VestgrensaSkjerm.Data;

namespace VestgrensaSkjerm.Services;

public class MessageService
{
    private readonly VestgrensaDataContext _dbContext;
    
    public MessageService(VestgrensaDataContext dbContext) {
        _dbContext = dbContext;
    }

    public async Task<Message> addMessage(Message message)
    {
        await _dbContext.Messages.AddAsync(message);
        await _dbContext.SaveChangesAsync();
        
        return message;
    }

    public async Task<IEnumerable<Message>> getMessageList()
    {
        return await _dbContext.Messages.ToListAsync();
    }

}