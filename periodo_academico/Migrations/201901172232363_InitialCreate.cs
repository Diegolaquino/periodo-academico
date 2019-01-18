namespace periodo_academico.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alunos",
                c => new
                    {
                        AlunoId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Media = c.Single(nullable: false),
                        TurmaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AlunoId)
                .ForeignKey("dbo.Turmas", t => t.TurmaId, cascadeDelete: false)
                .Index(t => t.TurmaId);
            
            CreateTable(
                "dbo.Turmas",
                c => new
                    {
                        TurmaId = c.Int(nullable: false, identity: true),
                        Nome = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TurmaId);
            
            CreateTable(
                "dbo.Provas",
                c => new
                    {
                        ProvaId = c.Int(nullable: false, identity: true),
                        NumeroOrdinal = c.Int(nullable: false),
                        AlunoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProvaId)
                .ForeignKey("dbo.Alunos", t => t.AlunoId, cascadeDelete: true)
                .Index(t => t.AlunoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Provas", "AlunoId", "dbo.Alunos");
            DropForeignKey("dbo.Alunos", "TurmaId", "dbo.Turmas");
            DropIndex("dbo.Provas", new[] { "AlunoId" });
            DropIndex("dbo.Alunos", new[] { "TurmaId" });
            DropTable("dbo.Provas");
            DropTable("dbo.Turmas");
            DropTable("dbo.Alunos");
        }
    }
}
