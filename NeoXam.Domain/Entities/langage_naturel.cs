namespace NeoXam.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("langage_naturel")]
    public partial class langage_naturel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public langage_naturel()
        {
            mots = new HashSet<mot>();
        }

        [Required]
        [StringLength(31)]
        public string DTYPE { get; set; }

        [Key]
        public int idLang { get; set; }

        [StringLength(254)]
        public string type { get; set; }

        public int idAnalyseur { get; set; }

        public virtual analyseur analyseur { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<mot> mots { get; set; }
    }
}
