using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using API.Data.Dtos.EnderecoDtos;
using API.Models;

namespace API.Data.Dtos.AlunoDto
{
    public class UpdateAlunoDto
    {     
        [Required (AllowEmptyStrings = true)]   
        public String email { get; set; }

        [Required (AllowEmptyStrings = true)]        
        public EnderecoDto endereco {get; set;}        

    }
}