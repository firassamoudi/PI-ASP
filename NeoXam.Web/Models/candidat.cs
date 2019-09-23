namespace NeoXam.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("candidat")]
    public partial class candidat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public candidat()
        {
            users = new HashSet<user>();
            curriculumvitaes = new HashSet<curriculumvitae>();
            cursus = new HashSet<cursu>();
            suivitests = new HashSet<suivitest>();
            skills = new HashSet<skill>();
            carrieres = new HashSet<carriere>();
            fichierpsts = new HashSet<fichierpst>();
        }

        [Key]
        [StringLength(255)]
        public string CIN { get; set; }

        [StringLength(254)]
        public string adresse { get; set; }

        [StringLength(254)]
        public string Email { get; set; }

        [StringLength(254)]
        public string image { get; set; }

        [StringLength(254)]
        public string linkedin { get; set; }

        [StringLength(254)]
        public string Nom { get; set; }

        [StringLength(254)]
        public string numTel { get; set; }

        [StringLength(254)]
        public string Per_email { get; set; }

        [StringLength(254)]
        public string Prenom { get; set; }

        [StringLength(254)]
        public string resume { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<user> users { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<curriculumvitae> curriculumvitaes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cursu> cursus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<suivitest> suivitests { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<skill> skills { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<carriere> carrieres { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fichierpst> fichierpsts { get; set; }
    }
}
