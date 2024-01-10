using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WindowsFormsApp1.Model
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<DonNhapHang> DonNhapHangs { get; set; }
        public virtual DbSet<HDBan> HDBans { get; set; }
        public virtual DbSet<KhoHang> KhoHangs { get; set; }
        public virtual DbSet<NCC> NCCs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<tblKhachHang> tblKhachHangs { get; set; }
        public virtual DbSet<ThongTinLT> ThongTinLTs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DonNhapHang>()
                .Property(e => e.MaDonNhap)
                .IsFixedLength();

            modelBuilder.Entity<DonNhapHang>()
                .Property(e => e.MaLT)
                .IsFixedLength();

            modelBuilder.Entity<DonNhapHang>()
                .Property(e => e.MaNCC)
                .IsFixedLength();

            modelBuilder.Entity<DonNhapHang>()
                .Property(e => e.MaKho)
                .IsFixedLength();

            modelBuilder.Entity<DonNhapHang>()
                .Property(e => e.MaNV)
                .IsFixedLength();

            modelBuilder.Entity<HDBan>()
                .Property(e => e.MaHD)
                .IsFixedLength();

            modelBuilder.Entity<HDBan>()
                .Property(e => e.MaLT)
                .IsFixedLength();

            modelBuilder.Entity<HDBan>()
                .Property(e => e.MaNV)
                .IsFixedLength();

            modelBuilder.Entity<HDBan>()
                .Property(e => e.MaKH)
                .IsFixedLength();

            modelBuilder.Entity<KhoHang>()
                .Property(e => e.MaKho)
                .IsFixedLength();

            modelBuilder.Entity<KhoHang>()
                .Property(e => e.MaLT)
                .IsFixedLength();

            modelBuilder.Entity<KhoHang>()
                .HasMany(e => e.DonNhapHangs)
                .WithRequired(e => e.KhoHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NCC>()
                .Property(e => e.MaNCC)
                .IsFixedLength();

            modelBuilder.Entity<NCC>()
                .Property(e => e.Email)
                .IsFixedLength();

            modelBuilder.Entity<NCC>()
                .HasMany(e => e.DonNhapHangs)
                .WithRequired(e => e.NCC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NCC>()
                .HasMany(e => e.ThongTinLTs)
                .WithRequired(e => e.NCC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MaNV)
                .IsFixedLength();

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.DonNhapHangs)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.HDBans)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.TenNguoiDung)
                .IsFixedLength();

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.MatKhau)
                .IsFixedLength();

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.HoTen)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.MaNV)
                .IsFixedLength();

            modelBuilder.Entity<tblKhachHang>()
                .Property(e => e.MaKH)
                .IsFixedLength();

            modelBuilder.Entity<tblKhachHang>()
                .HasMany(e => e.HDBans)
                .WithRequired(e => e.tblKhachHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ThongTinLT>()
                .Property(e => e.MaLT)
                .IsFixedLength();

            modelBuilder.Entity<ThongTinLT>()
                .Property(e => e.MaNCC)
                .IsFixedLength();

            modelBuilder.Entity<ThongTinLT>()
                .HasMany(e => e.DonNhapHangs)
                .WithRequired(e => e.ThongTinLT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ThongTinLT>()
                .HasMany(e => e.HDBans)
                .WithRequired(e => e.ThongTinLT)
                .WillCascadeOnDelete(false);
        }
    }
}
