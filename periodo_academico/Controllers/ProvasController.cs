using periodo_academico.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Transactions;
using System.Web.Mvc;

namespace periodo_academico.Controllers
{
    public class ProvasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Provas
        public ActionResult Index()
        {
            var provas = db.Provas;
            return View(provas.ToList());
        }

        public ActionResult GerarProvas()
        {
            using (TransactionScope t = new TransactionScope())
            {
                var alunos = db.Alunos;
                Random numeroAleatorio = new Random();
                foreach (Aluno a in alunos)
                {
                    db.Provas.Add(new Prova { AlunoId = a.AlunoId, Nota_1 = numeroAleatorio.Next(0, 10), Nota_2 = numeroAleatorio.Next(0, 10), Nota_3 = numeroAleatorio.Next(0, 10) });
                }

                db.SaveChanges();

                t.Complete();
            }

            return RedirectToAction("Index");
        }

        public ActionResult DeletarTudo()
        {
            db.Database.ExecuteSqlCommand("DELETE FROM [Provas]");
            return RedirectToAction("Index");
        }

        public ActionResult GerarMedia()
        {
            using (TransactionScope t = new TransactionScope())
            {
                var provas = db.Provas.ToList();

                foreach (Prova p in provas)
                {
                    Aluno a = db.Alunos.Find(p.AlunoId);
                    // Os números dos pesos foram arredondados
                    a.Media = (((p.Nota_1 * 2.8) + (p.Nota_2 * 3.30) + (p.Nota_1 * 3.90)) / 10);
                    db.Entry(a).State = EntityState.Modified;
                }

                db.SaveChanges();
                t.Complete();
            }

            return RedirectToAction("Index", "Alunos", null);
        }
    }
}
