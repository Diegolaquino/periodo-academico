namespace periodo_academico.Migrations
{
    using periodo_academico.Models;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "periodo_academico.Models.ApplicationDbContext";
        }

        protected override void Seed(ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Turmas.AddOrUpdate(t => t.Nome,
                new Turma { TurmaId = 1, Nome = "Turma 1" },
                new Turma { TurmaId = 2, Nome = "Turma 2" },
                new Turma { TurmaId = 3, Nome = "Turma 3"}
                );

            context.Alunos.AddOrUpdate(a => a.Nome,
                //Turma 1
                new Aluno { AlunoId = 1, Nome = "Alice", TurmaId = 1, Media = 0 },
                new Aluno { AlunoId = 2, Nome = "Sophia", TurmaId = 1, Media = 0 },
                new Aluno { AlunoId = 3, Nome = "Helena", TurmaId = 1, Media = 0 },
                new Aluno { AlunoId = 4, Nome = "Valentina", TurmaId = 1, Media = 0 },
                new Aluno { AlunoId = 5, Nome = "Laura", TurmaId = 1, Media = 0 },
                new Aluno { AlunoId = 6, Nome = "Isabella", TurmaId = 1, Media = 0 },
                new Aluno { AlunoId = 7, Nome = "Manuela", TurmaId = 1, Media = 0 },
                new Aluno { AlunoId = 8, Nome = "J�lia", TurmaId = 1, Media = 0 },
                new Aluno { AlunoId = 9, Nome = "Helo�sa", TurmaId = 1, Media = 0 },
                new Aluno { AlunoId = 10, Nome = "Luiza", TurmaId = 1, Media = 0 },
                new Aluno { AlunoId = 11, Nome = "Enzo", TurmaId = 1, Media = 0 },
                new Aluno { AlunoId = 12, Nome = "Miguel", TurmaId = 1, Media = 0 },
                new Aluno { AlunoId = 13, Nome = "Arthur", TurmaId = 1, Media = 0 },
                new Aluno { AlunoId = 14, Nome = "Bernardo", TurmaId = 1, Media = 0 },
                new Aluno { AlunoId = 15, Nome = "Heitor", TurmaId = 1, Media = 0 },
                new Aluno { AlunoId = 16, Nome = "Davi", TurmaId = 1, Media = 0 },
                new Aluno { AlunoId = 17, Nome = "Lorenzo", TurmaId = 1, Media = 0 },
                new Aluno { AlunoId = 18, Nome = "Th�o", TurmaId = 1, Media = 0 },
                new Aluno { AlunoId = 19, Nome = "Pedro", TurmaId = 1, Media = 0 },
                new Aluno { AlunoId = 20, Nome = "Gabriel", TurmaId = 1, Media = 0 },

                //Turma 2
                new Aluno { AlunoId = 21, Nome = "Lorena", TurmaId = 2, Media = 0 },
                new Aluno { AlunoId = 22, Nome = "Lucas", TurmaId = 2, Media = 0 },
                new Aluno { AlunoId = 23, Nome = "L�via", TurmaId = 2, Media = 0 },
                new Aluno { AlunoId = 24, Nome = "Benjamin", TurmaId = 2, Media = 0 },
                new Aluno { AlunoId = 25, Nome = "Giovanna", TurmaId = 2, Media = 0 },
                new Aluno { AlunoId = 26, Nome = "Pietro", TurmaId = 2, Media = 0 },
                new Aluno { AlunoId = 27, Nome = "Maria Eduarda", TurmaId = 2, Media = 0 },
                new Aluno { AlunoId = 28, Nome = "Guilherme", TurmaId = 2, Media = 0 },
                new Aluno { AlunoId = 29, Nome = "Beatriz", TurmaId = 2, Media = 0 },
                new Aluno { AlunoId = 30, Nome = "Rafael", TurmaId = 2, Media = 0 },
                new Aluno { AlunoId = 31, Nome = "Maria Clara", TurmaId = 2, Media = 0 },
                new Aluno { AlunoId = 32, Nome = "Joaquim", TurmaId = 2, Media = 0 },
                new Aluno { AlunoId = 33, Nome = "Cec�lia", TurmaId = 2, Media = 0 },
                new Aluno { AlunoId = 34, Nome = "Elo�", TurmaId = 2, Media = 0 },
                new Aluno { AlunoId = 35, Nome = "Enzo Gabriel", TurmaId = 2, Media = 0 },
                new Aluno { AlunoId = 36, Nome = "Lara", TurmaId = 2, Media = 0 },
                new Aluno { AlunoId = 37, Nome = "Jo�o Miguel", TurmaId = 2, Media = 0 },
                new Aluno { AlunoId = 38, Nome = "Maria J�lia", TurmaId = 2, Media = 0 },
                new Aluno { AlunoId = 39, Nome = "Henrique", TurmaId = 2, Media = 0 },
                new Aluno { AlunoId = 40, Nome = "Isadora", TurmaId = 2, Media = 0 },

                //Turma 3
                new Aluno { AlunoId = 41, Nome = "Mariana", TurmaId = 3, Media = 0 },
                new Aluno { AlunoId = 42, Nome = "Murilo", TurmaId = 3, Media = 0 },
                new Aluno { AlunoId = 43, Nome = "Emanuelly", TurmaId = 3, Media = 0 },
                new Aluno { AlunoId = 44, Nome = "Pedro Henrique", TurmaId = 3, Media = 0 },
                new Aluno { AlunoId = 45, Nome = "Ana J�lia", TurmaId = 3, Media = 0 },
                new Aluno { AlunoId = 46, Nome = "Lucca", TurmaId = 3, Media = 0 },
                new Aluno { AlunoId = 47, Nome = "Ana Luiza", TurmaId = 3, Media = 0 },
                new Aluno { AlunoId = 48, Nome = "Felipe", TurmaId = 3, Media = 0 },
                new Aluno { AlunoId = 49, Nome = "Melissa", TurmaId = 3, Media = 0 },
                new Aluno { AlunoId = 50, Nome = "Jo�o Pedro", TurmaId = 3, Media = 0 },
                new Aluno { AlunoId = 51, Nome = "Yasmin", TurmaId = 3, Media = 0 },
                new Aluno { AlunoId = 52, Nome = "Isaac", TurmaId = 3, Media = 0 },
                new Aluno { AlunoId = 53, Nome = "Maria Alice", TurmaId = 3, Media = 0 },
                new Aluno { AlunoId = 54, Nome = "Ben�cio", TurmaId = 3, Media = 0 },
                new Aluno { AlunoId = 55, Nome = "Isabelly", TurmaId = 3, Media = 0 },
                new Aluno { AlunoId = 56, Nome = "Anthony", TurmaId = 3, Media = 0 },
                new Aluno { AlunoId = 57, Nome = "Lav�nia", TurmaId = 3, Media = 0 },
                new Aluno { AlunoId = 58, Nome = "Leonardo", TurmaId = 3, Media = 0 },
                new Aluno { AlunoId = 59, Nome = "Esther", TurmaId = 3, Media = 0 },
                new Aluno { AlunoId = 60, Nome = "Davi Lucca", TurmaId = 3, Media = 0 }
                );

            context.SaveChanges();
        }
    }
}
