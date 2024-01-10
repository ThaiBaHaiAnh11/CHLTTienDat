namespace WindowsFormsApp1.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThongTinLT")]
    public partial class ThongTinLT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ThongTinLT()
        {
            DonNhapHangs = new HashSet<DonNhapHang>();
            HDBans = new HashSet<HDBan>();
        }

        [Key]
        [StringLength(10)]
        public string MaLT { get; set; }

        [Required]
        [StringLength(30)]
        public string TenLT { get; set; }

        [Required]
        [StringLength(30)]
        public string XuatXu { get; set; }

        public int Gia { get; set; }

        [Required]
        [StringLength(10)]
        public string MaNCC { get; set; }

        public int SoLuong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DonNhapHang> DonNhapHangs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HDBan> HDBans { get; set; }

        public virtual NCC NCC { get; set; }
    }
}
