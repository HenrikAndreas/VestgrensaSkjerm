using System.ComponentModel.DataAnnotations;
namespace VestgrensaSkjerm.Common.Models;

public class Message
{
    [Key]

    public int ID { get; set; }
    public String Title { get; set; }
    public String Text { get; set; }
    
    // Navigation property
    public Resident Resident { get; set; }

}