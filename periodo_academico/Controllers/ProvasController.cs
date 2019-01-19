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
            var provas = db.Provas.OrderByDescending(p => p.Media);
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
                    db.Provas.Add(new Prova { AlunoId = a.AlunoId, Nota_1 = numeroAleatorio.Next(0, 10), Nota_2 = numeroAleatorio.Next(0, 10), Nota_3 = numeroAleatorio.Next(0, 10), Media = null });
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
                    // Os números dos pesos foram arredondados
                    p.Media = (((p.Nota_1 * 2.8) + (p.Nota_2 * 3.30) + (p.Nota_1 * 3.90)) / 10);
                    db.Entry(p).State = EntityState.Modified;
                }

                db.SaveChanges();
                t.Complete();
            }

            return RedirectToAction("Index");
        }

        public ActionResult GerarNotaFinal()
        {
            using (TransactionScope t = new TransactionScope())
            {
                var provas = db.Provas.Where(p => p.Media <= 6 && (p.Media >= 4));
                Random aleatorio = new Random();

                foreach (Prova p in provas)
                {
                    p.Nota_4 = aleatorio.Next(0, 10);
                    p.Media = (p.Media + p.Nota_4) / 2;
                    db.Entry(p).State = EntityState.Modified;

                    db.SaveChanges();
                }
               
                t.Complete();
            }

            return RedirectToAction("Index");
        }
    }
}
