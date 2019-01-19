using periodo_academico.Models;
using System.Web.Mvc;
using System.Linq;
using System;

namespace periodo_academico.Controllers
{
    public class FinalistasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Finalistas
        public ActionResult Index()
        {
            var finalistas = db.Finalistas;
            return View(finalistas.ToList());
        }

       
        public ActionResult GerarFinalistas()
        {
            Random t = new Random();
            var notas = db.Provas.OrderByDescending(p => p.Media).ToList();
            var finalistas = (from f in notas
                             select new Finalista { Nome = f.Aluno.Nome, AlunoId = f.AlunoId, NotaDeClassificacao = (double)f.Media, Nota = t.Next(0, 10) }).OrderByDescending(f => f.NotaDeClassificacao).Take(5);

            db.Finalistas.AddRange(finalistas);
            db.SaveChanges();
           

            return RedirectToAction("Index");
        }
      
    }
}
