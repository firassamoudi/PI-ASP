namespace NeoXam.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("cursus")]
    public partial class cursu
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(255)]
        public string CIN { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int diplomeId { get; set; }

        public DateTime? anneeDeb { get; set; }

        public DateTime? anneeFin { get; set; }

        [StringLength(254)]
        public string Mention { get; set; }

        public virtual candidat candidat { get; set; }
    }
}
