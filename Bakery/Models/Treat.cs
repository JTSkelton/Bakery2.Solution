using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bakery.Models
{
  public class Treat
  {
    public Treat()
      {
          this.TreatFlavorEntities = new HashSet<TreatFlavor>();
      }

    [Key]
    public int TreatId { get; set; }

    [Required]
    public string TreatName { get; set; }
    public virtual ApplicationUser User { get; set; }
    public virtual ICollection<TreatFlavor> TreatFlavorEntities { get;}
  }
}