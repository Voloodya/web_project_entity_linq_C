namespace FastWater.EntityFastWater
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FastWaterContext : DbContext
    {
        public FastWaterContext()
            : base("name=FastWaterContext")
        {
        }

        public virtual DbSet<Basin> Basins { get; set; }
        public virtual DbSet<Flood> Floods { get; set; }
        public virtual DbSet<GeographicalKoordinate> GeographicalKoordinates { get; set; }
        public virtual DbSet<Ground> Grounds { get; set; }
        public virtual DbSet<Locality> Localities { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<PostAndLocality> PostAndLocalities { get; set; }
        public virtual DbSet<PredictionLevelSnow> PredictionLevelSnows { get; set; }
        public virtual DbSet<PredictionLevelWater> PredictionLevelWaters { get; set; }
        public virtual DbSet<SolarActivity> SolarActivities { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<WeightParameterSnow> WeightParameterSnows { get; set; }
        public virtual DbSet<WeightParametersWater> WeightParametersWaters { get; set; }
        public virtual DbSet<ALLInformationOnPost> ALLInformationOnPosts { get; set; }
        public virtual DbSet<AVGSpeedLevelSnow> AVGSpeedLevelSnows { get; set; }
        public virtual DbSet<AVGSpeedLevelWater> AVGSpeedLevelWaters { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Basin>()
                .Property(e => e.NormalSpeedBasin)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Flood>()
                .Property(e => e.LongitudeDay)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Flood>()
                .Property(e => e.Snow)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Flood>()
                .Property(e => e.Rain)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Flood>()
                .Property(e => e.SnowRain)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Flood>()
                .Property(e => e.AirHumidity)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Flood>()
                .Property(e => e.LevelSnow)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Flood>()
                .Property(e => e.HardnessSnow)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Flood>()
                .Property(e => e.LevelFreezingGround)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Flood>()
                .Property(e => e.LevelWater)
                .HasPrecision(18, 6);

            modelBuilder.Entity<GeographicalKoordinate>()
                .Property(e => e.HeighSeaLevel)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Ground>()
                .Property(e => e.LevelAbsorbency)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Post>()
                .Property(e => e.DistanceBeetwenSensors)
                .HasPrecision(18, 5);

            modelBuilder.Entity<PredictionLevelSnow>()
                .Property(e => e.ChangeLevelSnow)
                .HasPrecision(18, 6);

            modelBuilder.Entity<PredictionLevelWater>()
                .Property(e => e.ChangeLevelWater)
                .HasPrecision(18, 6);

            modelBuilder.Entity<SolarActivity>()
                .Property(e => e.LevelSolar)
                .HasPrecision(18, 5);

            modelBuilder.Entity<WeightParameterSnow>()
                .Property(e => e.LongitudeDayStart)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WeightParameterSnow>()
                .Property(e => e.LongitudeDayFinish)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WeightParameterSnow>()
                .Property(e => e.WeightLongitudeDay)
                .HasPrecision(30, 7);

            modelBuilder.Entity<WeightParameterSnow>()
                .Property(e => e.WeightSnow)
                .HasPrecision(30, 7);

            modelBuilder.Entity<WeightParameterSnow>()
                .Property(e => e.WeightRain)
                .HasPrecision(30, 7);

            modelBuilder.Entity<WeightParameterSnow>()
                .Property(e => e.WeightSnowRain)
                .HasPrecision(30, 7);

            modelBuilder.Entity<WeightParameterSnow>()
                .Property(e => e.WeightAirHumidity)
                .HasPrecision(30, 7);

            modelBuilder.Entity<WeightParameterSnow>()
                .Property(e => e.WeightLevelSnow)
                .HasPrecision(30, 7);

            modelBuilder.Entity<WeightParameterSnow>()
                .Property(e => e.WeightChangeLevelSnowBefore)
                .HasPrecision(30, 7);

            modelBuilder.Entity<WeightParameterSnow>()
                .Property(e => e.WeightHardnessSnow)
                .HasPrecision(30, 7);

            modelBuilder.Entity<WeightParameterSnow>()
                .Property(e => e.WeightTemperatureDay)
                .HasPrecision(30, 7);

            modelBuilder.Entity<WeightParameterSnow>()
                .Property(e => e.WeightTemperatureNight)
                .HasPrecision(30, 7);

            modelBuilder.Entity<WeightParameterSnow>()
                .Property(e => e.WeightSolarActivity)
                .HasPrecision(30, 7);

            modelBuilder.Entity<WeightParameterSnow>()
                .Property(e => e.WeightLevelFreezingGround)
                .HasPrecision(30, 7);

            modelBuilder.Entity<WeightParameterSnow>()
                .Property(e => e.WeightBias)
                .HasPrecision(30, 7);

            modelBuilder.Entity<WeightParametersWater>()
                .Property(e => e.LongitudeDayStart)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WeightParametersWater>()
                .Property(e => e.LongitudeDayFinish)
                .HasPrecision(18, 6);

            modelBuilder.Entity<WeightParametersWater>()
                .Property(e => e.WeightLongitudeDay)
                .HasPrecision(30, 7);

            modelBuilder.Entity<WeightParametersWater>()
                .Property(e => e.WeightSnow)
                .HasPrecision(30, 7);

            modelBuilder.Entity<WeightParametersWater>()
                .Property(e => e.WeightRain)
                .HasPrecision(30, 7);

            modelBuilder.Entity<WeightParametersWater>()
                .Property(e => e.WeightSnowRain)
                .HasPrecision(30, 7);

            modelBuilder.Entity<WeightParametersWater>()
                .Property(e => e.WeightAirHumidity)
                .HasPrecision(30, 7);

            modelBuilder.Entity<WeightParametersWater>()
                .Property(e => e.WeightLevelSnow)
                .HasPrecision(30, 7);

            modelBuilder.Entity<WeightParametersWater>()
                .Property(e => e.WeightChangeLevelSnow)
                .HasPrecision(30, 7);

            modelBuilder.Entity<WeightParametersWater>()
                .Property(e => e.WeightChangeLevelSnowBefore)
                .HasPrecision(30, 7);

            modelBuilder.Entity<WeightParametersWater>()
                .Property(e => e.WeightHardnessSnow)
                .HasPrecision(30, 7);

            modelBuilder.Entity<WeightParametersWater>()
                .Property(e => e.WeightTemperatureDay)
                .HasPrecision(30, 7);

            modelBuilder.Entity<WeightParametersWater>()
                .Property(e => e.WeightTemperatureNight)
                .HasPrecision(30, 7);

            modelBuilder.Entity<WeightParametersWater>()
                .Property(e => e.WeightSolarActivity)
                .HasPrecision(30, 7);

            modelBuilder.Entity<WeightParametersWater>()
                .Property(e => e.WeightLevelFreezingGround)
                .HasPrecision(30, 7);

            modelBuilder.Entity<WeightParametersWater>()
                .Property(e => e.WeightTemperatureWater)
                .HasPrecision(30, 7);

            modelBuilder.Entity<WeightParametersWater>()
                .Property(e => e.WeightLevelWater)
                .HasPrecision(30, 7);

            modelBuilder.Entity<WeightParametersWater>()
                .Property(e => e.WeightChangeLevelWaterBefore)
                .HasPrecision(30, 7);

            modelBuilder.Entity<WeightParametersWater>()
                .Property(e => e.WeightBias)
                .HasPrecision(30, 7);

            modelBuilder.Entity<ALLInformationOnPost>()
                .Property(e => e.LevelAbsorbency)
                .HasPrecision(18, 5);

            modelBuilder.Entity<ALLInformationOnPost>()
                .Property(e => e.LongitudeDay)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ALLInformationOnPost>()
                .Property(e => e.Snow)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ALLInformationOnPost>()
                .Property(e => e.Rain)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ALLInformationOnPost>()
                .Property(e => e.SnowRain)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ALLInformationOnPost>()
                .Property(e => e.AirHumidity)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ALLInformationOnPost>()
                .Property(e => e.LevelSnow)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ALLInformationOnPost>()
                .Property(e => e.HardnessSnow)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ALLInformationOnPost>()
                .Property(e => e.LevelSolar)
                .HasPrecision(18, 5);

            modelBuilder.Entity<ALLInformationOnPost>()
                .Property(e => e.LevelWater)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ALLInformationOnPost>()
                .Property(e => e.LevelFreezingGround)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ALLInformationOnPost>()
                .Property(e => e.ChangeLevelSnowInHour)
                .HasPrecision(30, 17);

            modelBuilder.Entity<ALLInformationOnPost>()
                .Property(e => e.ChangeLevelWaterInHour)
                .HasPrecision(30, 17);

            modelBuilder.Entity<AVGSpeedLevelSnow>()
                .Property(e => e.LevelSnow)
                .HasPrecision(18, 6);

            modelBuilder.Entity<AVGSpeedLevelSnow>()
                .Property(e => e.PastLevelSnow)
                .HasPrecision(18, 6);

            modelBuilder.Entity<AVGSpeedLevelSnow>()
                .Property(e => e.ChangeLevelSnow)
                .HasPrecision(19, 6);

            modelBuilder.Entity<AVGSpeedLevelSnow>()
                .Property(e => e.SpeedLevelSnow)
                .HasPrecision(30, 17);

            modelBuilder.Entity<AVGSpeedLevelWater>()
                .Property(e => e.LevelWater)
                .HasPrecision(18, 6);

            modelBuilder.Entity<AVGSpeedLevelWater>()
                .Property(e => e.PastLevelWater)
                .HasPrecision(18, 6);

            modelBuilder.Entity<AVGSpeedLevelWater>()
                .Property(e => e.ChangeLevelWater)
                .HasPrecision(19, 6);

            modelBuilder.Entity<AVGSpeedLevelWater>()
                .Property(e => e.SpeedLevelWater)
                .HasPrecision(30, 17);
        }
    }
}
