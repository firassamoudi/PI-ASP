namespace NeoXam.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("test")]
    public partial class test
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public test()
        {
            questions = new HashSet<question>();
        }

        [Key]
        public int idTest { get; set; }

        public DateTime? DateExpiration { get; set; }

        [StringLength(254)]
        public string description { get; set; }

        [StringLength(254)]
        public string nom { get; set; }

        [StringLength(254)]
        public string type { get; set; }

        public int? idCatego { get; set; }

        public virtual categorytest categorytest { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<question> questions { get; set; }
    }
}
