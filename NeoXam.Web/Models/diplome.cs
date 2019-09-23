namespace NeoXam.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("diplome")]
    public partial class diplome
    {
        public int diplomeId { get; set; }

        [StringLength(254)]
        public string nom { get; set; }

        [StringLength(254)]
        public string type { get; set; }

        public int? idEcole { get; set; }

        [StringLength(255)]
        public string CIN { get; set; }

        public virtual employe employe { get; set; }

        public virtual ecole ecole { get; set; }
    }
}
