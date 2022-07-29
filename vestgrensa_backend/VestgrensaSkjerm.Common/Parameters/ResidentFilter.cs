using System.Diagnostics.CodeAnalysis;

namespace VestgrensaSkjerm.Common.Parameters;

public class ResidentFilter
{
    public String? Name { get; set; }
    public String? RoomID { get; set; }
    public Boolean? Current { get; set; }
}