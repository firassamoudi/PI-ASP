namespace NeoXam.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("attestation_de_stage")]
    public partial class attestation_de_stage
    {
        [Key]
        public int idDoc { get; set; }

        public DateTime? DateCreation { get; set; }

        [StringLength(254)]
        public string Description { get; set; }

        [StringLength(254)]
        public string objectif { get; set; }

        [StringLength(254)]
        public string titre { get; set; }

        [StringLength(254)]
        public string Type { get; set; }

        [StringLength(255)]
        public string CIN { get; set; }

        public virtual employe employe { get; set; }
    }
}
