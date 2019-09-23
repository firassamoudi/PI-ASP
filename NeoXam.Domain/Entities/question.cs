namespace NeoXam.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("question")]
    public partial class question
    {
        [Key]
        public int idQuestion { get; set; }

        [StringLength(254)]
        public string choixA { get; set; }

        [StringLength(254)]
        public string choixB { get; set; }

        [StringLength(254)]
        public string choixC { get; set; }

        [StringLength(254)]
        public string contenue { get; set; }

        [StringLength(254)]
        public string image { get; set; }

        [StringLength(254)]
        public string reponse { get; set; }

        [StringLength(254)]
        public string type { get; set; }

        public int? idTest { get; set; }

        public virtual test test { get; set; }
    }
}
