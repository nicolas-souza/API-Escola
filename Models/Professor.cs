using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using API.Data.Dtos.ProfessorDto;

namespace API.Models
{
    public class Professor
    {
        
        [Key]
        public int Id { get; set; }
        
        [Required]
        public String nome { get; set; }
        
        public String email { get; set; }

        [Required]
        public DateTime nascimento { get; set; }

        [Required]
        public String disciplinaLecionada { get; set; }

        public int enderecoId { get; set; }

        [Required]
        public Endereco endereco {get; set;}
        
        public Professor Create(CreateProfessorDto newObj)
        {
            Professor obj = new Professor();

            obj.nome = newObj.nome;
            obj.email = newObj.email;
            obj.nascimento = newObj.nascimento;
            obj.disciplinaLecionada = newObj.disciplinaLecionada;
            obj.endereco.Cep = newObj.endereco.Cep;
            obj.endereco.Rua = newObj.endereco.Rua;
            obj.endereco.Cidade = newObj.endereco.Cidade;
            obj.endereco.Pais = newObj.endereco.Pais;

            return obj;
        }
        public Professor Update(Professor oldObj, UpdateProfessorDto newObj)
        {
            oldObj.endereco.Cep = newObj.endereco.Cep != null ? newObj.endereco.Cep : oldObj.endereco.Cep;
            oldObj.endereco.Rua = newObj.endereco.Rua != null ? newObj.endereco.Rua : oldObj.endereco.Rua;
            oldObj.endereco.Cidade = newObj.endereco.Cidade != null ? newObj.endereco.Cidade : oldObj.endereco.Cidade;
            oldObj.endereco.Pais = newObj.endereco.Pais != null ? newObj.endereco.Pais : oldObj.endereco.Pais;

            return oldObj;
        }
        
    }
}