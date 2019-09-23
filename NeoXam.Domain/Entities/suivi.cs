namespace NeoXam.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("suivi")]
    public partial class suivi
    {
        [Key]
        public int idSuiv { get; set; }
        [Display(Name = "Date de suivi")]
        [DataType(DataType.Date)]
        public DateTime? DateSuivi { get; set; }
        [Display(Name = "Entretient de carriere")]
        [DataType(DataType.MultilineText)]
        [StringLength(254)]
        public string EntretrienTCarriere { get; set; }
        [Display(Name = "Evaluation")]
        [StringLength(254)]
        public string Eval { get; set; }
        public virtual employe employe { get; set; }
        [StringLength(255)]
        public string CIN { get; set; }
    }
}
