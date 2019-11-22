namespace FastWater.EntityFastWater
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PostAndLocality")]
    public partial class PostAndLocality
    {
        [Key]
        public int Id_PostAndLocality { get; set; }

        public int Id_Post { get; set; }

        public int Id_Locality { get; set; }

        public virtual Locality Locality { get; set; }

        public virtual Post Post { get; set; }
    }
}
