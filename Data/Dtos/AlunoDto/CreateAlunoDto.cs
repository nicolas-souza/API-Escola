using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using API.Data.Dtos.EnderecoDtos;
using API.Models;

namespace API.Data.Dtos.AlunoDto
{
    public class CreateAlunoDto
    {        
        [Required]
        public String nome { get; set; }

        [Required]
        public String email { get; set; }

        public DateTime nascimento { get; set; }
        
        [Required]
        public EnderecoDto endereco {get; set;}

        [Required]
        public int ano { get; set; }

        [Required]
        public String turno { get; set; }


    }
}