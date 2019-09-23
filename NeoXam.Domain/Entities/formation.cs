namespace NeoXam.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("formation")]
    public partial class formation
    {
        [Key]
        public int idFormation { get; set; }

        [StringLength(254)]
        public string DateDebut { get; set; }

        [StringLength(254)]
        public string libelle { get; set; }

        [StringLength(254)]
        public string lieux { get; set; }

        [StringLength(254)]
        public string Responsable { get; set; }

        [StringLength(255)]
        public string CIN { get; set; }

        public int formateurid { get; set; }

        public virtual employe employe { get; set; }

        public virtual formateur formateur { get; set; }
    }
}
