namespace WindowsFormsApp1.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhoHang")]
    public partial class KhoHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhoHang()
        {
            DonNhapHangs = new HashSet<DonNhapHang>();
        }

        [Key]
        [StringLength(10)]
        public string MaKho { get; set; }

        [Required]
        [StringLength(50)]
        public string TenKho { get; set; }

        [Required]
        [StringLength(10)]
        public string MaLT { get; set; }

        [Required]
        [StringLength(50)]
        public string TenLT { get; set; }

        public int SoLuong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DonNhapHang> DonNhapHangs { get; set; }
    }
}
