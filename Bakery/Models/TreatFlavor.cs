using System.ComponentModel.DataAnnotations;
using System; 

namespace Bakery.Models
{
  public class TreatFlavor
  {       
    [Key]
    public int TreatFlavorId { get; set; }
    public int TreatId { get; set; }
    public int FlavorId { get; set; }
    public virtual Treat Treat { get; set; }
    public virtual Flavor Flavor { get; set; }
  }
}