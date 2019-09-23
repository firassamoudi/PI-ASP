namespace NeoXam.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ContextNeo : DbContext
    {
        public ContextNeo()
            : base("name=ContextNeo")
        {
        }

        public virtual DbSet<analyseur> analyseur { get; set; }
        public virtual DbSet<attestaion_de_travail> attestaion_de_travail { get; set; }
        public virtual DbSet<attestation_de_stage> attestation_de_stage { get; set; }
        public virtual DbSet<autorisation_conge> autorisation_conge { get; set; }
        public virtual DbSet<candidat> candidat { get; set; }
        public virtual DbSet<carriere> carriere { get; set; }
        public virtual DbSet<categorytest> categorytest { get; set; }
        public virtual DbSet<competence> competence { get; set; }
        public virtual DbSet<conge> conge { get; set; }
        public virtual DbSet<contrat> contrat { get; set; }
        public virtual DbSet<critere> critere { get; set; }
        public virtual DbSet<curriculumvitae> curriculumvitae { get; set; }
        public virtual DbSet<cursus> cursus { get; set; }
        public virtual DbSet<departement> departement { get; set; }
        public virtual DbSet<diplome> diplome { get; set; }
        public virtual DbSet<ecole> ecole { get; set; }
        public virtual DbSet<employe> employe { get; set; }
        public virtual DbSet<equipe> equipe { get; set; }
        public virtual DbSet<evenement> evenement { get; set; }
        public virtual DbSet<experience> experience { get; set; }
        public virtual DbSet<fichierpst> fichierpst { get; set; }
        public virtual DbSet<formateur> formateur { get; set; }
        public virtual DbSet<formation> formation { get; set; }
        public virtual DbSet<grade> grade { get; set; }
        public virtual DbSet<langage_naturel> langage_naturel { get; set; }
        public virtual DbSet<manager_france> manager_france { get; set; }
        public virtual DbSet<metier> metier { get; set; }
        public virtual DbSet<mot> mot { get; set; }
        public virtual DbSet<note> note { get; set; }
        public virtual DbSet<produit> produit { get; set; }
        public virtual DbSet<question> question { get; set; }
        public virtual DbSet<reclamation> reclamation { get; set; }
        public virtual DbSet<salaire> salaire { get; set; }
        public virtual DbSet<skills> skills { get; set; }
        public virtual DbSet<stagiaire> stagiaire { get; set; }
        public virtual DbSet<suivi> suivi { get; set; }
        public virtual DbSet<suivi_risk> suivi_risk { get; set; }
        public virtual DbSet<suivitest> suivitest { get; set; }
        public virtual DbSet<suivitestemployee> suivitestemployee { get; set; }
        public virtual DbSet<test> test { get; set; }
        public virtual DbSet<user> user { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<analyseur>()
                .Property(e => e.DTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<analyseur>()
                .Property(e => e.libel)
                .IsUnicode(false);

            modelBuilder.Entity<analyseur>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<analyseur>()
                .HasMany(e => e.langage_naturel)
                .WithRequired(e => e.analyseur)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<analyseur>()
                .HasMany(e => e.curriculumvitae)
                .WithMany(e => e.analyseur)
                .Map(m => m.ToTable("workon", "neo3").MapLeftKey("AnalyseurID").MapRightKey("CV_ID"));

            modelBuilder.Entity<attestaion_de_travail>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<attestaion_de_travail>()
                .Property(e => e.objectif)
                .IsUnicode(false);

            modelBuilder.Entity<attestaion_de_travail>()
                .Property(e => e.titre)
                .IsUnicode(false);

            modelBuilder.Entity<attestaion_de_travail>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<attestaion_de_travail>()
                .Property(e => e.CIN)
                .IsUnicode(false);

            modelBuilder.Entity<attestation_de_stage>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<attestation_de_stage>()
                .Property(e => e.objectif)
                .IsUnicode(false);

            modelBuilder.Entity<attestation_de_stage>()
                .Property(e => e.titre)
                .IsUnicode(false);

            modelBuilder.Entity<attestation_de_stage>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<attestation_de_stage>()
                .Property(e => e.CIN)
                .IsUnicode(false);

            modelBuilder.Entity<autorisation_conge>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<autorisation_conge>()
                .Property(e => e.objectif)
                .IsUnicode(false);

            modelBuilder.Entity<autorisation_conge>()
                .Property(e => e.titre)
                .IsUnicode(false);

            modelBuilder.Entity<autorisation_conge>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<autorisation_conge>()
                .Property(e => e.CIN)
                .IsUnicode(false);

            modelBuilder.Entity<candidat>()
                .Property(e => e.CIN)
                .IsUnicode(false);

            modelBuilder.Entity<candidat>()
                .Property(e => e.adresse)
                .IsUnicode(false);

            modelBuilder.Entity<candidat>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<candidat>()
                .Property(e => e.image)
                .IsUnicode(false);

            modelBuilder.Entity<candidat>()
                .Property(e => e.linkedin)
                .IsUnicode(false);

            modelBuilder.Entity<candidat>()
                .Property(e => e.Nom)
                .IsUnicode(false);

            modelBuilder.Entity<candidat>()
                .Property(e => e.numTel)
                .IsUnicode(false);

            modelBuilder.Entity<candidat>()
                .Property(e => e.Per_email)
                .IsUnicode(false);

            modelBuilder.Entity<candidat>()
                .Property(e => e.Prenom)
                .IsUnicode(false);

            modelBuilder.Entity<candidat>()
                .Property(e => e.resume)
                .IsUnicode(false);

            modelBuilder.Entity<candidat>()
                .HasMany(e => e.user)
                .WithOptional(e => e.candidat)
                .HasForeignKey(e => e.CAN_CIN);

            modelBuilder.Entity<candidat>()
                .HasMany(e => e.curriculumvitae)
                .WithOptional(e => e.candidat)
                .HasForeignKey(e => e.candidat_CIN);

            modelBuilder.Entity<candidat>()
                .HasMany(e => e.cursus)
                .WithRequired(e => e.candidat)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<candidat>()
                .HasMany(e => e.suivitest)
                .WithRequired(e => e.candidat)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<candidat>()
                .HasMany(e => e.skills)
                .WithRequired(e => e.candidat)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<candidat>()
                .HasMany(e => e.carriere)
                .WithRequired(e => e.candidat)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<carriere>()
                .Property(e => e.CIN)
                .IsUnicode(false);

            modelBuilder.Entity<carriere>()
                .Property(e => e.niveau)
                .IsUnicode(false);

            modelBuilder.Entity<carriere>()
                .Property(e => e.societe)
                .IsUnicode(false);

            modelBuilder.Entity<categorytest>()
                .Property(e => e.Libelle)
                .IsUnicode(false);

            modelBuilder.Entity<competence>()
                .Property(e => e.tag)
                .IsUnicode(false);

            modelBuilder.Entity<competence>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<conge>()
                .Property(e => e.etat)
                .IsUnicode(false);

            modelBuilder.Entity<conge>()
                .Property(e => e.motifs)
                .IsUnicode(false);

            modelBuilder.Entity<conge>()
                .Property(e => e.raison)
                .IsUnicode(false);

            modelBuilder.Entity<conge>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<conge>()
                .Property(e => e.CIN)
                .IsUnicode(false);

            modelBuilder.Entity<contrat>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<contrat>()
                .Property(e => e.idEmploye)
                .IsUnicode(false);

            modelBuilder.Entity<contrat>()
                .HasMany(e => e.employe)
                .WithOptional(e => e.contrat)
                .HasForeignKey(e => e.IdContraEmploye);

            modelBuilder.Entity<critere>()
                .Property(e => e.idcritere)
                .IsUnicode(false);

            modelBuilder.Entity<critere>()
                .Property(e => e.fait)
                .IsUnicode(false);

            modelBuilder.Entity<critere>()
                .Property(e => e.risque)
                .IsUnicode(false);

            modelBuilder.Entity<critere>()
                .HasMany(e => e.suivi_risk)
                .WithRequired(e => e.critere)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<curriculumvitae>()
                .Property(e => e.blocCompetence)
                .IsUnicode(false);

            modelBuilder.Entity<curriculumvitae>()
                .Property(e => e.blocDiplome)
                .IsUnicode(false);

            modelBuilder.Entity<curriculumvitae>()
                .Property(e => e.blocExperience)
                .IsUnicode(false);

            modelBuilder.Entity<curriculumvitae>()
                .Property(e => e.blocInfosPersonnel)
                .IsUnicode(false);

            modelBuilder.Entity<curriculumvitae>()
                .Property(e => e.contenu)
                .IsUnicode(false);

            modelBuilder.Entity<curriculumvitae>()
                .Property(e => e.path)
                .IsUnicode(false);

            modelBuilder.Entity<curriculumvitae>()
                .Property(e => e.candidat_CIN)
                .IsUnicode(false);

            modelBuilder.Entity<cursus>()
                .Property(e => e.CIN)
                .IsUnicode(false);

            modelBuilder.Entity<cursus>()
                .Property(e => e.Mention)
                .IsUnicode(false);

            modelBuilder.Entity<departement>()
                .Property(e => e.libelleDEp)
                .IsUnicode(false);

            modelBuilder.Entity<diplome>()
                .Property(e => e.nom)
                .IsUnicode(false);

            modelBuilder.Entity<diplome>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<diplome>()
                .Property(e => e.CIN)
                .IsUnicode(false);

            modelBuilder.Entity<ecole>()
                .Property(e => e.Nom)
                .IsUnicode(false);

            modelBuilder.Entity<ecole>()
                .Property(e => e.pays)
                .IsUnicode(false);

            modelBuilder.Entity<employe>()
                .Property(e => e.CIN)
                .IsUnicode(false);

            modelBuilder.Entity<employe>()
                .Property(e => e.adresse)
                .IsUnicode(false);

            modelBuilder.Entity<employe>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<employe>()
                .Property(e => e.image)
                .IsUnicode(false);

            modelBuilder.Entity<employe>()
                .Property(e => e.Nom)
                .IsUnicode(false);

            modelBuilder.Entity<employe>()
                .Property(e => e.numTel)
                .IsUnicode(false);

            modelBuilder.Entity<employe>()
                .Property(e => e.Per_email)
                .IsUnicode(false);

            modelBuilder.Entity<employe>()
                .Property(e => e.Prenom)
                .IsUnicode(false);

            modelBuilder.Entity<employe>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<employe>()
                .Property(e => e.employeCIN1)
                .IsUnicode(false);

            modelBuilder.Entity<employe>()
                .Property(e => e.employeCIN2)
                .IsUnicode(false);

            modelBuilder.Entity<employe>()
                .Property(e => e.CIN_Man)
                .IsUnicode(false);

            modelBuilder.Entity<employe>()
                .HasMany(e => e.attestation_de_stage)
                .WithRequired(e => e.employe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<employe>()
                .HasMany(e => e.conge)
                .WithRequired(e => e.employe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<employe>()
                .HasMany(e => e.contrat1)
                .WithOptional(e => e.employe1)
                .HasForeignKey(e => e.idEmploye);

            modelBuilder.Entity<employe>()
                .HasMany(e => e.evenement)
                .WithRequired(e => e.employe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<employe>()
                .HasMany(e => e.suivi_risk)
                .WithRequired(e => e.employe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<employe>()
                .HasMany(e => e.user)
                .WithOptional(e => e.employe)
                .HasForeignKey(e => e.Emp_CIN);

            modelBuilder.Entity<employe>()
                .HasMany(e => e.reclamation)
                .WithOptional(e => e.employe)
                .HasForeignKey(e => e.Emp_CIN);

            modelBuilder.Entity<employe>()
                .HasMany(e => e.suivitestemployee)
                .WithRequired(e => e.employe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<employe>()
                .HasMany(e => e.employe1)
                .WithOptional(e => e.employe2)
                .HasForeignKey(e => e.employeCIN1);

            modelBuilder.Entity<employe>()
                .HasMany(e => e.equipe1)
                .WithOptional(e => e.employe1)
                .HasForeignKey(e => e.CIN);

            modelBuilder.Entity<employe>()
                .HasMany(e => e.reclamation1)
                .WithOptional(e => e.employe1)
                .HasForeignKey(e => e.CIN);

            modelBuilder.Entity<employe>()
                .HasMany(e => e.employe11)
                .WithOptional(e => e.employe3)
                .HasForeignKey(e => e.employeCIN2);

            modelBuilder.Entity<equipe>()
                .Property(e => e.labelEquipe)
                .IsUnicode(false);

            modelBuilder.Entity<equipe>()
                .Property(e => e.CIN)
                .IsUnicode(false);

            modelBuilder.Entity<equipe>()
                .HasMany(e => e.employe)
                .WithOptional(e => e.equipe)
                .HasForeignKey(e => e.idEquipe);

            modelBuilder.Entity<equipe>()
                .HasMany(e => e.suivi_risk)
                .WithRequired(e => e.equipe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<evenement>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<evenement>()
                .Property(e => e.libelle)
                .IsUnicode(false);

            modelBuilder.Entity<evenement>()
                .Property(e => e.lieu)
                .IsUnicode(false);

            modelBuilder.Entity<evenement>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<evenement>()
                .Property(e => e.CIN)
                .IsUnicode(false);

            modelBuilder.Entity<experience>()
                .Property(e => e.Nom)
                .IsUnicode(false);

            modelBuilder.Entity<experience>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<fichierpst>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<fichierpst>()
                .Property(e => e.path)
                .IsUnicode(false);

            modelBuilder.Entity<fichierpst>()
                .HasMany(e => e.candidat)
                .WithMany(e => e.fichierpst)
                .Map(m => m.ToTable("fichierpst_candidat").MapLeftKey("FichierPST_id").MapRightKey("candidats_CIN"));

            modelBuilder.Entity<formateur>()
                .Property(e => e.nom)
                .IsUnicode(false);

            modelBuilder.Entity<formateur>()
                .Property(e => e.prenom)
                .IsUnicode(false);

            modelBuilder.Entity<formateur>()
                .HasMany(e => e.formation)
                .WithRequired(e => e.formateur)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<formation>()
                .Property(e => e.DateDebut)
                .IsUnicode(false);

            modelBuilder.Entity<formation>()
                .Property(e => e.libelle)
                .IsUnicode(false);

            modelBuilder.Entity<formation>()
                .Property(e => e.lieux)
                .IsUnicode(false);

            modelBuilder.Entity<formation>()
                .Property(e => e.Responsable)
                .IsUnicode(false);

            modelBuilder.Entity<formation>()
                .Property(e => e.CIN)
                .IsUnicode(false);

            modelBuilder.Entity<grade>()
                .Property(e => e.libelleGrade)
                .IsUnicode(false);

            modelBuilder.Entity<langage_naturel>()
                .Property(e => e.DTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<langage_naturel>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<langage_naturel>()
                .HasMany(e => e.mot)
                .WithRequired(e => e.langage_naturel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<manager_france>()
                .Property(e => e.CIN)
                .IsUnicode(false);

            modelBuilder.Entity<manager_france>()
                .Property(e => e.adresse)
                .IsUnicode(false);

            modelBuilder.Entity<manager_france>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<manager_france>()
                .Property(e => e.Nom)
                .IsUnicode(false);

            modelBuilder.Entity<manager_france>()
                .Property(e => e.numTel)
                .IsUnicode(false);

            modelBuilder.Entity<manager_france>()
                .Property(e => e.Per_email)
                .IsUnicode(false);

            modelBuilder.Entity<manager_france>()
                .Property(e => e.Prenom)
                .IsUnicode(false);

            modelBuilder.Entity<manager_france>()
                .HasMany(e => e.employe)
                .WithOptional(e => e.manager_france)
                .HasForeignKey(e => e.CIN_Man);

            modelBuilder.Entity<metier>()
                .Property(e => e.libelleMetier)
                .IsUnicode(false);

            modelBuilder.Entity<mot>()
                .Property(e => e.DTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<mot>()
                .Property(e => e.label)
                .IsUnicode(false);

            modelBuilder.Entity<mot>()
                .Property(e => e.pattern)
                .IsUnicode(false);

            modelBuilder.Entity<note>()
                .Property(e => e.CIN)
                .IsUnicode(false);

            modelBuilder.Entity<produit>()
                .Property(e => e.nom)
                .IsUnicode(false);

            modelBuilder.Entity<produit>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<produit>()
                .HasMany(e => e.equipe)
                .WithRequired(e => e.produit)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<question>()
                .Property(e => e.choixA)
                .IsUnicode(false);

            modelBuilder.Entity<question>()
                .Property(e => e.choixB)
                .IsUnicode(false);

            modelBuilder.Entity<question>()
                .Property(e => e.choixC)
                .IsUnicode(false);

            modelBuilder.Entity<question>()
                .Property(e => e.contenue)
                .IsUnicode(false);

            modelBuilder.Entity<question>()
                .Property(e => e.image)
                .IsUnicode(false);

            modelBuilder.Entity<question>()
                .Property(e => e.reponse)
                .IsUnicode(false);

            modelBuilder.Entity<question>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<reclamation>()
                .Property(e => e.commentaire)
                .IsUnicode(false);

            modelBuilder.Entity<reclamation>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<reclamation>()
                .Property(e => e.etat)
                .IsUnicode(false);

            modelBuilder.Entity<reclamation>()
                .Property(e => e.motifs)
                .IsUnicode(false);

            modelBuilder.Entity<reclamation>()
                .Property(e => e.CIN)
                .IsUnicode(false);

            modelBuilder.Entity<reclamation>()
                .Property(e => e.Emp_CIN)
                .IsUnicode(false);

            modelBuilder.Entity<skills>()
                .Property(e => e.CIN)
                .IsUnicode(false);

            modelBuilder.Entity<skills>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<skills>()
                .Property(e => e.niveau)
                .IsUnicode(false);

            modelBuilder.Entity<skills>()
                .Property(e => e.Verifier)
                .IsUnicode(false);

            modelBuilder.Entity<stagiaire>()
                .Property(e => e.nom)
                .IsUnicode(false);

            modelBuilder.Entity<stagiaire>()
                .Property(e => e.prenom)
                .IsUnicode(false);

            modelBuilder.Entity<stagiaire>()
                .Property(e => e.sexe)
                .IsUnicode(false);

            modelBuilder.Entity<stagiaire>()
                .HasMany(e => e.produit1)
                .WithMany(e => e.stagiaire)
                .Map(m => m.ToTable("produit_stagiaire").MapLeftKey("stagiaires_id"));

            modelBuilder.Entity<suivi>()
                .Property(e => e.EntretrienTCarriere)
                .IsUnicode(false);

            modelBuilder.Entity<suivi>()
                .Property(e => e.Eval)
                .IsUnicode(false);

            modelBuilder.Entity<suivi>()
                .Property(e => e.CIN)
                .IsUnicode(false);

            modelBuilder.Entity<suivi_risk>()
                .Property(e => e.idcritere)
                .IsUnicode(false);

            modelBuilder.Entity<suivi_risk>()
                .Property(e => e.CIN)
                .IsUnicode(false);

            modelBuilder.Entity<suivitest>()
                .Property(e => e.CIN)
                .IsUnicode(false);

            modelBuilder.Entity<suivitestemployee>()
                .Property(e => e.CIN)
                .IsUnicode(false);

            modelBuilder.Entity<test>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<test>()
                .Property(e => e.nom)
                .IsUnicode(false);

            modelBuilder.Entity<test>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.email_canonical)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.Role)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.username_canonical)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.CAN_CIN)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.Emp_CIN)
                .IsUnicode(false);
        }
    }
}
