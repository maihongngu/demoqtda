namespace SyncMonitor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LS_VehicleType
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VehicleTypeID { get; set; }

        [Key]
        [StringLength(10)]
        public string VehicleTypeCode { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        public decimal? AmountPerKm { get; set; }

        public decimal? LowBalance { get; set; }

        [StringLength(100)]
        public string Note { get; set; }

        public bool IsUsed { get; set; }
    }
}
