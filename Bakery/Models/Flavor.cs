using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bakery.Models
{
  public class Flavor
  {
    public Flavor()
    {
      this.TreatFlavorEntities = new HashSet<TreatFlavor>();
    }
    [Key]
    public int FlavorId { get; set; }

    [Required]
    public string FlavorName { get; set; }

    public virtual ICollection<TreatFlavor> TreatFlavorEntities { get; set; }
  }
}