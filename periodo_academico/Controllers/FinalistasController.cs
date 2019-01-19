using periodo_academico.Models;
using System.Web.Mvc;
using System.Linq;
using System;
using System.Transactions;
using System.Data.Entity;

namespace periodo_academico.Controllers
{
    public class FinalistasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Finalistas
        public ActionResult Index(int? ordenacao)
        {
            if(ordenacao == 1)
            {
                var finalistas = db.Finalistas;
                return View(finalistas.OrderByDescending(f => f.MediaFinal).ToList());
            }
            else
            {
                var finalistas = db.Finalistas;
                return View(finalistas.ToList());
            }
            
        }

       
        public ActionResult GerarFinalistas()
        {
            using (TransactionScope t = new TransactionScope())
            {
                Random r = new Random();
                var provas = db.Provas.OrderByDescending(p => p.Media).ToList();

                var finalistas = (from f in provas
                                  select new Finalista { Nome = f.Aluno.Nome, AlunoId = f.AlunoId, NotaDeClassificacao = (double)f.Media, Nota = r.Next(0, 10)}).Take(5);

                db.Finalistas.AddRange(finalistas);
                db.SaveChanges();

                t.Complete();
            }
                
            return RedirectToAction("Index");
        }

        public ActionResult GerarNotaFinal()
        {
            using (TransactionScope t = new TransactionScope())
            {
                var finalistas = db.Finalistas.ToList();

                foreach (Finalista f in finalistas)
                {
                    var p = db.Provas.Where(pr => pr.AlunoId == f.AlunoId).Single();
                    if (p.Nota_4 == null)
                    {
                        f.MediaFinal = ((p.Nota_1 + p.Nota_2 + p.Nota_3 + (f.Nota * 2)) / 5);
                        db.Entry(f).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                    else
                    {
                        f.MediaFinal = ((p.Nota_1 + p.Nota_2 + p.Nota_3 + p.Nota_4 + (f.Nota * 2)) / 6);
                        db.Entry(f).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                }
                t.Complete();
            }

            return RedirectToAction("Index", 1);
        }
    }
}
