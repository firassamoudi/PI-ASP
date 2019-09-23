namespace NeoXam.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("carriere")]
    public partial class carriere
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(255)]
        public string CIN { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idExpe { get; set; }

        public DateTime? DateDep { get; set; }

        public DateTime? DateFin { get; set; }

        [StringLength(254)]
        public string niveau { get; set; }

        [StringLength(254)]
        public string societe { get; set; }

        public virtual candidat candidat { get; set; }
    }
}
