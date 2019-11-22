namespace FastWater.EntityFastWater
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WeightParameterSnow")]
    public partial class WeightParameterSnow
    {
        [Key]
        public int Id_WeightParameterSnow { get; set; }

        public int Id_Post { get; set; }

        public int CountInputs { get; set; }

        public int CountLayer { get; set; }

        public int NumberLayer { get; set; }

        public int CountNeuron { get; set; }

        public decimal? LongitudeDayStart { get; set; }

        public decimal? LongitudeDayFinish { get; set; }

        public decimal? WeightLongitudeDay { get; set; }

        public decimal? WeightSnow { get; set; }

        public decimal? WeightRain { get; set; }

        public decimal? WeightSnowRain { get; set; }

        public decimal? WeightAirHumidity { get; set; }

        public decimal? WeightLevelSnow { get; set; }

        public decimal? WeightChangeLevelSnowBefore { get; set; }

        public decimal? WeightHardnessSnow { get; set; }

        public decimal? WeightTemperatureDay { get; set; }

        public decimal? WeightTemperatureNight { get; set; }

        public decimal? WeightSolarActivity { get; set; }

        public decimal? WeightLevelFreezingGround { get; set; }

        public decimal? WeightBias { get; set; }

        public virtual Post Post { get; set; }
    }
}
