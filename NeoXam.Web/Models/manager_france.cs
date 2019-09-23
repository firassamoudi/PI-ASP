namespace NeoXam.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("manager_france")]
    public partial class manager_france
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public manager_france()
        {
            employes = new HashSet<employe>();
        }

        [Key]
        [StringLength(255)]
        public string CIN { get; set; }

        [StringLength(254)]
        public string adresse { get; set; }

        [StringLength(254)]
        public string Email { get; set; }

        [StringLength(254)]
        public string Nom { get; set; }

        [StringLength(254)]
        public string numTel { get; set; }

        [StringLength(254)]
        public string Per_email { get; set; }

        [StringLength(254)]
        public string Prenom { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<employe> employes { get; set; }
    }
}
