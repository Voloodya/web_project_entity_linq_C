namespace FastWater.EntityFastWater
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PredictionLevelSnow")]
    public partial class PredictionLevelSnow
    {
        [Key]
        public int Id_PredictionLevelSnow { get; set; }

        public int Id_Post { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date_ { get; set; }

        public TimeSpan? Time_ { get; set; }

        public decimal? ChangeLevelSnow { get; set; }

        public int LevelSnow { get; set; }

        public int WarningFlood { get; set; }

        public virtual Post Post { get; set; }
    }
}
