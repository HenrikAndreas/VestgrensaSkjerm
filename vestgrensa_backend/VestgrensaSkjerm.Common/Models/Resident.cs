using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace VestgrensaSkjerm.Common.Models;

public class Resident
{
    
    [Key]
    public int ID { get; set; }
    public String Name { get; set; }
    public String RoomID { get; set; }
    public String Programme { get; set; }
    public String University { get; set; }
    public DateTime Birthday { get; set; } 
 
}