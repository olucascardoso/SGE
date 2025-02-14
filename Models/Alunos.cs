using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGE.Models
{
    [Table("Alunos")]
    public class Alunos
    {
        [Column("Id")]
        [Display(Name = "Id do Aluno.")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome do Aluno.")]
        public string Nome { get; set; } = string.Empty;

        [Column("CPF")]
        [Display(Name = "CPF do Aluno.")]
        public string CPF { get; set; } = string.Empty;

        [Column("Email")]
        [Display(Name = "E-mail do Aluno.")]
        public string Email { get; set; } = string.Empty;

        [Column("Telefone")]
        [Display(Name = "Telefone do Aluno.")]
        public string Telefone { get; set; } = string.Empty;

        [Column("DataNascimento")]
        [Display(Name = "Aniversario do Aluno.")]
        public string DataNascimento { get; set; } = string.Empty;
    }
}
