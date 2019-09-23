namespace NeoXam.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("skills")]
    public partial class skill
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(255)]
        public string CIN { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idCompetence { get; set; }

        [StringLength(254)]
        public string description { get; set; }

        [StringLength(254)]
        public string niveau { get; set; }

        [StringLength(254)]
        public string Verifier { get; set; }

        public virtual candidat candidat { get; set; }
    }
}
