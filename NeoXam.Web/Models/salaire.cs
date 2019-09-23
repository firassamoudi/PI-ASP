namespace NeoXam.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("salaire")]
    public partial class salaire
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public salaire()
        {
            contrats = new HashSet<contrat>();
        }

        [Key]
        public int idSalaire { get; set; }

        [Display(Name = "bonus")]
        public int? Bonus { get; set; }

        [Display(Name = "Date du création")]
        [DataType(DataType.Date)]
        public DateTime? DateCreation { get; set; }

        [Display(Name = "mois et année")]
        [DataType(DataType.Date)]
        public DateTime? moisEtAnne { get; set; }

        [Display(Name = "Salaire Brute")]
        public int? salaireBrut { get; set; }

        [Display(Name = "Salaire Net")]
        public int? salaireNet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<contrat> contrats { get; set; }
    }
}
