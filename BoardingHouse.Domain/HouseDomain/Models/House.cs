using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardingHouse.Domain.HouseDomain.Models
{
    public class House
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal HousePrice { get; set; }
        public string UnitHousePrice { get; set; }
        public int Capacity { get; set; }
        public decimal ElectricityPrice { get; set; }
        public string UnitElectricityPrice { get; set; }
        public decimal WaterPrice { get; set; }
        public string UnitWaterPrice { get; set; }
        public int NumberMezzanine { get; set; }
        public int Acreage { get; set; }
        public string UnitAcreage { get; set; }
        public DateTime PublicationDate { get; set; }
        public string HouseStatus { get; set; }
        public bool IsParkingVehicleInRoom { get; set; }
    }
}
