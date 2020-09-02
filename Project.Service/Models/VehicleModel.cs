using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Service.Models
{
    public partial class VehicleModel
    {
        [Key]
        public int VehicleModelId { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Abrv { get; set; }
        public int? VehicleMakeId { get; set; }

        [ForeignKey(nameof(VehicleMakeId))]
        [InverseProperty("VehicleModel")]
        public virtual VehicleMake VehicleMake { get; set; }
    }
}
