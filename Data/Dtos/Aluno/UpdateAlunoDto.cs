using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using API.Models;

namespace API.Data.Dtos.Aluno
{
    public class UpdateAlunoDto
    {        

        [Required]
        public String email { get; set; }

        [Required]
        public Endereco endereco {get; set;}
        

    }
}