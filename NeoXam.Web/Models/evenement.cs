namespace NeoXam.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("evenement")]
    public partial class evenement
    {
        [Key]
        public int idEvent { get; set; }

        [StringLength(254)]
        public string Description { get; set; }

        [StringLength(254)]
        public string libelle { get; set; }

        [StringLength(254)]
        public string lieu { get; set; }

        [StringLength(254)]
        public string Type { get; set; }

        [Required]
        [StringLength(255)]
        public string CIN { get; set; }

        public virtual employe employe { get; set; }
    }
}
