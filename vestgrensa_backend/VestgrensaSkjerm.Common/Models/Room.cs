using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace VestgrensaSkjerm.Common.Models
{
    public class Room
    {
        [Key]
        public int ID { get; set; }
        
        public int WashWeekType { get; set; }
        
        // Navigation property
        public Resident Resident { get; set; }

    }
}
