using Microsoft.EntityFrameworkCore;
using VestgrensaSkjerm.Common.Models;
using VestgrensaSkjerm.Common.Parameters;
using VestgrensaSkjerm.Data;

namespace VestgrensaSkjerm.Services;

public class RoomService
{
    private readonly VestgrensaDataContext _dbContext;

    public RoomService(VestgrensaDataContext dbContext)
    {
        _dbContext = dbContext;
    }

}