namespace NeoXam.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("equipe")]
    public partial class equipe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public equipe()
        {
            employes = new HashSet<employe>();
            suivi_risk = new HashSet<suivi_risk>();
        }

        [Key]
        public int idEquipe { get; set; }

        [StringLength(254)]
        public string labelEquipe { get; set; }

        [StringLength(255)]
        public string CIN { get; set; }

        public int? idPro { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<employe> employes { get; set; }

        public virtual employe employe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<suivi_risk> suivi_risk { get; set; }

        public virtual produit produit { get; set; }
    }
}
