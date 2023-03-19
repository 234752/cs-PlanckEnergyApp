using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PlanckEnergyMVC.DataDB;

public partial class TestContext : DbContext
{
    public TestContext()
    {
    }

    public TestContext(DbContextOptions<TestContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Material> Materials { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=Test;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Material>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Material__3214EC07E15B832C");

            entity.ToTable("Material");

            entity.Property(e => e.CellAngleAlpha)
                .HasMaxLength(50)
                .HasColumnName("_cell_angle_alpha");
            entity.Property(e => e.CellAngleBeta)
                .HasMaxLength(50)
                .HasColumnName("_cell_angle_beta");
            entity.Property(e => e.CellAngleGamma)
                .HasMaxLength(50)
                .HasColumnName("_cell_angle_gamma");
            entity.Property(e => e.CellLengthA)
                .HasMaxLength(50)
                .HasColumnName("_cell_length_a");
            entity.Property(e => e.CellLengthB)
                .HasMaxLength(50)
                .HasColumnName("_cell_length_b");
            entity.Property(e => e.CellLengthC)
                .HasMaxLength(50)
                .HasColumnName("_cell_length_c");
            entity.Property(e => e.CellVolume)
                .HasMaxLength(50)
                .HasColumnName("_cell_volume");
            entity.Property(e => e.ChemicalFormulaMoiety)
                .HasMaxLength(50)
                .HasColumnName("_chemical_formula_moiety");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.SpaceGroupNameHall)
                .HasMaxLength(50)
                .HasColumnName("_space_group_name_Hall");
            entity.Property(e => e.SymmetryCellSetting)
                .HasMaxLength(50)
                .HasColumnName("_symmetry_cell_setting");
            entity.Property(e => e.SymmetryIntTablesNumber)
                .HasMaxLength(50)
                .HasColumnName("_symmetry_Int_Tables_number");
            entity.Property(e => e.SymmetrySpaceGroupNameHM)
                .HasMaxLength(50)
                .HasColumnName("_symmetry_space_group_name_H_M");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
