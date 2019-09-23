namespace NeoXam.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ecole")]
    public partial class ecole
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ecole()
        {
            diplomes = new HashSet<diplome>();
        }

        [Key]
        public int idEcole { get; set; }

        [StringLength(254)]
        public string Nom { get; set; }

        [StringLength(254)]
        public string pays { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<diplome> diplomes { get; set; }
    }
}
