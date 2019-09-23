namespace NeoXam.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("reclamation")]
    public partial class reclamation
    {
        [Key]
        public int idReclamation { get; set; }

        [StringLength(255)]
        public string commentaire { get; set; }

        public DateTime? dateCreation { get; set; }

        public DateTime? DateTraitement { get; set; }

        [StringLength(254)]
        public string description { get; set; }

        [StringLength(255)]
        public string etat { get; set; }

        [StringLength(254)]
        public string motifs { get; set; }

        [StringLength(255)]
        public string CIN { get; set; }

        [StringLength(255)]
        public string Emp_CIN { get; set; }

        public virtual employe employe { get; set; }

        public virtual employe employe1 { get; set; }
    }
}
