namespace NeoXam.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("suivitestemployee")]
    public partial class suivitestemployee
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(255)]
        public string CIN { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idTest { get; set; }

        public DateTime? Date { get; set; }

        public int? Resultat { get; set; }

        public DateTime? temps { get; set; }

        public virtual employe employe { get; set; }
    }
}
