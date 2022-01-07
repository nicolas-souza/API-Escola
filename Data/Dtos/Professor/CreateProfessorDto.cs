using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using API.Models;

namespace API.Data.Dtos.Professor
{
    public class CreateProfessorDto
    {
        
        
        [Required]
        public String nome { get; set; }
        
        public String email { get; set; }

        [Required]
        public String disciplinaLecionada { get; set; }

        [Required]
        public DateTime nascimento { get; set; }

        [Required]
        public Endereco endereco {get; set;}
    }
}