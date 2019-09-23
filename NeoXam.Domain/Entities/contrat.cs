namespace NeoXam.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("contrat")]
    public partial class contrat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public contrat()
        {
            stagiaires = new HashSet<stagiaire>();
            employes = new HashSet<employe>();
        }

        [Key]
        public int idContrat { get; set; }

        public DateTime? DateDep { get; set; }

        public DateTime? DateFin { get; set; }

        [StringLength(254)]
        public string Type { get; set; }

        [StringLength(255)]
        public string idEmploye { get; set; }

        public int? idSalaire { get; set; }

        public virtual salaire salaire { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<stagiaire> stagiaires { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<employe> employes { get; set; }

        public virtual employe employe { get; set; }
    }
}
