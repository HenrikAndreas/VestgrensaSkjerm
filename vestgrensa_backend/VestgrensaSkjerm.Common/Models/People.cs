using System.ComponentModel.DataAnnotations;

namespace VestgrensaSkjerm.Common.Models;

#nullable disable

public class People
{
    [Key]
    public int Id { get; set; }
    public int Age { get; set; }
    public String Name { get; set; }
    public String RoomID { get; set; }
    public DateTime Birthday { get; set; }
    public String Studyprogramme { get; set; }
    
}