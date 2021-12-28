using Microsoft.EntityFrameworkCore;
using VestgrensaSkjerm.Common.Models;
using VestgrensaSkjerm.Data;

namespace VestgrensaSkjerm.Services;

public class PeopleService
{
    private readonly VestgrensaDataContext _dbContext;

    public PeopleService(VestgrensaDataContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<People> Insert(People person)
    {
        await _dbContext.Peoples.AddAsync(person);
        await _dbContext.SaveChangesAsync();
        
        return person;
    }

    public async Task<List<People>> GetPeople()
    {
        return await _dbContext.Peoples.ToListAsync();
    }
    
}