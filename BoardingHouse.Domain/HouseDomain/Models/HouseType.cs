using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BoardingHouse.Domain.HouseDomain.Models
{
    public class HouseType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<House> Houses { get; set; }
    }
}
