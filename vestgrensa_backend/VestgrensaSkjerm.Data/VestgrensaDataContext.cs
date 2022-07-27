using VestgrensaSkjerm.Common.Models;

using Microsoft.EntityFrameworkCore;

namespace VestgrensaSkjerm.Data;

public class VestgrensaDataContext : DbContext
{
    public DbSet<Resident> Residents { get; set; }
    
    public VestgrensaDataContext(DbContextOptions<VestgrensaDataContext> options): base(options)
    {
        
    }

}