using System;

namespace FastWater.DatabaseFastWaterService
{
    public class FloodJoin
    {
        public int Id_flood { get; set; }
        public string NamePost { get; set; }
        public string Koords { get; set; }
        public DateTime Date { get; set; }
        public decimal LongitudeDay { get; set; }
        public decimal? Snow { get; set; }
        public decimal? Rain { get; set; }
        public decimal? SnowRain { get; set; }
        public decimal AirHumidity { get; set; }
        public decimal? LevelSnow { get; set; }
        public decimal? HardnessSnow { get; set; }
        public int TemperatureDay { get; set; }
        public int TemperatureNight { get; set; }
        public decimal Id_SolarActivity { get; set; }
        public decimal? LevelFreezingGround { get; set; }
        public int? TemperatureWater { get; set; }
        public decimal LevelWater { get; set; }
        public int WarningFlood { get; set; }
    }
}