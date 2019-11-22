namespace FastWater.EntityFastWater
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Post")]
    public partial class Post
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Post()
        {
            Floods = new HashSet<Flood>();
            PostAndLocalities = new HashSet<PostAndLocality>();
            PredictionLevelSnows = new HashSet<PredictionLevelSnow>();
            PredictionLevelWaters = new HashSet<PredictionLevelWater>();
            WeightParameterSnows = new HashSet<WeightParameterSnow>();
            WeightParametersWaters = new HashSet<WeightParametersWater>();
        }

        [Key]
        public int Id_Post { get; set; }

        [Required]
        [StringLength(50)]
        public string NamePost { get; set; }

        [ForeignKey("GeographicalKoordinate")]
        public int? Id_GeographicalKoordinates { get; set; }

        [ForeignKey("Basin")]
        public int? Id_Basin { get; set; }

        [ForeignKey("Ground")]
        public int? Id_Ground { get; set; }

        [ForeignKey("Locality")]
        public int? Id_Locality { get; set; }

        public decimal DistanceBeetwenSensors { get; set; }

        [StringLength(50)]
        public string description { get; set; }

        public virtual Basin Basin { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Flood> Floods { get; set; }

        public virtual GeographicalKoordinate GeographicalKoordinate { get; set; }

        public virtual Ground Ground { get; set; }

        public virtual Locality Locality { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PostAndLocality> PostAndLocalities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PredictionLevelSnow> PredictionLevelSnows { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PredictionLevelWater> PredictionLevelWaters { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WeightParameterSnow> WeightParameterSnows { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WeightParametersWater> WeightParametersWaters { get; set; }
    }
}
