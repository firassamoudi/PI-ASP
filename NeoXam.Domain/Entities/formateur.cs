namespace NeoXam.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("formateur")]
    public partial class formateur
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public formateur()
        {
            formations = new HashSet<formation>();
        }

        public int id { get; set; }

        [Required(ErrorMessage = "obligatoire!")]
        [StringLength(25, ErrorMessage = "le nom ne doit pas dépasser 25 caractéres")]
        [MaxLength(50)]
        public string nom { get; set; }

        [Required(ErrorMessage = "obligatoire!")]
        [StringLength(25, ErrorMessage = "le prenom ne doit pas dépasser 25 caractéres")]
        [MaxLength(50)]
        public string prenom { get; set; }
        public string address{ get; set; }
        public string numTel { get; set; }
        public string email { get; set; }
        public string facebook { get; set; }
        public string linkedin { get; set; }
        public string Description{ get; set; }
        public string photo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<formation> formations { get; set; }
    }
}
