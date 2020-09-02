using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Service.Models
{
    public partial class VehicleMake
    {
        public VehicleMake()
        {
            VehicleModel = new HashSet<VehicleModel>();
        }

        [Key]
        public int VehicleMakeId { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Abrv { get; set; }

        [InverseProperty("VehicleMake")]
        public virtual ICollection<VehicleModel> VehicleModel { get; set; }
    }
}
