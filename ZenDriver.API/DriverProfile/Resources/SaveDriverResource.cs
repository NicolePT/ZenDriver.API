using System.ComponentModel.DataAnnotations;

namespace ZenDriver.API.DriverProfile.Resources;
public class SaveDriverResource
{
    [Required]
    public int UserId { get; set; }
    
}
