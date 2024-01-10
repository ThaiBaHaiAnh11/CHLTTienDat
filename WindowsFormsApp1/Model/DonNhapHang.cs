namespace WindowsFormsApp1.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DonNhapHang")]
    public partial class DonNhapHang
    {
        [Key]
        [StringLength(10)]
        public string MaDonNhap { get; set; }

        [Required]
        [StringLength(10)]
        public string MaLT { get; set; }

        [Required]
        [StringLength(50)]
        public string TenLT { get; set; }

        public int SoLuong { get; set; }

        public double Gia { get; set; }

        [Column(TypeName = "date")]
        public DateTime ThoiGianGiao { get; set; }

        [Required]
        [StringLength(10)]
        public string MaNCC { get; set; }

        [Required]
        [StringLength(10)]
        public string MaKho { get; set; }

        [Required]
        [StringLength(10)]
        public string MaNV { get; set; }

        public virtual KhoHang KhoHang { get; set; }

        public virtual NCC NCC { get; set; }

        public virtual NhanVien NhanVien { get; set; }

        public virtual ThongTinLT ThongTinLT { get; set; }
    }
}
