namespace SyncMonitor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SUP_VehicleInformationManual
    {
        [Key]
        public Guid VehicleInformationManualID { get; set; }

        [Required]
        [StringLength(10)]
        public string RegisPlateNumber { get; set; }

        [Required]
        [StringLength(2)]
        public string AreaCode { get; set; }

        [Required]
        [StringLength(10)]
        public string VehicleTypeCode { get; set; }

        public bool? IsSpecialVehicle { get; set; }

        [Required]
        [StringLength(10)]
        public string EmployeeCode { get; set; }

        public DateTime ModifyDate { get; set; }

        [StringLength(500)]
        public string Note { get; set; }
    }
}
