namespace SyncMonitor.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SyncMonitor : DbContext
    {
        public SyncMonitor()
            : base("name=SyncMonitor")
        {
        }

        public virtual DbSet<LS_Customer> LS_Customer { get; set; }
        public virtual DbSet<LS_Employee> LS_Employee { get; set; }
        public virtual DbSet<LS_Lane> LS_Lane { get; set; }
        public virtual DbSet<LS_Shift> LS_Shift { get; set; }
        public virtual DbSet<LS_Station> LS_Station { get; set; }
        public virtual DbSet<LS_TicketType> LS_TicketType { get; set; }
        public virtual DbSet<LS_VehicleType> LS_VehicleType { get; set; }
        public virtual DbSet<SUP_BlackList> SUP_BlackList { get; set; }
        public virtual DbSet<SUP_VehicleInformationManual> SUP_VehicleInformationManual { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LS_Customer>()
                .Property(e => e.CustomerCode)
                .IsUnicode(false);

            modelBuilder.Entity<LS_Customer>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<LS_Customer>()
                .Property(e => e.Telephone)
                .IsUnicode(false);

            modelBuilder.Entity<LS_Customer>()
                .Property(e => e.TaxCode)
                .IsUnicode(false);

            modelBuilder.Entity<LS_Customer>()
                .Property(e => e.EmployeeCode)
                .IsUnicode(false);

            modelBuilder.Entity<LS_Customer>()
                .Property(e => e.IDNo)
                .IsUnicode(false);

            modelBuilder.Entity<LS_Customer>()
                .Property(e => e.BankAccount)
                .IsUnicode(false);

            modelBuilder.Entity<LS_Customer>()
                .Property(e => e.Str1)
                .IsUnicode(false);

            modelBuilder.Entity<LS_Customer>()
                .Property(e => e.Str2)
                .IsUnicode(false);

            modelBuilder.Entity<LS_Employee>()
                .Property(e => e.EmployeeCode)
                .IsUnicode(false);

            modelBuilder.Entity<LS_Employee>()
                .Property(e => e.PositionCode)
                .IsUnicode(false);

            modelBuilder.Entity<LS_Employee>()
                .Property(e => e.TeamCode)
                .IsUnicode(false);

            modelBuilder.Entity<LS_Employee>()
                .Property(e => e.IDNo)
                .IsUnicode(false);

            modelBuilder.Entity<LS_Employee>()
                .Property(e => e.ManagerCode)
                .IsUnicode(false);

            modelBuilder.Entity<LS_Employee>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<LS_Employee>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<LS_Employee>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<LS_Employee>()
                .Property(e => e.SmartCardID)
                .IsUnicode(false);

            modelBuilder.Entity<LS_Lane>()
                .Property(e => e.LaneCode)
                .IsUnicode(false);

            modelBuilder.Entity<LS_Lane>()
                .Property(e => e.StationCode)
                .IsUnicode(false);

            modelBuilder.Entity<LS_Shift>()
                .Property(e => e.ShiftCode)
                .IsUnicode(false);

            modelBuilder.Entity<LS_Shift>()
                .Property(e => e.StartTime)
                .IsUnicode(false);

            modelBuilder.Entity<LS_Shift>()
                .Property(e => e.EndTime)
                .IsUnicode(false);

            modelBuilder.Entity<LS_Station>()
                .Property(e => e.StationCode)
                .IsUnicode(false);

            modelBuilder.Entity<LS_Station>()
                .Property(e => e.CompanyCode)
                .IsUnicode(false);

            modelBuilder.Entity<LS_Station>()
                .Property(e => e.ShortName)
                .IsUnicode(false);

            modelBuilder.Entity<LS_Station>()
                .HasMany(e => e.LS_Lane)
                .WithRequired(e => e.LS_Station)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LS_TicketType>()
                .Property(e => e.TicketTypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<LS_TicketType>()
                .Property(e => e.RouteCode)
                .IsUnicode(false);

            modelBuilder.Entity<LS_TicketType>()
                .Property(e => e.TicketCategoryCode)
                .IsUnicode(false);

            modelBuilder.Entity<LS_TicketType>()
                .Property(e => e.VehicleTypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<LS_VehicleType>()
                .Property(e => e.VehicleTypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<LS_VehicleType>()
                .Property(e => e.AmountPerKm)
                .HasPrecision(18, 3);

            modelBuilder.Entity<LS_VehicleType>()
                .Property(e => e.LowBalance)
                .HasPrecision(18, 3);

            modelBuilder.Entity<SUP_BlackList>()
                .Property(e => e.ProductTypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<SUP_BlackList>()
                .Property(e => e.ProductID)
                .IsUnicode(false);

            modelBuilder.Entity<SUP_BlackList>()
                .Property(e => e.EmployeeCode)
                .IsUnicode(false);

            modelBuilder.Entity<SUP_BlackList>()
                .Property(e => e.StationCode)
                .IsUnicode(false);

            modelBuilder.Entity<SUP_BlackList>()
                .Property(e => e.ReasonCode)
                .IsUnicode(false);

            modelBuilder.Entity<SUP_VehicleInformationManual>()
                .Property(e => e.RegisPlateNumber)
                .IsUnicode(false);

            modelBuilder.Entity<SUP_VehicleInformationManual>()
                .Property(e => e.AreaCode)
                .IsFixedLength();

            modelBuilder.Entity<SUP_VehicleInformationManual>()
                .Property(e => e.VehicleTypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<SUP_VehicleInformationManual>()
                .Property(e => e.EmployeeCode)
                .IsUnicode(false);
        }
    }
}
