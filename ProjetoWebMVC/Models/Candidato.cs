using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoWebMVC.Models
{
    public class Candidato
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "É necessário que {0} possua entre {2} e {1} caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        [EmailAddress(ErrorMessage = "Insira um e-mail válido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        public double Telefone { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        public double PretSalarial { get; set; }
    }
}
