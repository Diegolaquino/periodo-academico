using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace periodo_academico.Models
{
    [Table("Turmas")]
    public class Turma
    {
        [Key]
        [Display(Name = "Turma")]
        public int TurmaId { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Aluno> Alunos { get; set; }
    }
}