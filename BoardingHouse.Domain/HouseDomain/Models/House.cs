using BoardingHouse.Domain.UserDomain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoardingHouse.Domain.HouseDomain.Models
{
    public class House
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "decimal(18,0)")]
        public decimal HousePrice { get; set; }
        public string UnitHousePrice { get; set; }
        public int Capacity { get; set; }
        [Column(TypeName = "decimal(18,0)")]
        public decimal ElectricityPrice { get; set; }
        public string UnitElectricityPrice { get; set; }
        [Column(TypeName = "decimal(18,0)")]
        public decimal WaterPrice { get; set; }
        public string UnitWaterPrice { get; set; }
        public int NumberMezzanine { get; set; }
        public int Acreage { get; set; }
        public string UnitAcreage { get; set; }
        public DateTime PublicationDate { get; set; }
        public string HouseStatus { get; set; }
        public string BusinessType { get; set; }
        public bool IsParkingVehicleInRoom { get; set; }
        public string? FkAppUserId {get;set;}
        [ForeignKey("FkAppUserId")]
        public virtual AppUser AppUser { get; set; }
        public int? FkHouseTypeId { get; set; }
        [ForeignKey("FkHouseTypeId")]
        public virtual HouseType HouseType { get; set; }
        public virtual ICollection<Convenience> Conveniences { get; set; }
    }
}
