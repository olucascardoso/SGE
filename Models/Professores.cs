﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGE.Models
{
    [Table("Professores")]
    public class Professores
    {
        [Column("Id")]
        [Display(Name = "Id do Professor.")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome do Professor.")]
        public string Nome { get; set; } = string.Empty;

        [Column("Email")]
        [Display(Name = "E-mail do Professor.")]
        public string Email { get; set; } = string.Empty;

        [Column("Telefone")]
        [Display(Name = "Telefone do Professor.")]
        public string Telefone { get; set; } = string.Empty;

        [Column("Cpf")]
        [Display(Name = "CPF do Professor.")]
        public string Cpf { get; set; } = string.Empty;

        [Column("DataNascimento")]
        [Display(Name = "Aniversario do Professor.")]
        public string DataNascimento { get; set; } = string.Empty;
    }
}
