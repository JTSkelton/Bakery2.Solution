using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bakery.Models
{
  public class Flavor
  {
    [Key]
    public int FlavorId { get; set; }

    [Required]
    public string FlavorName { get; set; }
  }
}