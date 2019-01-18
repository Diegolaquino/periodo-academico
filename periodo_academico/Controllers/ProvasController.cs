using periodo_academico.Models;
using periodo_academico.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using System.Web;
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
                    context.Provas.Add(new Prova { AlunoId = a.AlunoId, NumeroOrdinal = (int)ProvasDoPeriodo.Primeira, Nota = numeroAleatorio.Next(1, 100)/10 });
                    context.Provas.Add(new Prova { AlunoId = a.AlunoId, NumeroOrdinal = (int)ProvasDoPeriodo.Segunda, Nota = numeroAleatorio.Next(1, 100) / 10 });
                    context.Provas.Add(new Prova { AlunoId = a.AlunoId, NumeroOrdinal = (int)ProvasDoPeriodo.Terceira, Nota = numeroAleatorio.Next(1, 100) / 10 });
                }

                context.SaveChanges();

                t.Complete();
            }

            return View("Index");
        }
    }
}
