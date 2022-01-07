using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using API.Models;

namespace API.Data.Dtos.Professor
{
    public class UpdateProfessorDto
    {
        [Required]
        public int Id { get; set; }
        
        public String email { get; set; }
        
        [Required]
        public Endereco endereco {get; set;}
        
    }
}