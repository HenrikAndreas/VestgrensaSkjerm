using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace VestgrensaSkjerm.Common.Models;

public class Resident
{
    
    [Key]
    public int ResidentID { get; set; }
    public String Name { get; set; }
    public String RoomID { get; set; }
    public String Programme { get; set; }
    public String University { get; set; }
    public DateTime Birthday { get; set; } 
    public Boolean Current { get; set; }
    // Navigation property
    public Room Room { get; set; }

}