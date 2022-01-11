using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using API.Data.Dtos.EnderecoDtos;
using API.Models;

namespace API.Data.Dtos.ProfessorDto
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
        public EnderecoDto endereco {get; set;}
    }
}