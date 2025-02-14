using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGE.Models
{
    [Table("Notas")]
    public class Notas
    {
        [Column("Id")]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [ForeignKey("MateriasId")]
        [Display(Name = "Id das Materias.")]
        public int MateriasId { get; set; }
        public Materias? Materias { get; set; }

        [ForeignKey("AlunosId")]
        [Display(Name = "Id dos Alunos.")]
        public int AlunosId { get; set; }
        public Alunos? Alunos { get; set; }

        [ForeignKey("EtapasId")]
        [Display(Name = "Id das Etapas.")]
        public int EtapasId { get; set; }
        public Etapas? Etapas { get; set; }

        [Column("Nota")]
        [Display(Name = "Nota")]
        public double Nota { get; set; }
    }
}
