using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using API.Data.Dtos.AlunoDto;

namespace API.Models
{
    public class Aluno
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public String nome { get; set; }

        [Required]
        public String turno { get; set; }

        [Required]
        public DateTime nascimento { get; set; }

        [Required]
        public String email { get; set; }
        
        public int enderecoId { get; set; }

        [Required]
        public Endereco endereco { get; set; }

        [Required]
        public int ano { get; set; }       
    

    }
}