using Microsoft.EntityFrameworkCore;
using VestgrensaSkjerm.Common.Models;
using VestgrensaSkjerm.Common.Parameters;
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
    
    public async Task<IEnumerable<Resident>> getResidentList(ResidentFilter filter)
    {
        return await _dbContext.Residents
            .Where(r=> r.Name.ToLower().Contains((filter.Name != null) ? filter.Name.ToLower() : ""))
            .Where(r=> r.RoomID.ToLower().Contains((filter.RoomID != null) ? filter.RoomID.ToLower() : ""))
            .Where(r  => (filter.Current != null) ? r.Current.Equals(filter.Current) : r.Current.Equals(true) || r.Current.Equals(false))
            .ToListAsync();
        
    }
    
    public async Task<IEnumerable<Resident>> getResidentByName(string? name)
    {
        
        return await _dbContext.Residents.Where(
            resident => resident.Name.ToLower().Contains(name.ToLower())).ToListAsync();
    }

    public async Task<IEnumerable<Resident>> getResidentByID(int? id)
    {
        return await _dbContext.Residents.Where(resident => resident.ResidentID == id).ToListAsync();
    }
    
    public async Task<Resident> removeResident(int id)
    {
        Resident resident = await _dbContext.Residents.FindAsync(id);
        resident.Current = false;
        _dbContext.Update(resident);
        await _dbContext.SaveChangesAsync();
        return resident;
    }

    public async Task<Resident> deleteResident(int id)
    {
        Resident resident = await _dbContext.Residents.FindAsync(id);

        _dbContext.Residents.Remove(resident);
        await _dbContext.SaveChangesAsync();
        return resident;

    }
}