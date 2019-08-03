using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoWebMVC.Models
{
    public class CandidatoVaga
    {
        [Key]
        public int IdCandidato { get; set; }
        [Key]
        public int IdVaga { get; set; }
    }
}
