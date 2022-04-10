using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bakery.Models
{
  public class Treat
  {
    [Key]
    public int TreatId { get; set; }

    [Required]
    public string TreatName { get; set; }
  }
}