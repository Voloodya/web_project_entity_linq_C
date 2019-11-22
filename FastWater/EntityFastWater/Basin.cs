namespace FastWater.EntityFastWater
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Basin")]
    public partial class Basin
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Basin()
        {
            Posts = new HashSet<Post>();
        }

        [Key]
        public int Id_Basin { get; set; }

        [Required]
        [StringLength(50)]
        public string NameBasin { get; set; }

        public int? Id_GeographicalKoordinates { get; set; }

        public decimal? NormalSpeedBasin { get; set; }

        [StringLength(50)]
        public string description { get; set; }

        public virtual GeographicalKoordinate GeographicalKoordinate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Post> Posts { get; set; }
    }
}
