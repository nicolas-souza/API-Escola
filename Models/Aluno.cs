using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Aluno
    {
        [Required]
        public int Id { get; set; }
        
        [Required]
        public String nome { get; set; }

        [Required]
        public String email { get; set; }

        [Required]
        public Endereco endereco {get; set;}

        [Required]
        public int ano { get; set; }

        [Required]
        public String turno { get; set; }

        [Required]
        public DateTime nascimento { get; set; }


    }
}