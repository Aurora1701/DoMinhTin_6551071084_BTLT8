#nullable disable
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;

namespace Bai1C9.Models;

public partial class TiemTapHoaContext : DbContext
{
    public TiemTapHoaContext()
    {
    }

    public TiemTapHoaContext(DbContextOptions<TiemTapHoaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<HangHoa> HangHoas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(
                @"Server=.;Database=TiemTapHoa;Trusted_Connection=True;TrustServerCertificate=True;",
                options => options.EnableRetryOnFailure()
            );
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<HangHoa>(entity =>
        {
            entity.HasKey(e => e.MaHang);

            entity.ToTable("HangHoa");

            entity.Property(e => e.ConKinhDoanh)
                .HasDefaultValue(true)
                .HasAnnotation("Relational:DefaultConstraintName", "DF_HangHoa_ConKinhDoanh");
            entity.Property(e => e.DonVi).HasMaxLength(20);
            entity.Property(e => e.GiaBan).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.LoaiHang).HasMaxLength(50);
            entity.Property(e => e.NgayNhap)
                .HasDefaultValueSql("(getdate())")
                .HasAnnotation("Relational:DefaultConstraintName", "DF_HangHoa_NgayNhap")
                .HasColumnType("datetime");
            entity.Property(e => e.SoLuongTon).HasAnnotation("Relational:DefaultConstraintName", "DF_HangHoa_SoLuongTon");
            entity.Property(e => e.TenHang)
                .IsRequired()
                .HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}