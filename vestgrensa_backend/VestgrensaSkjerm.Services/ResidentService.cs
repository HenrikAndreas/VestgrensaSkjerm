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
     
    public async Task<IEnumerable<Resident>> getResidentByName(string? name)
    {
        
        return await _dbContext.Residents.Where(resident => resident.Name.ToLower().Contains(name.ToLower())).ToListAsync();
    }

    public async Task<IEnumerable<Resident>> getResidentByID(int? id)
    {
        return await _dbContext.Residents.Where(resident => resident.ID == id).ToListAsync();
    }

    public async Task<Resident> removeResident(int id)
    {
        Resident resident = await _dbContext.Residents.FindAsync(id);
        _dbContext.Residents.Remove(resident);

        return resident;
        // find function then delete
        // return await _dbContext.Remove();
    }
}