using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using API.Models;

namespace API.Data.Dtos.Aluno
{
    public class CreateAlunoDto
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

    }
}