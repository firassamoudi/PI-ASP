namespace NeoXam.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("critere")]
    public partial class critere
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public critere()
        {
            suivi_risk = new HashSet<suivi_risk>();
        }

        [Key]
        [StringLength(254)]
        public string idcritere { get; set; }

        [StringLength(254)]
        public string fait { get; set; }

        [StringLength(254)]
        public string risque { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<suivi_risk> suivi_risk { get; set; }
    }
}
