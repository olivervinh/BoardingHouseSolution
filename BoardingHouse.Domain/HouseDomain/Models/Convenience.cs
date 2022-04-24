using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoardingHouse.Domain.HouseDomain.Models
{
    public class Convenience
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int? FkHouseId { get; set; }
        [ForeignKey("FkHouseId")]
        public virtual House House { get; set; }
    }
}
