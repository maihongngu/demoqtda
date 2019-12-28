namespace SyncMonitor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LS_Customer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerID { get; set; }

        [Key]
        [StringLength(10)]
        public string CustomerCode { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(100)]
        public string CompanyName { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(20)]
        public string Mobile { get; set; }

        [StringLength(20)]
        public string Telephone { get; set; }

        [StringLength(200)]
        public string Note { get; set; }

        public bool IsUsed { get; set; }

        [StringLength(20)]
        public string TaxCode { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(10)]
        public string EmployeeCode { get; set; }

        [StringLength(20)]
        public string IDNo { get; set; }

        public short? IsDataFromCenter { get; set; }

        [StringLength(20)]
        public string BankAccount { get; set; }

        public int? IsCompany { get; set; }

        [StringLength(20)]
        public string Str1 { get; set; }

        [StringLength(20)]
        public string Str2 { get; set; }

        public virtual LS_Employee LS_Employee { get; set; }
    }
}
