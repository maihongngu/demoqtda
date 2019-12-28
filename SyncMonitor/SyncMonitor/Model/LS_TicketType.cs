namespace SyncMonitor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LS_TicketType
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TicketTypeID { get; set; }

        [Key]
        [StringLength(10)]
        public string TicketTypeCode { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        public int Price { get; set; }

        public DateTime EffectiveDate { get; set; }

        public DateTime ExpireDate { get; set; }

        [Required]
        [StringLength(10)]
        public string RouteCode { get; set; }

        [Required]
        [StringLength(10)]
        public string TicketCategoryCode { get; set; }

        [Required]
        [StringLength(10)]
        public string VehicleTypeCode { get; set; }

        [StringLength(200)]
        public string Note { get; set; }

        public bool? IsMissingCard { get; set; }

        public bool IsUsed { get; set; }
    }
}
