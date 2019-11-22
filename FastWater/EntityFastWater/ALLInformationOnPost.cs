namespace FastWater.EntityFastWater
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ALLInformationOnPost")]
    public partial class ALLInformationOnPost
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public string NameLocality { get; set; }
        public int Id_Post { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string NamePost { get; set; }

        public DbGeography Koordinate { get; set; }

        [StringLength(50)]
        public string TypeGround { get; set; }

        public decimal? LevelAbsorbency { get; set; }

        public DateTime? DateAndTimes { get; set; }

        public decimal? LongitudeDay { get; set; }

        public decimal? Snow { get; set; }

        public decimal? Rain { get; set; }

        public decimal? SnowRain { get; set; }

        public decimal? AirHumidity { get; set; }

        public decimal? LevelSnow { get; set; }

        public decimal? HardnessSnow { get; set; }

        public int? TemperatureDay { get; set; }

        public int? TemperatureNight { get; set; }

        public decimal? LevelSolar { get; set; }

        public int? TemperatureWater { get; set; }

        public decimal? LevelWater { get; set; }

        public decimal? LevelFreezingGround { get; set; }

        public int? WarningFlood { get; set; }

        public decimal? ChangeLevelSnowInHour { get; set; }

        public decimal? ChangeLevelWaterInHour { get; set; }
    }
}
