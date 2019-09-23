namespace NeoXam.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("analyseur")]
    public partial class analyseur
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public analyseur()
        {
            langage_naturel = new HashSet<langage_naturel>();
            curriculumvitaes = new HashSet<curriculumvitae>();
        }

        [Required]
        [StringLength(31)]
        public string DTYPE { get; set; }

        [Key]
        public int idAnalyseur { get; set; }

        [StringLength(254)]
        public string libel { get; set; }

        [StringLength(254)]
        public string type { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<langage_naturel> langage_naturel { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<curriculumvitae> curriculumvitaes { get; set; }
    }
}
