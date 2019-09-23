namespace NeoXam.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("conge")]
    public partial class conge
    {
        [Key]
        public int idConge { get; set; }

        public DateTime? dateDebut { get; set; }

        public DateTime? dateFin { get; set; }

        [StringLength(254)]
        public string etat { get; set; }

        [StringLength(254)]
        public string motifs { get; set; }

        [StringLength(254)]
        public string raison { get; set; }

        [StringLength(254)]
        public string type { get; set; }

        [Required]
        [StringLength(255)]
        public string CIN { get; set; }

        public virtual employe employe { get; set; }
    }
}
