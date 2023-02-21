using System.Reflection.Metadata;
using VestgrensaSkjerm.Common.Models;

using Microsoft.EntityFrameworkCore;

namespace VestgrensaSkjerm.Data;

public class VestgrensaDataContext : DbContext
{
    public DbSet<Resident> Residents { get; set; }
    public DbSet<Message> Messages { get; set; }

    public DbSet<Room> Rooms { get; set; }
    
    public VestgrensaDataContext(DbContextOptions<VestgrensaDataContext> options): base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Resident>()
            .Property(resident => resident.Current)
            .HasDefaultValue(true);

        modelBuilder.Entity<Resident>()
            .HasOne(resident => resident.Room)
            .WithOne(room => room.Resident)
            .HasForeignKey<Room>(room => room.ID);
        

    }   
}