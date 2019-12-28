namespace SyncMonitor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LS_Shift
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ShiftID { get; set; }

        [Key]
        [StringLength(10)]
        public string ShiftCode { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [Required]
        [StringLength(8)]
        public string StartTime { get; set; }

        [Required]
        [StringLength(8)]
        public string EndTime { get; set; }

        [StringLength(100)]
        public string Note { get; set; }

        public bool IsUsed { get; set; }

        public DateTime? ActiveDate { get; set; }

        public DateTime? ExpiryDate { get; set; }
    }
}
