using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace periodo_academico.Models
{
    [Table("Finalistas")]
    public class Finalista
    {
        public int FinalistaId { get; set; }

        public string Nome { get; set; }

        [Display(Name = "Nota de Classificação")]
        public double NotaDeClassificacao { get; set; }

        public double? Nota { get; set; }

        [Display(Name = "Média Final")]
        public double? MediaFinal { get; set; }

        public int AlunoId { get; set; }
        public virtual Aluno Aluno { get; set; }
    }
}