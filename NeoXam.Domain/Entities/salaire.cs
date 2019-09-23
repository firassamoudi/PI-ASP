namespace NeoXam.Domain.Entities
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

        public int? Bonus { get; set; }

        public DateTime? DateCreation { get; set; }

        public DateTime? moisEtAnne { get; set; }

        public int? salaireBrut { get; set; }

        public int? salaireNet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<contrat> contrats { get; set; }
    }
}
