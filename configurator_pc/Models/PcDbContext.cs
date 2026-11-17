using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace configurator_pc.Models;

public partial class PcDbContext : DbContext
{
    public PcDbContext()
    {
    }

    public PcDbContext(DbContextOptions<PcDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Build> Builds { get; set; }

    public virtual DbSet<Case> Cases { get; set; }

    public virtual DbSet<Cooler> Coolers { get; set; }

    public virtual DbSet<Gpu> Gpus { get; set; }

    public virtual DbSet<Motherboard> Motherboards { get; set; }

    public virtual DbSet<Power> Powers { get; set; }

    public virtual DbSet<Processor> Processors { get; set; }

    public virtual DbSet<Ram> Rams { get; set; }

    public virtual DbSet<Storage> Storages { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=VERONIKA\\SQLEXPRESS;Database=pc_db;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Build>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.IdBuilds).HasColumnName("id builds");
            entity.Property(e => e.IdCase).HasColumnName("id case");
            entity.Property(e => e.IdCooler).HasColumnName("id cooler");
            entity.Property(e => e.IdGpu).HasColumnName("id gpu");
            entity.Property(e => e.IdMotherboard).HasColumnName("id motherboard");
            entity.Property(e => e.IdPower).HasColumnName("id power");
            entity.Property(e => e.IdProcessor).HasColumnName("id processor");
            entity.Property(e => e.IdRam).HasColumnName("id_ram");
            entity.Property(e => e.IdStorage).HasColumnName("id storage");
            entity.Property(e => e.IdUser).HasColumnName("id_user");
            entity.Property(e => e.TotalPrice)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("Total price");

            entity.HasOne(d => d.IdCaseNavigation).WithMany()
                .HasForeignKey(d => d.IdCase)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Builds_Cases");

            entity.HasOne(d => d.IdCoolerNavigation).WithMany()
                .HasForeignKey(d => d.IdCooler)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Builds_Coolers");

            entity.HasOne(d => d.IdGpuNavigation).WithMany()
                .HasForeignKey(d => d.IdGpu)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Builds_GPU");

            entity.HasOne(d => d.IdMotherboardNavigation).WithMany()
                .HasForeignKey(d => d.IdMotherboard)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Builds_Motherboards");

            entity.HasOne(d => d.IdPowerNavigation).WithMany()
                .HasForeignKey(d => d.IdPower)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Builds_Power");

            entity.HasOne(d => d.IdProcessorNavigation).WithMany()
                .HasForeignKey(d => d.IdProcessor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Builds_Processors");

            entity.HasOne(d => d.IdRamNavigation).WithMany()
                .HasForeignKey(d => d.IdRam)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Builds_RAM");

            entity.HasOne(d => d.IdStorageNavigation).WithMany()
                .HasForeignKey(d => d.IdStorage)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Builds_Storage");

            entity.HasOne(d => d.IdUserNavigation).WithMany()
                .HasForeignKey(d => d.IdUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Builds_User");
        });

        modelBuilder.Entity<Case>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FormFactor)
                .HasMaxLength(50)
                .HasColumnName("Form factor");
            entity.Property(e => e.Image).HasMaxLength(300);
            entity.Property(e => e.MaxCooler).HasColumnName("Max cooler");
            entity.Property(e => e.MaxGpu).HasColumnName("Max gpu");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
        });

        modelBuilder.Entity<Cooler>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Image).HasMaxLength(300);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Socket)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Gpu>(entity =>
        {
            entity.ToTable("GPU");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EnergyConsumption).HasColumnName("Energy consumption");
            entity.Property(e => e.Image).HasMaxLength(300);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
        });

        modelBuilder.Entity<Motherboard>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FormFactor)
                .HasMaxLength(50)
                .HasColumnName("Form factor");
            entity.Property(e => e.Image).HasMaxLength(300);
            entity.Property(e => e.MemoryType)
                .HasMaxLength(50)
                .HasColumnName("Memory type");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Socket).HasMaxLength(50);
        });

        modelBuilder.Entity<Power>(entity =>
        {
            entity.ToTable("Power");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Image).HasMaxLength(300);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
        });

        modelBuilder.Entity<Processor>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CoresCount).HasColumnName("Cores count");
            entity.Property(e => e.EnergyConsumption).HasColumnName("Energy consumption");
            entity.Property(e => e.Image).HasMaxLength(300);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Socket)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Ram>(entity =>
        {
            entity.ToTable("RAM");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Image).HasMaxLength(300);
            entity.Property(e => e.MemoryType)
                .HasMaxLength(50)
                .HasColumnName("Memory type");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
        });

        modelBuilder.Entity<Storage>(entity =>
        {
            entity.ToTable("Storage");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Image).HasMaxLength(300);
            entity.Property(e => e.Interface).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("User");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Login).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(50);
            entity.Property(e => e.Role).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
