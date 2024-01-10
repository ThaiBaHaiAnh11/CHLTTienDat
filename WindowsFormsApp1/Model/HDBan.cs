namespace WindowsFormsApp1.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HDBan")]
    public partial class HDBan
    {
        [Key]
        [StringLength(10)]
        public string MaHD { get; set; }

        [Required]
        [StringLength(10)]
        public string MaLT { get; set; }

        [Required]
        [StringLength(50)]
        public string TenLT { get; set; }

        public int SLBan { get; set; }

        public double GiaBan { get; set; }

        [Required]
        [StringLength(10)]
        public string MaNV { get; set; }

        [Required]
        [StringLength(10)]
        public string MaKH { get; set; }

        [Required]
        [StringLength(50)]
        public string TenKH { get; set; }

        public DateTime NgayBan { get; set; }

        public double TongHD { get; set; }

        public virtual NhanVien NhanVien { get; set; }

        public virtual tblKhachHang tblKhachHang { get; set; }

        public virtual ThongTinLT ThongTinLT { get; set; }
    }
}
