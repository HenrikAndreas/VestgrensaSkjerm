using Microsoft.EntityFrameworkCore;
using VestgrensaSkjerm.Common.Models;

namespace VestgrensaSkjerm.Data;

public class VestgrensaDataContext: DbContext
{
    public DbSet<People> Peoples { get; set; }

    public VestgrensaDataContext(DbContextOptions<VestgrensaDataContext> options): base(options)
    {
        
    }
}