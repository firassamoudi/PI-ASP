namespace NeoXam.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class formateurupdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.formateur", "address", c => c.String(unicode: false));
            AddColumn("dbo.formateur", "numTel", c => c.String(unicode: false));
            AddColumn("dbo.formateur", "email", c => c.String(unicode: false));
            AddColumn("dbo.formateur", "facebook", c => c.String(unicode: false));
            AddColumn("dbo.formateur", "linkedin", c => c.String(unicode: false));
            AddColumn("dbo.formateur", "Description", c => c.String(unicode: false));
            AddColumn("dbo.formateur", "photo", c => c.String(unicode: false));
            AlterColumn("dbo.formateur", "nom", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.formateur", "prenom", c => c.String(nullable: false, maxLength: 50, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.formateur", "prenom", c => c.String(nullable: false, maxLength: 250, unicode: false));
            AlterColumn("dbo.formateur", "nom", c => c.String(nullable: false, maxLength: 250, unicode: false));
            DropColumn("dbo.formateur", "photo");
            DropColumn("dbo.formateur", "Description");
            DropColumn("dbo.formateur", "linkedin");
            DropColumn("dbo.formateur", "facebook");
            DropColumn("dbo.formateur", "email");
            DropColumn("dbo.formateur", "numTel");
            DropColumn("dbo.formateur", "address");
        }
    }
}
