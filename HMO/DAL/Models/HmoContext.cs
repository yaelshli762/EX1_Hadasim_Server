using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

public partial class HmoContext : DbContext
{
    public HmoContext()
    {
    }

    public HmoContext(DbContextOptions<HmoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Patient> Patients { get; set; }

    public virtual DbSet<PatientsCorona> PatientsCoronas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=HMO;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Patient>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Patients__3214EC2753CF0AE2");

            entity.Property(e => e.Id)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("ID");
            entity.Property(e => e.Adress)
                .HasMaxLength(225)
                .IsUnicode(false);
            entity.Property(e => e.BirthDate).HasColumnType("date");
            entity.Property(e => e.CellPhone)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(225)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(225)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(9)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PatientsCorona>(entity =>
        {
            entity.HasKey(e => e.PatientCode).HasName("PK__Patients__B9C66DFFCBDE32D4");

            entity.ToTable("PatientsCorona");

            entity.Property(e => e.Manufacturer1)
                .HasMaxLength(225)
                .IsUnicode(false);
            entity.Property(e => e.Manufacturer2)
                .HasMaxLength(225)
                .IsUnicode(false);
            entity.Property(e => e.Manufacturer3)
                .HasMaxLength(225)
                .IsUnicode(false);
            entity.Property(e => e.Manufacturer4)
                .HasMaxLength(225)
                .IsUnicode(false);
            entity.Property(e => e.PatientId)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("PatientID");
            entity.Property(e => e.RecoveryDate).HasColumnType("date");
            entity.Property(e => e.Vaccine1).HasColumnType("date");
            entity.Property(e => e.Vaccine2).HasColumnType("date");
            entity.Property(e => e.Vaccine3).HasColumnType("date");
            entity.Property(e => e.Vaccine4).HasColumnType("date");

            entity.HasOne(d => d.Patient).WithMany(p => p.PatientsCoronas)
                .HasForeignKey(d => d.PatientId)
                .HasConstraintName("FK__PatientsC__Patie__36B12243");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
