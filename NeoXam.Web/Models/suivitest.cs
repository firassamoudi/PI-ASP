namespace NeoXam.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("suivitest")]
    public partial class suivitest
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

        public virtual candidat candidat { get; set; }
    }
}
