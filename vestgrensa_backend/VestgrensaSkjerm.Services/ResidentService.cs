using Microsoft.EntityFrameworkCore;
using VestgrensaSkjerm.Common.Models;
using VestgrensaSkjerm.Data;

namespace VestgrensaSkjerm.Services;

public class ResidentService
{
    private readonly VestgrensaDataContext _dbContext;
    
    public ResidentService(VestgrensaDataContext dbContext) {
        _dbContext = dbContext;
    }

    public async Task<Resident> addResident(Resident resident)
    {
        await _dbContext.Residents.AddAsync(resident);
        await _dbContext.SaveChangesAsync();
        
        return resident;
    }
    
    public async Task<IEnumerable<Resident>> getResidentList()
    {
        return await _dbContext.Residents.ToListAsync();

    }
}