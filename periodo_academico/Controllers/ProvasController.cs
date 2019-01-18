using periodo_academico.Models;
using System;
using System.Linq;
using System.Transactions;
using System.Web.Mvc;

namespace periodo_academico.Controllers
{
    public class ProvasController : Controller
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        // GET: Provas
        public ActionResult Index()
        {
            var provas = context.Provas;
            return View(provas.ToList());
        }

        public ActionResult GerarProvas()
        {
            using (TransactionScope t = new TransactionScope())
            {
                var alunos = context.Alunos;
                Random numeroAleatorio = new Random();
                foreach (Aluno a in alunos)
                {
                    context.Provas.Add(new Prova { AlunoId = a.AlunoId, Nota_1 = numeroAleatorio.Next(0, 10), Nota_2 = numeroAleatorio.Next(0, 10), Nota_3 = numeroAleatorio.Next(0, 10) });
                }

                context.SaveChanges();

                t.Complete();
            }

            return RedirectToAction("Index");
        }

        public ActionResult DeletarTudo()
        {
            context.Database.ExecuteSqlCommand("TRUNCATE TABLE [Provas]");
            return RedirectToAction("Index");
        }

        //public async Task GerandoMediaAluno()
        //{
            


        //}
    }
}
