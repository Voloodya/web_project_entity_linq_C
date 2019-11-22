namespace FastWater.EntityFastWater
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Flood")]
    public partial class Flood
    {
        [Key]
        public int Id_Flood { get; set; }

        public int Id_Post { get; set; }

        public DateTime DateAndTimes { get; set; }

        public decimal LongitudeDay { get; set; }

        public decimal? Snow { get; set; }

        public decimal? Rain { get; set; }

        public decimal? SnowRain { get; set; }

        public decimal AirHumidity { get; set; }

        public decimal? LevelSnow { get; set; }

        public decimal? HardnessSnow { get; set; }

        public int TemperatureDay { get; set; }

        public int TemperatureNight { get; set; }

        public int? Id_SolarActivity { get; set; }

        public decimal? LevelFreezingGround { get; set; }

        public int? TemperatureWater { get; set; }

        public decimal LevelWater { get; set; }

        public int WarningFlood { get; set; }

        public virtual Post Post { get; set; }

        public virtual SolarActivity SolarActivity { get; set; }
    }
}
