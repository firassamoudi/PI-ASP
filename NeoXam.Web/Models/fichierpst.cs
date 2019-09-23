namespace NeoXam.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fichierpst")]
    public partial class fichierpst
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public fichierpst()
        {
            candidats = new HashSet<candidat>();
        }

        public int id { get; set; }

        public DateTime? DateCreation { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        [StringLength(255)]
        public string path { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<candidat> candidats { get; set; }
    }
}
