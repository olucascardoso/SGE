using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGE.Models
{
    [Table("Materias")]
    public class Materias
    {
        [Column("Id")]
        [Display(Name = "Id das Materias.")]
        public int Id { get; set; }

        [Column("Titulo")]
        [Display(Name = "Titulo das materias.")]
        public string Titulo { get; set; } = string.Empty;

        [ForeignKey("ProfessoresId")]
        [Display(Name = "Id do Professor.")]
        public int ProfessoresId { get; set; }
        public Professores? Professores { get; set; }
    }
}
