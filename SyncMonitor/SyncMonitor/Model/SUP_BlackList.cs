namespace SyncMonitor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SUP_BlackList
    {
        [Key]
        public Guid BlackListID { get; set; }

        [StringLength(10)]
        public string ProductTypeCode { get; set; }

        [Required]
        [StringLength(20)]
        public string ProductID { get; set; }

        [Required]
        [StringLength(10)]
        public string EmployeeCode { get; set; }

        [StringLength(10)]
        public string StationCode { get; set; }

        public DateTime UpdatedDate { get; set; }

        [StringLength(10)]
        public string ReasonCode { get; set; }

        public bool? IsVehicle { get; set; }

        [StringLength(250)]
        public string Note { get; set; }

        public short? IsDataFromCenter { get; set; }
    }
}
