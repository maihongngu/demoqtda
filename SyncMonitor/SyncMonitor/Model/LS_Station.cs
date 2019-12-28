namespace SyncMonitor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LS_Station
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StationID { get; set; }

        [Key]
        [StringLength(10)]
        public string StationCode { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(10)]
        public string CompanyCode { get; set; }

        public int StationType { get; set; }

        [StringLength(500)]
        public string Address { get; set; }

        [StringLength(50)]
        public string Telephone { get; set; }

        [StringLength(50)]
        public string Fax { get; set; }

        [StringLength(100)]
        public string Note { get; set; }

        public bool IsUsed { get; set; }

        [StringLength(10)]
        public string ShortName { get; set; }
    }
}
