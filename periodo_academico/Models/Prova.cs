using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace periodo_academico.Models
{
    public class Prova
    {
        [Key]
        public int ProvaId { get; set; }

        public int AlunoId { get; set; }

        [Display(Name = "Primeira Prova")]
        public float Nota_1 { get; set; }

        [Display(Name = "Segunda Prova")]
        public float Nota_2 { get; set; }

        [Display(Name = "Terceira Prova")]
        public float Nota_3 { get; set; }

        public virtual Aluno Aluno { get; set; }

    }
}