namespace NeoXam.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DebutMig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.analyseur",
                c => new
                    {
                        idAnalyseur = c.Int(nullable: false, identity: true),
                        DTYPE = c.String(nullable: false, maxLength: 31, unicode: false),
                        libel = c.String(maxLength: 254, unicode: false),
                        type = c.String(maxLength: 254, unicode: false),
                    })
                .PrimaryKey(t => t.idAnalyseur);
            
            CreateTable(
                "dbo.curriculumvitae",
                c => new
                    {
                        idCV = c.Int(nullable: false, identity: true),
                        blocCompetence = c.String(maxLength: 254, unicode: false),
                        blocDiplome = c.String(maxLength: 254, unicode: false),
                        blocExperience = c.String(maxLength: 254, unicode: false),
                        blocInfosPersonnel = c.String(maxLength: 254, unicode: false),
                        contenu = c.String(maxLength: 254, unicode: false),
                        path = c.String(maxLength: 254, unicode: false),
                        candidat_CIN = c.String(maxLength: 255, unicode: false),
                    })
                .PrimaryKey(t => t.idCV)
                .ForeignKey("dbo.candidat", t => t.candidat_CIN)
                .Index(t => t.candidat_CIN);
            
            CreateTable(
                "dbo.candidat",
                c => new
                    {
                        CIN = c.String(nullable: false, maxLength: 255, unicode: false),
                        adresse = c.String(maxLength: 254, unicode: false),
                        Email = c.String(maxLength: 254, unicode: false),
                        image = c.String(maxLength: 254, unicode: false),
                        linkedin = c.String(maxLength: 254, unicode: false),
                        Nom = c.String(maxLength: 254, unicode: false),
                        numTel = c.String(maxLength: 254, unicode: false),
                        Per_email = c.String(maxLength: 254, unicode: false),
                        Prenom = c.String(maxLength: 254, unicode: false),
                        resume = c.String(maxLength: 254, unicode: false),
                    })
                .PrimaryKey(t => t.CIN);
            
            CreateTable(
                "dbo.carriere",
                c => new
                    {
                        CIN = c.String(nullable: false, maxLength: 255, unicode: false),
                        idExpe = c.Int(nullable: false),
                        DateDep = c.DateTime(precision: 0),
                        DateFin = c.DateTime(precision: 0),
                        niveau = c.String(maxLength: 254, unicode: false),
                        societe = c.String(maxLength: 254, unicode: false),
                    })
                .PrimaryKey(t => new { t.CIN, t.idExpe })
                .ForeignKey("dbo.candidat", t => t.CIN)
                .Index(t => t.CIN);
            
            CreateTable(
                "dbo.cursus",
                c => new
                    {
                        CIN = c.String(nullable: false, maxLength: 255, unicode: false),
                        diplomeId = c.Int(nullable: false),
                        anneeDeb = c.DateTime(precision: 0),
                        anneeFin = c.DateTime(precision: 0),
                        Mention = c.String(maxLength: 254, unicode: false),
                    })
                .PrimaryKey(t => new { t.CIN, t.diplomeId })
                .ForeignKey("dbo.candidat", t => t.CIN)
                .Index(t => t.CIN);
            
            CreateTable(
                "dbo.fichierpst",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        DateCreation = c.DateTime(precision: 0),
                        name = c.String(maxLength: 255, unicode: false),
                        path = c.String(maxLength: 255, unicode: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.skills",
                c => new
                    {
                        CIN = c.String(nullable: false, maxLength: 255, unicode: false),
                        idCompetence = c.Int(nullable: false),
                        description = c.String(maxLength: 254, unicode: false),
                        niveau = c.String(maxLength: 254, unicode: false),
                        Verifier = c.String(maxLength: 254, unicode: false),
                    })
                .PrimaryKey(t => new { t.CIN, t.idCompetence })
                .ForeignKey("dbo.candidat", t => t.CIN)
                .Index(t => t.CIN);
            
            CreateTable(
                "dbo.suivitest",
                c => new
                    {
                        CIN = c.String(nullable: false, maxLength: 255, unicode: false),
                        idTest = c.Int(nullable: false),
                        Date = c.DateTime(precision: 0),
                        Resultat = c.Int(),
                        temps = c.DateTime(precision: 0),
                    })
                .PrimaryKey(t => new { t.CIN, t.idTest })
                .ForeignKey("dbo.candidat", t => t.CIN)
                .Index(t => t.CIN);
            
            CreateTable(
                "dbo.user",
                c => new
                    {
                        idU = c.Int(nullable: false, identity: true),
                        actif = c.Boolean(nullable: false, storeType: "bit"),
                        email = c.String(maxLength: 255, unicode: false),
                        email_canonical = c.String(maxLength: 254, unicode: false),
                        enabled = c.Int(),
                        lastLogin = c.DateTime(precision: 0),
                        password = c.String(maxLength: 254, unicode: false),
                        Role = c.String(maxLength: 254, unicode: false),
                        username = c.String(maxLength: 254, unicode: false),
                        username_canonical = c.String(maxLength: 254, unicode: false),
                        CAN_CIN = c.String(maxLength: 255, unicode: false),
                        Emp_CIN = c.String(maxLength: 255, unicode: false),
                    })
                .PrimaryKey(t => t.idU)
                .ForeignKey("dbo.employe", t => t.Emp_CIN)
                .ForeignKey("dbo.candidat", t => t.CAN_CIN)
                .Index(t => t.CAN_CIN)
                .Index(t => t.Emp_CIN);
            
            CreateTable(
                "dbo.employe",
                c => new
                    {
                        CIN = c.String(nullable: false, maxLength: 255, unicode: false),
                        adresse = c.String(maxLength: 254, unicode: false),
                        Email = c.String(maxLength: 254, unicode: false),
                        haveC = c.Int(nullable: false),
                        image = c.String(maxLength: 254, unicode: false),
                        joinDate = c.DateTime(precision: 0),
                        lastDay = c.DateTime(precision: 0),
                        nbJours = c.Int(),
                        Nom = c.String(maxLength: 254, unicode: false),
                        numTel = c.String(maxLength: 254, unicode: false),
                        Per_email = c.String(maxLength: 254, unicode: false),
                        Prenom = c.String(maxLength: 254, unicode: false),
                        rib = c.Int(),
                        type = c.String(maxLength: 254, unicode: false),
                        IdContraEmploye = c.Int(),
                        idDep = c.Int(),
                        employeCIN1 = c.String(maxLength: 255, unicode: false),
                        employeCIN2 = c.String(maxLength: 255, unicode: false),
                        idEquipe = c.Int(),
                        idGrade = c.Int(),
                        CIN_Man = c.String(maxLength: 255, unicode: false),
                        idMetier = c.Int(),
                    })
                .PrimaryKey(t => t.CIN)
                .ForeignKey("dbo.contrat", t => t.IdContraEmploye)
                .ForeignKey("dbo.equipe", t => t.idEquipe)
                .ForeignKey("dbo.departement", t => t.idDep)
                .ForeignKey("dbo.employe", t => t.employeCIN1)
                .ForeignKey("dbo.employe", t => t.employeCIN2)
                .ForeignKey("dbo.grade", t => t.idGrade)
                .ForeignKey("dbo.manager_france", t => t.CIN_Man)
                .ForeignKey("dbo.metier", t => t.idMetier)
                .Index(t => t.IdContraEmploye)
                .Index(t => t.idDep)
                .Index(t => t.employeCIN1)
                .Index(t => t.employeCIN2)
                .Index(t => t.idEquipe)
                .Index(t => t.idGrade)
                .Index(t => t.CIN_Man)
                .Index(t => t.idMetier);
            
            CreateTable(
                "dbo.attestaion_de_travail",
                c => new
                    {
                        idDoc = c.Int(nullable: false, identity: true),
                        DateCreation = c.DateTime(precision: 0),
                        Description = c.String(maxLength: 254, unicode: false),
                        objectif = c.String(maxLength: 254, unicode: false),
                        titre = c.String(maxLength: 254, unicode: false),
                        Type = c.String(maxLength: 254, unicode: false),
                        CIN = c.String(maxLength: 255, unicode: false),
                    })
                .PrimaryKey(t => t.idDoc)
                .ForeignKey("dbo.employe", t => t.CIN)
                .Index(t => t.CIN);
            
            CreateTable(
                "dbo.attestation_de_stage",
                c => new
                    {
                        idDoc = c.Int(nullable: false, identity: true),
                        DateCreation = c.DateTime(precision: 0),
                        Description = c.String(maxLength: 254, unicode: false),
                        objectif = c.String(maxLength: 254, unicode: false),
                        titre = c.String(maxLength: 254, unicode: false),
                        Type = c.String(maxLength: 254, unicode: false),
                        CIN = c.String(maxLength: 255, unicode: false),
                    })
                .PrimaryKey(t => t.idDoc)
                .ForeignKey("dbo.employe", t => t.CIN)
                .Index(t => t.CIN);
            
            CreateTable(
                "dbo.autorisation_conge",
                c => new
                    {
                        idDoc = c.Int(nullable: false, identity: true),
                        DateCreation = c.DateTime(precision: 0),
                        Description = c.String(maxLength: 254, unicode: false),
                        objectif = c.String(maxLength: 254, unicode: false),
                        titre = c.String(maxLength: 254, unicode: false),
                        Type = c.String(maxLength: 254, unicode: false),
                        CIN = c.String(maxLength: 255, unicode: false),
                    })
                .PrimaryKey(t => t.idDoc)
                .ForeignKey("dbo.employe", t => t.CIN)
                .Index(t => t.CIN);
            
            CreateTable(
                "dbo.conge",
                c => new
                    {
                        idConge = c.Int(nullable: false, identity: true),
                        dateDebut = c.DateTime(precision: 0),
                        dateFin = c.DateTime(precision: 0),
                        etat = c.String(maxLength: 254, unicode: false),
                        motifs = c.String(maxLength: 254, unicode: false),
                        raison = c.String(maxLength: 254, unicode: false),
                        type = c.String(maxLength: 254, unicode: false),
                        CIN = c.String(nullable: false, maxLength: 255, unicode: false),
                    })
                .PrimaryKey(t => t.idConge)
                .ForeignKey("dbo.employe", t => t.CIN)
                .Index(t => t.CIN);
            
            CreateTable(
                "dbo.contrat",
                c => new
                    {
                        idContrat = c.Int(nullable: false, identity: true),
                        DateDep = c.DateTime(precision: 0),
                        DateFin = c.DateTime(precision: 0),
                        Type = c.String(maxLength: 254, unicode: false),
                        idEmploye = c.String(maxLength: 255, unicode: false),
                        idSalaire = c.Int(),
                    })
                .PrimaryKey(t => t.idContrat)
                .ForeignKey("dbo.salaire", t => t.idSalaire)
                .ForeignKey("dbo.employe", t => t.idEmploye)
                .Index(t => t.idEmploye)
                .Index(t => t.idSalaire);
            
            CreateTable(
                "dbo.salaire",
                c => new
                    {
                        idSalaire = c.Int(nullable: false, identity: true),
                        Bonus = c.Int(),
                        DateCreation = c.DateTime(precision: 0),
                        moisEtAnne = c.DateTime(precision: 0),
                        salaireBrut = c.Int(),
                        salaireNet = c.Int(),
                    })
                .PrimaryKey(t => t.idSalaire);
            
            CreateTable(
                "dbo.stagiaire",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        age = c.Int(nullable: false),
                        nom = c.String(maxLength: 255, unicode: false),
                        prenom = c.String(maxLength: 255, unicode: false),
                        sexe = c.String(maxLength: 255, unicode: false),
                        contract_idContrat = c.Int(),
                        idPro = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.produit", t => t.idPro)
                .ForeignKey("dbo.contrat", t => t.contract_idContrat)
                .Index(t => t.contract_idContrat)
                .Index(t => t.idPro);
            
            CreateTable(
                "dbo.produit",
                c => new
                    {
                        idPro = c.Int(nullable: false, identity: true),
                        datedeDebut = c.DateTime(precision: 0),
                        datefin = c.DateTime(precision: 0),
                        nom = c.String(maxLength: 254, unicode: false),
                        type = c.String(maxLength: 254, unicode: false),
                    })
                .PrimaryKey(t => t.idPro);
            
            CreateTable(
                "dbo.equipe",
                c => new
                    {
                        idEquipe = c.Int(nullable: false, identity: true),
                        labelEquipe = c.String(maxLength: 254, unicode: false),
                        CIN = c.String(maxLength: 255, unicode: false),
                        idPro = c.Int(),
                    })
                .PrimaryKey(t => t.idEquipe)
                .ForeignKey("dbo.produit", t => t.idPro)
                .ForeignKey("dbo.employe", t => t.CIN)
                .Index(t => t.CIN)
                .Index(t => t.idPro);
            
            CreateTable(
                "dbo.suivi_risk",
                c => new
                    {
                        idSuiviRisk = c.Int(nullable: false, identity: true),
                        Date_Suivi = c.DateTime(precision: 0),
                        Valeur = c.Int(),
                        idcritere = c.String(maxLength: 254, unicode: false),
                        CIN = c.String(maxLength: 255, unicode: false),
                        idEquipe = c.Int(),
                    })
                .PrimaryKey(t => t.idSuiviRisk)
                .ForeignKey("dbo.critere", t => t.idcritere)
                .ForeignKey("dbo.employe", t => t.CIN)
                .ForeignKey("dbo.equipe", t => t.idEquipe)
                .Index(t => t.idcritere)
                .Index(t => t.CIN)
                .Index(t => t.idEquipe);
            
            CreateTable(
                "dbo.critere",
                c => new
                    {
                        idcritere = c.String(nullable: false, maxLength: 254, unicode: false),
                        fait = c.String(maxLength: 254, unicode: false),
                        risque = c.String(maxLength: 254, unicode: false),
                    })
                .PrimaryKey(t => t.idcritere);
            
            CreateTable(
                "dbo.departement",
                c => new
                    {
                        idDep = c.Int(nullable: false, identity: true),
                        libelleDEp = c.String(maxLength: 254, unicode: false),
                    })
                .PrimaryKey(t => t.idDep);
            
            CreateTable(
                "dbo.diplome",
                c => new
                    {
                        diplomeId = c.Int(nullable: false, identity: true),
                        nom = c.String(maxLength: 254, unicode: false),
                        type = c.String(maxLength: 254, unicode: false),
                        idEcole = c.Int(),
                        CIN = c.String(maxLength: 255, unicode: false),
                    })
                .PrimaryKey(t => t.diplomeId)
                .ForeignKey("dbo.ecole", t => t.idEcole)
                .ForeignKey("dbo.employe", t => t.CIN)
                .Index(t => t.idEcole)
                .Index(t => t.CIN);
            
            CreateTable(
                "dbo.ecole",
                c => new
                    {
                        idEcole = c.Int(nullable: false, identity: true),
                        Nom = c.String(maxLength: 254, unicode: false),
                        pays = c.String(maxLength: 254, unicode: false),
                    })
                .PrimaryKey(t => t.idEcole);
            
            CreateTable(
                "dbo.evenement",
                c => new
                    {
                        idEvent = c.Int(nullable: false, identity: true),
                        Description = c.String(maxLength: 254, unicode: false),
                        libelle = c.String(maxLength: 254, unicode: false),
                        lieu = c.String(maxLength: 254, unicode: false),
                        Type = c.String(maxLength: 254, unicode: false),
                        CIN = c.String(nullable: false, maxLength: 255, unicode: false),
                    })
                .PrimaryKey(t => t.idEvent)
                .ForeignKey("dbo.employe", t => t.CIN)
                .Index(t => t.CIN);
            
            CreateTable(
                "dbo.formation",
                c => new
                    {
                        idFormation = c.Int(nullable: false, identity: true),
                        DateDebut = c.String(maxLength: 254, unicode: false),
                        libelle = c.String(maxLength: 254, unicode: false),
                        lieux = c.String(maxLength: 254, unicode: false),
                        Responsable = c.String(maxLength: 254, unicode: false),
                        CIN = c.String(maxLength: 255, unicode: false),
                        formateurid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idFormation)
                .ForeignKey("dbo.employe", t => t.CIN)
                .ForeignKey("dbo.formateur", t => t.formateurid)
                .Index(t => t.CIN)
                .Index(t => t.formateurid);
            
            CreateTable(
                "dbo.formateur",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nom = c.String(nullable: false, maxLength: 250, unicode: false),
                        prenom = c.String(nullable: false, maxLength: 250, unicode: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.grade",
                c => new
                    {
                        idGrade = c.Int(nullable: false, identity: true),
                        libelleGrade = c.String(maxLength: 254, unicode: false),
                    })
                .PrimaryKey(t => t.idGrade);
            
            CreateTable(
                "dbo.manager_france",
                c => new
                    {
                        CIN = c.String(nullable: false, maxLength: 255, unicode: false),
                        adresse = c.String(maxLength: 254, unicode: false),
                        Email = c.String(maxLength: 254, unicode: false),
                        Nom = c.String(maxLength: 254, unicode: false),
                        numTel = c.String(maxLength: 254, unicode: false),
                        Per_email = c.String(maxLength: 254, unicode: false),
                        Prenom = c.String(maxLength: 254, unicode: false),
                    })
                .PrimaryKey(t => t.CIN);
            
            CreateTable(
                "dbo.metier",
                c => new
                    {
                        idMetier = c.Int(nullable: false, identity: true),
                        libelleMetier = c.String(maxLength: 254, unicode: false),
                    })
                .PrimaryKey(t => t.idMetier);
            
            CreateTable(
                "dbo.note",
                c => new
                    {
                        idNote = c.Int(nullable: false, identity: true),
                        note = c.Int(),
                        CIN = c.String(maxLength: 255, unicode: false),
                    })
                .PrimaryKey(t => t.idNote)
                .ForeignKey("dbo.employe", t => t.CIN)
                .Index(t => t.CIN);
            
            CreateTable(
                "dbo.reclamation",
                c => new
                    {
                        idReclamation = c.Int(nullable: false, identity: true),
                        commentaire = c.String(maxLength: 255, unicode: false),
                        dateCreation = c.DateTime(precision: 0),
                        DateTraitement = c.DateTime(precision: 0),
                        description = c.String(maxLength: 254, unicode: false),
                        etat = c.String(maxLength: 255, unicode: false),
                        motifs = c.String(maxLength: 254, unicode: false),
                        CIN = c.String(maxLength: 255, unicode: false),
                        Emp_CIN = c.String(maxLength: 255, unicode: false),
                    })
                .PrimaryKey(t => t.idReclamation)
                .ForeignKey("dbo.employe", t => t.Emp_CIN)
                .ForeignKey("dbo.employe", t => t.CIN)
                .Index(t => t.CIN)
                .Index(t => t.Emp_CIN);
            
            CreateTable(
                "dbo.suivi",
                c => new
                    {
                        idSuiv = c.Int(nullable: false, identity: true),
                        DateSuivi = c.DateTime(precision: 0),
                        EntretrienTCarriere = c.String(maxLength: 254, unicode: false),
                        Eval = c.String(maxLength: 254, unicode: false),
                        CIN = c.String(maxLength: 255, unicode: false),
                    })
                .PrimaryKey(t => t.idSuiv)
                .ForeignKey("dbo.employe", t => t.CIN)
                .Index(t => t.CIN);
            
            CreateTable(
                "dbo.suivitestemployee",
                c => new
                    {
                        CIN = c.String(nullable: false, maxLength: 255, unicode: false),
                        idTest = c.Int(nullable: false),
                        Date = c.DateTime(precision: 0),
                        Resultat = c.Int(),
                        temps = c.DateTime(precision: 0),
                    })
                .PrimaryKey(t => new { t.CIN, t.idTest })
                .ForeignKey("dbo.employe", t => t.CIN)
                .Index(t => t.CIN);
            
            CreateTable(
                "dbo.langage_naturel",
                c => new
                    {
                        idLang = c.Int(nullable: false, identity: true),
                        DTYPE = c.String(nullable: false, maxLength: 31, unicode: false),
                        type = c.String(maxLength: 254, unicode: false),
                        idAnalyseur = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idLang)
                .ForeignKey("dbo.analyseur", t => t.idAnalyseur)
                .Index(t => t.idAnalyseur);
            
            CreateTable(
                "dbo.mot",
                c => new
                    {
                        idMot = c.Int(nullable: false, identity: true),
                        DTYPE = c.String(nullable: false, maxLength: 31, unicode: false),
                        label = c.String(maxLength: 254, unicode: false),
                        pattern = c.String(maxLength: 254, unicode: false),
                        idLang = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idMot)
                .ForeignKey("dbo.langage_naturel", t => t.idLang)
                .Index(t => t.idLang);
            
            CreateTable(
                "dbo.categorytest",
                c => new
                    {
                        idCatego = c.Int(nullable: false, identity: true),
                        Libelle = c.String(maxLength: 254, unicode: false),
                    })
                .PrimaryKey(t => t.idCatego);
            
            CreateTable(
                "dbo.test",
                c => new
                    {
                        idTest = c.Int(nullable: false, identity: true),
                        DateExpiration = c.DateTime(precision: 0),
                        description = c.String(maxLength: 254, unicode: false),
                        nom = c.String(maxLength: 254, unicode: false),
                        type = c.String(maxLength: 254, unicode: false),
                        idCatego = c.Int(),
                    })
                .PrimaryKey(t => t.idTest)
                .ForeignKey("dbo.categorytest", t => t.idCatego)
                .Index(t => t.idCatego);
            
            CreateTable(
                "dbo.question",
                c => new
                    {
                        idQuestion = c.Int(nullable: false, identity: true),
                        choixA = c.String(maxLength: 254, unicode: false),
                        choixB = c.String(maxLength: 254, unicode: false),
                        choixC = c.String(maxLength: 254, unicode: false),
                        contenue = c.String(maxLength: 254, unicode: false),
                        image = c.String(maxLength: 254, unicode: false),
                        reponse = c.String(maxLength: 254, unicode: false),
                        type = c.String(maxLength: 254, unicode: false),
                        idTest = c.Int(),
                    })
                .PrimaryKey(t => t.idQuestion)
                .ForeignKey("dbo.test", t => t.idTest)
                .Index(t => t.idTest);
            
            CreateTable(
                "dbo.competence",
                c => new
                    {
                        idCompetence = c.Int(nullable: false, identity: true),
                        tag = c.String(maxLength: 254, unicode: false),
                        type = c.String(maxLength: 254, unicode: false),
                    })
                .PrimaryKey(t => t.idCompetence);
            
            CreateTable(
                "dbo.experience",
                c => new
                    {
                        idExpe = c.Int(nullable: false, identity: true),
                        Nom = c.String(maxLength: 254, unicode: false),
                        Type = c.String(maxLength: 255, unicode: false),
                    })
                .PrimaryKey(t => t.idExpe);
            
            CreateTable(
                "dbo.fichierpst_candidat",
                c => new
                    {
                        FichierPST_id = c.Int(nullable: false),
                        candidats_CIN = c.String(nullable: false, maxLength: 255, unicode: false),
                    })
                .PrimaryKey(t => new { t.FichierPST_id, t.candidats_CIN })
                .ForeignKey("dbo.fichierpst", t => t.FichierPST_id, cascadeDelete: true)
                .ForeignKey("dbo.candidat", t => t.candidats_CIN, cascadeDelete: true)
                .Index(t => t.FichierPST_id)
                .Index(t => t.candidats_CIN);
            
            CreateTable(
                "dbo.produit_stagiaire",
                c => new
                    {
                        stagiaires_id = c.Int(nullable: false),
                        produit_idPro = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.stagiaires_id, t.produit_idPro })
                .ForeignKey("dbo.stagiaire", t => t.stagiaires_id, cascadeDelete: true)
                .ForeignKey("dbo.produit", t => t.produit_idPro, cascadeDelete: true)
                .Index(t => t.stagiaires_id)
                .Index(t => t.produit_idPro);
            
            CreateTable(
                "neo3.workon",
                c => new
                    {
                        AnalyseurID = c.Int(nullable: false),
                        CV_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.AnalyseurID, t.CV_ID })
                .ForeignKey("dbo.analyseur", t => t.AnalyseurID, cascadeDelete: true)
                .ForeignKey("dbo.curriculumvitae", t => t.CV_ID, cascadeDelete: true)
                .Index(t => t.AnalyseurID)
                .Index(t => t.CV_ID);
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                {
                    Id = c.String(nullable: false, maxLength: 128),
                    Name = c.String(nullable: false, maxLength: 256),
                })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");

            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                {
                    UserId = c.String(nullable: false, maxLength: 128),
                    RoleId = c.String(nullable: false, maxLength: 128),
                })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);

            CreateTable(
                "dbo.AspNetUsers",
                c => new
                {
                    Id = c.String(nullable: false, maxLength: 128),
                    Email = c.String(maxLength: 256),
                    EmailConfirmed = c.Boolean(nullable: false),
                    PasswordHash = c.String(),
                    SecurityStamp = c.String(),
                    PhoneNumber = c.String(),
                    PhoneNumberConfirmed = c.Boolean(nullable: false),
                    TwoFactorEnabled = c.Boolean(nullable: false),
                    LockoutEndDateUtc = c.DateTime(),
                    LockoutEnabled = c.Boolean(nullable: false),
                    AccessFailedCount = c.Int(nullable: false),
                    UserName = c.String(nullable: false, maxLength: 256),
                    LastName = c.String(nullable: false, maxLength: 256),
                    CAN_CIN = c.String(maxLength: 255, unicode: false),
                    Emp_CIN = c.String(maxLength: 255, unicode: false),

                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.employe", t => t.Emp_CIN)
                .ForeignKey("dbo.candidat", t => t.CAN_CIN)
                .Index(t => t.CAN_CIN)
                .Index(t => t.Emp_CIN)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");

            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    UserId = c.String(nullable: false, maxLength: 128),
                    ClaimType = c.String(),
                    ClaimValue = c.String(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);

            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                {
                    LoginProvider = c.String(nullable: false, maxLength: 128),
                    ProviderKey = c.String(nullable: false, maxLength: 128),
                    UserId = c.String(nullable: false, maxLength: 128),
                })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);


        
    }
        
        public override void Down()
        {
            DropForeignKey("dbo.question", "idTest", "dbo.test");
            DropForeignKey("dbo.test", "idCatego", "dbo.categorytest");
            DropForeignKey("dbo.langage_naturel", "idAnalyseur", "dbo.analyseur");
            DropForeignKey("dbo.mot", "idLang", "dbo.langage_naturel");
            DropForeignKey("neo3.workon", "CV_ID", "dbo.curriculumvitae");
            DropForeignKey("neo3.workon", "AnalyseurID", "dbo.analyseur");
            DropForeignKey("dbo.user", "CAN_CIN", "dbo.candidat");
            DropForeignKey("dbo.user", "Emp_CIN", "dbo.employe");
            DropForeignKey("dbo.suivitestemployee", "CIN", "dbo.employe");
            DropForeignKey("dbo.suivi", "CIN", "dbo.employe");
            DropForeignKey("dbo.reclamation", "CIN", "dbo.employe");
            DropForeignKey("dbo.reclamation", "Emp_CIN", "dbo.employe");
            DropForeignKey("dbo.note", "CIN", "dbo.employe");
            DropForeignKey("dbo.employe", "idMetier", "dbo.metier");
            DropForeignKey("dbo.employe", "CIN_Man", "dbo.manager_france");
            DropForeignKey("dbo.employe", "idGrade", "dbo.grade");
            DropForeignKey("dbo.formation", "formateurid", "dbo.formateur");
            DropForeignKey("dbo.formation", "CIN", "dbo.employe");
            DropForeignKey("dbo.evenement", "CIN", "dbo.employe");
            DropForeignKey("dbo.equipe", "CIN", "dbo.employe");
            DropForeignKey("dbo.employe", "employeCIN2", "dbo.employe");
            DropForeignKey("dbo.employe", "employeCIN1", "dbo.employe");
            DropForeignKey("dbo.diplome", "CIN", "dbo.employe");
            DropForeignKey("dbo.diplome", "idEcole", "dbo.ecole");
            DropForeignKey("dbo.employe", "idDep", "dbo.departement");
            DropForeignKey("dbo.contrat", "idEmploye", "dbo.employe");
            DropForeignKey("dbo.stagiaire", "contract_idContrat", "dbo.contrat");
            DropForeignKey("dbo.produit_stagiaire", "produit_idPro", "dbo.produit");
            DropForeignKey("dbo.produit_stagiaire", "stagiaires_id", "dbo.stagiaire");
            DropForeignKey("dbo.stagiaire", "idPro", "dbo.produit");
            DropForeignKey("dbo.suivi_risk", "idEquipe", "dbo.equipe");
            DropForeignKey("dbo.suivi_risk", "CIN", "dbo.employe");
            DropForeignKey("dbo.suivi_risk", "idcritere", "dbo.critere");
            DropForeignKey("dbo.equipe", "idPro", "dbo.produit");
            DropForeignKey("dbo.employe", "idEquipe", "dbo.equipe");
            DropForeignKey("dbo.contrat", "idSalaire", "dbo.salaire");
            DropForeignKey("dbo.employe", "IdContraEmploye", "dbo.contrat");
            DropForeignKey("dbo.conge", "CIN", "dbo.employe");
            DropForeignKey("dbo.autorisation_conge", "CIN", "dbo.employe");
            DropForeignKey("dbo.attestation_de_stage", "CIN", "dbo.employe");
            DropForeignKey("dbo.attestaion_de_travail", "CIN", "dbo.employe");
            DropForeignKey("dbo.suivitest", "CIN", "dbo.candidat");
            DropForeignKey("dbo.skills", "CIN", "dbo.candidat");
            DropForeignKey("dbo.fichierpst_candidat", "candidats_CIN", "dbo.candidat");
            DropForeignKey("dbo.fichierpst_candidat", "FichierPST_id", "dbo.fichierpst");
            DropForeignKey("dbo.cursus", "CIN", "dbo.candidat");
            DropForeignKey("dbo.curriculumvitae", "candidat_CIN", "dbo.candidat");
            DropForeignKey("dbo.carriere", "CIN", "dbo.candidat");
            DropIndex("neo3.workon", new[] { "CV_ID" });
            DropIndex("neo3.workon", new[] { "AnalyseurID" });
            DropIndex("dbo.produit_stagiaire", new[] { "produit_idPro" });
            DropIndex("dbo.produit_stagiaire", new[] { "stagiaires_id" });
            DropIndex("dbo.fichierpst_candidat", new[] { "candidats_CIN" });
            DropIndex("dbo.fichierpst_candidat", new[] { "FichierPST_id" });
            DropIndex("dbo.question", new[] { "idTest" });
            DropIndex("dbo.test", new[] { "idCatego" });
            DropIndex("dbo.mot", new[] { "idLang" });
            DropIndex("dbo.langage_naturel", new[] { "idAnalyseur" });
            DropIndex("dbo.suivitestemployee", new[] { "CIN" });
            DropIndex("dbo.suivi", new[] { "CIN" });
            DropIndex("dbo.reclamation", new[] { "Emp_CIN" });
            DropIndex("dbo.reclamation", new[] { "CIN" });
            DropIndex("dbo.note", new[] { "CIN" });
            DropIndex("dbo.formation", new[] { "formateurid" });
            DropIndex("dbo.formation", new[] { "CIN" });
            DropIndex("dbo.evenement", new[] { "CIN" });
            DropIndex("dbo.diplome", new[] { "CIN" });
            DropIndex("dbo.diplome", new[] { "idEcole" });
            DropIndex("dbo.suivi_risk", new[] { "idEquipe" });
            DropIndex("dbo.suivi_risk", new[] { "CIN" });
            DropIndex("dbo.suivi_risk", new[] { "idcritere" });
            DropIndex("dbo.equipe", new[] { "idPro" });
            DropIndex("dbo.equipe", new[] { "CIN" });
            DropIndex("dbo.stagiaire", new[] { "idPro" });
            DropIndex("dbo.stagiaire", new[] { "contract_idContrat" });
            DropIndex("dbo.contrat", new[] { "idSalaire" });
            DropIndex("dbo.contrat", new[] { "idEmploye" });
            DropIndex("dbo.conge", new[] { "CIN" });
            DropIndex("dbo.autorisation_conge", new[] { "CIN" });
            DropIndex("dbo.attestation_de_stage", new[] { "CIN" });
            DropIndex("dbo.attestaion_de_travail", new[] { "CIN" });
            DropIndex("dbo.employe", new[] { "idMetier" });
            DropIndex("dbo.employe", new[] { "CIN_Man" });
            DropIndex("dbo.employe", new[] { "idGrade" });
            DropIndex("dbo.employe", new[] { "idEquipe" });
            DropIndex("dbo.employe", new[] { "employeCIN2" });
            DropIndex("dbo.employe", new[] { "employeCIN1" });
            DropIndex("dbo.employe", new[] { "idDep" });
            DropIndex("dbo.employe", new[] { "IdContraEmploye" });
            DropIndex("dbo.user", new[] { "Emp_CIN" });
            DropIndex("dbo.user", new[] { "CAN_CIN" });
            DropIndex("dbo.suivitest", new[] { "CIN" });
            DropIndex("dbo.skills", new[] { "CIN" });
            DropIndex("dbo.cursus", new[] { "CIN" });
            DropIndex("dbo.carriere", new[] { "CIN" });
            DropIndex("dbo.curriculumvitae", new[] { "candidat_CIN" });
            DropTable("neo3.workon");
            DropTable("dbo.produit_stagiaire");
            DropTable("dbo.fichierpst_candidat");
            DropTable("dbo.experience");
            DropTable("dbo.competence");
            DropTable("dbo.question");
            DropTable("dbo.test");
            DropTable("dbo.categorytest");
            DropTable("dbo.mot");
            DropTable("dbo.langage_naturel");
            DropTable("dbo.suivitestemployee");
            DropTable("dbo.suivi");
            DropTable("dbo.reclamation");
            DropTable("dbo.note");
            DropTable("dbo.metier");
            DropTable("dbo.manager_france");
            DropTable("dbo.grade");
            DropTable("dbo.formateur");
            DropTable("dbo.formation");
            DropTable("dbo.evenement");
            DropTable("dbo.ecole");
            DropTable("dbo.diplome");
            DropTable("dbo.departement");
            DropTable("dbo.critere");
            DropTable("dbo.suivi_risk");
            DropTable("dbo.equipe");
            DropTable("dbo.produit");
            DropTable("dbo.stagiaire");
            DropTable("dbo.salaire");
            DropTable("dbo.contrat");
            DropTable("dbo.conge");
            DropTable("dbo.autorisation_conge");
            DropTable("dbo.attestation_de_stage");
            DropTable("dbo.attestaion_de_travail");
            DropTable("dbo.employe");
            DropTable("dbo.user");
            DropTable("dbo.suivitest");
            DropTable("dbo.skills");
            DropTable("dbo.fichierpst");
            DropTable("dbo.cursus");
            DropTable("dbo.carriere");
            DropTable("dbo.candidat");
            DropTable("dbo.curriculumvitae");
            DropTable("dbo.analyseur");

            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");

            /*Remove added columns*/
            DropForeignKey("dbo.AspNetUsers", "CAN_CIN", "dbo.employe");
            DropIndex("dbo.AspNetUsers", new[] { "CAN_CIN" });
            DropColumn("dbo.AspNetUsers", "CAN_CIN");
            DropForeignKey("dbo.AspNetUsers", "Emp_CIN", "dbo.employe");
            DropIndex("dbo.AspNetUsers", new[] { "Emp_CIN" });
            DropColumn("dbo.AspNetUsers", "Emp_CIN");
            DropColumn("dbo.AspNetUsers", "LastName");
            /***/
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            
        }
    }
}
