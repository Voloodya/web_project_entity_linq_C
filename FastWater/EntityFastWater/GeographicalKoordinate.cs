namespace FastWater.EntityFastWater
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GeographicalKoordinate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GeographicalKoordinate()
        {
            Basins = new HashSet<Basin>();
            Localities = new HashSet<Locality>();
            Posts = new HashSet<Post>();
        }

        [Key]
        public int Id_GeographicalKoordinates { get; set; }

        [Required]
        public DbGeography Koordinate { get; set; }

        public int? SRID { get; set; }

        public int? RadiusAction { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DbGeography AllKoordinatesArea { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string KoordinateText { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string AllKoordinatesAreaTxt { get; set; }

        public decimal? HeighSeaLevel { get; set; }

        [StringLength(50)]
        public string description { get; set; }

        [StringLength(50)]
        public string TypeKoordinates { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Basin> Basins { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Locality> Localities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Post> Posts { get; set; }
    }
}
