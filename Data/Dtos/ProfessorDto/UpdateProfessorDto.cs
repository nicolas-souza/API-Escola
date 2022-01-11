using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using API.Data.Dtos.EnderecoDtos;

namespace API.Data.Dtos.ProfessorDto
{
    public class UpdateProfessorDto
    {        
        public String email { get; set; }
        
        
        public EnderecoDto endereco {get; set;}
        
    }
}