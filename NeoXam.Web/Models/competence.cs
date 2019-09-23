namespace NeoXam.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("competence")]
    public partial class competence
    {
        [Key]
        public int idCompetence { get; set; }

        [StringLength(254)]
        public string tag { get; set; }

        [StringLength(254)]
        public string type { get; set; }
    }
}
