namespace Webservices.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departements",
                c => new
                    {
                        DepartementId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.DepartementId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        DepartementId = c.Int(),
                    })
                .PrimaryKey(t => t.EmployeeId)
                .ForeignKey("dbo.Departements", t => t.DepartementId)
                .Index(t => t.DepartementId);
            
            CreateTable(
                "dbo.Materiels",
                c => new
                    {
                        MaterielId = c.Int(nullable: false, identity: true),
                        libelle = c.String(),
                    })
                .PrimaryKey(t => t.MaterielId);
            
            CreateTable(
                "dbo.MaterielDepartements",
                c => new
                    {
                        Materiel_MaterielId = c.Int(nullable: false),
                        Departement_DepartementId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Materiel_MaterielId, t.Departement_DepartementId })
                .ForeignKey("dbo.Materiels", t => t.Materiel_MaterielId, cascadeDelete: true)
                .ForeignKey("dbo.Departements", t => t.Departement_DepartementId, cascadeDelete: true)
                .Index(t => t.Materiel_MaterielId)
                .Index(t => t.Departement_DepartementId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MaterielDepartements", "Departement_DepartementId", "dbo.Departements");
            DropForeignKey("dbo.MaterielDepartements", "Materiel_MaterielId", "dbo.Materiels");
            DropForeignKey("dbo.Employees", "DepartementId", "dbo.Departements");
            DropIndex("dbo.MaterielDepartements", new[] { "Departement_DepartementId" });
            DropIndex("dbo.MaterielDepartements", new[] { "Materiel_MaterielId" });
            DropIndex("dbo.Employees", new[] { "DepartementId" });
            DropTable("dbo.MaterielDepartements");
            DropTable("dbo.Materiels");
            DropTable("dbo.Employees");
            DropTable("dbo.Departements");
        }
    }
}
