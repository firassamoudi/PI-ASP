namespace NeoXam.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("curriculumvitae")]
    public partial class curriculumvitae
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public curriculumvitae()
        {
            analyseurs = new HashSet<analyseur>();
        }

        [Key]
        public int idCV { get; set; }

        [StringLength(254)]
        public string blocCompetence { get; set; }

        [StringLength(254)]
        public string blocDiplome { get; set; }

        [StringLength(254)]
        public string blocExperience { get; set; }

        [StringLength(254)]
        public string blocInfosPersonnel { get; set; }

        [StringLength(254)]
        public string contenu { get; set; }

        [StringLength(254)]
        public string path { get; set; }

        [StringLength(255)]
        public string candidat_CIN { get; set; }

        public virtual candidat candidat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<analyseur> analyseurs { get; set; }
    }
}
