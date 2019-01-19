using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Net;
using System.Transactions;
using System.Web;
using System.Web.Mvc;
using periodo_academico.Models;

namespace periodo_academico.Controllers
{
    public class AlunosController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Alunos
        public ActionResult Index()
        {
            var alunoes = db.Alunos.Include(a => a.Turma);
            return View(alunoes.ToList());
        }


        public ActionResult GerarAlunos()
        {
            using (TransactionScope t = new TransactionScope())
            {
                db.Turmas.AddOrUpdate(tu => tu.Nome,
                new Turma { TurmaId = 1, Nome = "Turma 1" },
                new Turma { TurmaId = 2, Nome = "Turma 2" },
                new Turma { TurmaId = 3, Nome = "Turma 3" }
                );

                db.Alunos.AddOrUpdate(a => a.Nome,
                    //Turma 1
                    new Aluno { AlunoId = 1, Nome = "Alice", TurmaId = 1},
                    new Aluno { AlunoId = 2, Nome = "Sophia", TurmaId = 1},
                    new Aluno { AlunoId = 3, Nome = "Helena", TurmaId = 1 },
                    new Aluno { AlunoId = 4, Nome = "Valentina", TurmaId = 1 },
                    new Aluno { AlunoId = 5, Nome = "Laura", TurmaId = 1 },
                    new Aluno { AlunoId = 6, Nome = "Isabella", TurmaId = 1 },
                    new Aluno { AlunoId = 7, Nome = "Manuela", TurmaId = 1 },
                    new Aluno { AlunoId = 8, Nome = "Júlia", TurmaId = 1 },
                    new Aluno { AlunoId = 9, Nome = "Heloísa", TurmaId = 1 },
                    new Aluno { AlunoId = 10, Nome = "Luiza", TurmaId = 1 },
                    new Aluno { AlunoId = 11, Nome = "Enzo", TurmaId = 1 },
                    new Aluno { AlunoId = 12, Nome = "Miguel", TurmaId = 1 },
                    new Aluno { AlunoId = 13, Nome = "Arthur", TurmaId = 1 },
                    new Aluno { AlunoId = 14, Nome = "Bernardo", TurmaId = 1 },
                    new Aluno { AlunoId = 15, Nome = "Heitor", TurmaId = 1 },
                    new Aluno { AlunoId = 16, Nome = "Davi", TurmaId = 1 },
                    new Aluno { AlunoId = 17, Nome = "Lorenzo", TurmaId = 1 },
                    new Aluno { AlunoId = 18, Nome = "Théo", TurmaId = 1 },
                    new Aluno { AlunoId = 19, Nome = "Pedro", TurmaId = 1 },
                    new Aluno { AlunoId = 20, Nome = "Gabriel", TurmaId = 1 },

                    //Turma 2
                    new Aluno { AlunoId = 21, Nome = "Lorena", TurmaId = 2 },
                    new Aluno { AlunoId = 22, Nome = "Lucas", TurmaId = 2 },
                    new Aluno { AlunoId = 23, Nome = "Lívia", TurmaId = 2 },
                    new Aluno { AlunoId = 24, Nome = "Benjamin", TurmaId = 2 },
                    new Aluno { AlunoId = 25, Nome = "Giovanna", TurmaId = 2 },
                    new Aluno { AlunoId = 26, Nome = "Pietro", TurmaId = 2 },
                    new Aluno { AlunoId = 27, Nome = "Maria Eduarda", TurmaId = 2 },
                    new Aluno { AlunoId = 28, Nome = "Guilherme", TurmaId = 2 },
                    new Aluno { AlunoId = 29, Nome = "Beatriz", TurmaId = 2 },
                    new Aluno { AlunoId = 30, Nome = "Rafael", TurmaId = 2 },
                    new Aluno { AlunoId = 31, Nome = "Maria Clara", TurmaId = 2 },
                    new Aluno { AlunoId = 32, Nome = "Joaquim", TurmaId = 2 },
                    new Aluno { AlunoId = 33, Nome = "Cecília", TurmaId = 2 },
                    new Aluno { AlunoId = 34, Nome = "Eloá", TurmaId = 2 },
                    new Aluno { AlunoId = 35, Nome = "Enzo Gabriel", TurmaId = 2 },
                    new Aluno { AlunoId = 36, Nome = "Lara", TurmaId = 2 },
                    new Aluno { AlunoId = 37, Nome = "João Miguel", TurmaId = 2 },
                    new Aluno { AlunoId = 38, Nome = "Maria Júlia", TurmaId = 2 },
                    new Aluno { AlunoId = 39, Nome = "Henrique", TurmaId = 2 },
                    new Aluno { AlunoId = 40, Nome = "Isadora", TurmaId = 2 },

                    //Turma 3
                    new Aluno { AlunoId = 41, Nome = "Mariana", TurmaId = 3 },
                    new Aluno { AlunoId = 42, Nome = "Murilo", TurmaId = 3 },
                    new Aluno { AlunoId = 43, Nome = "Emanuelly", TurmaId = 3 },
                    new Aluno { AlunoId = 44, Nome = "Pedro Henrique", TurmaId = 3 },
                    new Aluno { AlunoId = 45, Nome = "Ana Júlia", TurmaId = 3 },
                    new Aluno { AlunoId = 46, Nome = "Lucca", TurmaId = 3 },
                    new Aluno { AlunoId = 47, Nome = "Ana Luiza", TurmaId = 3 },
                    new Aluno { AlunoId = 48, Nome = "Felipe", TurmaId = 3 },
                    new Aluno { AlunoId = 49, Nome = "Melissa", TurmaId = 3},
                    new Aluno { AlunoId = 50, Nome = "João Pedro", TurmaId = 3 },
                    new Aluno { AlunoId = 51, Nome = "Yasmin", TurmaId = 3 },
                    new Aluno { AlunoId = 52, Nome = "Isaac", TurmaId = 3 },
                    new Aluno { AlunoId = 53, Nome = "Maria Alice", TurmaId = 3 },
                    new Aluno { AlunoId = 54, Nome = "Benício", TurmaId = 3 },
                    new Aluno { AlunoId = 55, Nome = "Isabelly", TurmaId = 3 },
                    new Aluno { AlunoId = 56, Nome = "Anthony", TurmaId = 3 },
                    new Aluno { AlunoId = 57, Nome = "Lavínia", TurmaId = 3 },
                    new Aluno { AlunoId = 58, Nome = "Leonardo", TurmaId = 3 },
                    new Aluno { AlunoId = 59, Nome = "Esther", TurmaId = 3 },
                    new Aluno { AlunoId = 60, Nome = "Davi Lucca", TurmaId = 3 }
                    );

                db.SaveChanges();

                t.Complete();
            }

            return RedirectToAction("Index");
        }

        public ActionResult DeletarTudo()
        {
            db.Database.ExecuteSqlCommand("DELETE FROM [Provas]");
            db.Database.ExecuteSqlCommand("DELETE FROM [Alunos]");

            return RedirectToAction("Index");
        }

    }
}
