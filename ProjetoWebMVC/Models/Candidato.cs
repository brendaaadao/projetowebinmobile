using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoWebMVC.Models
{
    public class Candidato
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public double Telefone { get; set; }
        public double PretSalarial { get; set; }
    }
}
