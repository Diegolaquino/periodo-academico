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
        public int NumeroOrdinal { get; set; }
        public int AlunoId { get; set; }
        public float Nota { get; set; }
        public virtual Aluno Aluno { get; set; }

    }
}