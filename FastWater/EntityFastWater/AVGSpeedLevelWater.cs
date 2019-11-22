namespace FastWater.EntityFastWater
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AVGSpeedLevelWater")]
    public partial class AVGSpeedLevelWater
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id_Flood { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string NamePost { get; set; }

        [Required]
        public DbGeography Koordinate { get; set; }

        public string KoordinateText { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime DateAndTimes { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal LevelWater { get; set; }

        public decimal? PastLevelWater { get; set; }

        public DateTime? PastDateAndTimes { get; set; }

        public decimal? ChangeLevelWater { get; set; }

        public decimal? SpeedLevelWater { get; set; }
    }
}
