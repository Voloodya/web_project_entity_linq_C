namespace FastWater.EntityFastWater
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Locality")]
    public partial class Locality
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Locality()
        {
            Posts = new HashSet<Post>();
            PostAndLocalities = new HashSet<PostAndLocality>();
        }

        [Key]
        public int Id_Locality { get; set; }

        [Required]
        [StringLength(50)]
        public string NameLocality { get; set; }

        public int? Id_GeographicalKoordinates { get; set; }

        [StringLength(50)]
        public string description { get; set; }

        public virtual GeographicalKoordinate GeographicalKoordinate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Post> Posts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PostAndLocality> PostAndLocalities { get; set; }
    }
}
