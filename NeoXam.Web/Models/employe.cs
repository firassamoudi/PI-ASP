namespace NeoXam.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("employe")]
    public partial class employe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public employe()
        {
            attestaion_de_travail = new HashSet<attestaion_de_travail>();
            attestation_de_stage = new HashSet<attestation_de_stage>();
            autorisation_conge = new HashSet<autorisation_conge>();
            conges = new HashSet<conge>();
            contrats = new HashSet<contrat>();
            diplomes = new HashSet<diplome>();
            notes = new HashSet<note>();
            evenements = new HashSet<evenement>();
            suivi_risk = new HashSet<suivi_risk>();
            formations = new HashSet<formation>();
            users = new HashSet<user>();
            suivis = new HashSet<suivi>();
            reclamations = new HashSet<reclamation>();
            suivitestemployees = new HashSet<suivitestemployee>();
            employe1 = new HashSet<employe>();
            equipes = new HashSet<equipe>();
            reclamations1 = new HashSet<reclamation>();
            employe11 = new HashSet<employe>();
        }

        [Key]
        [StringLength(255)]
        public string CIN { get; set; }

        [StringLength(254)]
        public string adresse { get; set; }

        [StringLength(254)]
        public string Email { get; set; }

        public int haveC { get; set; }

        [StringLength(254)]
        public string image { get; set; }

        public DateTime? joinDate { get; set; }

        public DateTime? lastDay { get; set; }

        public int? nbJours { get; set; }

        [StringLength(254)]
        public string Nom { get; set; }

        [StringLength(254)]
        public string numTel { get; set; }

        [StringLength(254)]
        public string Per_email { get; set; }

        [StringLength(254)]
        public string Prenom { get; set; }

        public int? rib { get; set; }

        [StringLength(254)]
        public string type { get; set; }

        public int? IdContraEmploye { get; set; }

        public int? idDep { get; set; }

        [StringLength(255)]
        public string employeCIN1 { get; set; }

        [StringLength(255)]
        public string employeCIN2 { get; set; }

        public int? idEquipe { get; set; }

        public int? idGrade { get; set; }

        [StringLength(255)]
        public string CIN_Man { get; set; }

        public int? idMetier { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<attestaion_de_travail> attestaion_de_travail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<attestation_de_stage> attestation_de_stage { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<autorisation_conge> autorisation_conge { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<conge> conges { get; set; }

        public virtual contrat contrat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<contrat> contrats { get; set; }

        public virtual departement departement { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<diplome> diplomes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<note> notes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<evenement> evenements { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<suivi_risk> suivi_risk { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<formation> formations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<user> users { get; set; }

        public virtual equipe equipe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<suivi> suivis { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<reclamation> reclamations { get; set; }

        public virtual grade grade { get; set; }

        public virtual metier metier { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<suivitestemployee> suivitestemployees { get; set; }

        public virtual manager_france manager_france { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<employe> employe1 { get; set; }

        public virtual employe employe2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<equipe> equipes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<reclamation> reclamations1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<employe> employe11 { get; set; }

        public virtual employe employe3 { get; set; }
    }
}
