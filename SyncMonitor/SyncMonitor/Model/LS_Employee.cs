namespace SyncMonitor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LS_Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LS_Employee()
        {
            LS_Customer = new HashSet<LS_Customer>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeID { get; set; }

        [Key]
        [StringLength(10)]
        public string EmployeeCode { get; set; }

        [StringLength(10)]
        public string PositionCode { get; set; }

        [StringLength(10)]
        public string TeamCode { get; set; }

        [StringLength(10)]
        public string IDNo { get; set; }

        [StringLength(10)]
        public string ManagerCode { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(50)]
        public string NickName { get; set; }

        public short? Gender { get; set; }

        public DateTime? Birthday { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Mobile { get; set; }

        [StringLength(500)]
        public string Note { get; set; }

        public bool IsUsed { get; set; }

        public bool? IsTeamLeader { get; set; }

        [StringLength(50)]
        public string SmartCardID { get; set; }

        public short? IsDataFromCenter { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LS_Customer> LS_Customer { get; set; }
    }
}
