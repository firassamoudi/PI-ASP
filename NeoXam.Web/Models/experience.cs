namespace NeoXam.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("experience")]
    public partial class experience
    {
        [Key]
        public int idExpe { get; set; }

        [StringLength(254)]
        public string Nom { get; set; }

        [StringLength(255)]
        public string Type { get; set; }
    }
}
