using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data.Dtos.AlunoDto;
using API.Data.Dtos.EnderecoDtos;
using API.Data.Dtos.ProfessorDto;
using API.Models;

namespace API.Data.Dtos
{
    public class SolucionaDto
    {
        public Aluno Create(CreateAlunoDto newObj)
        {
            Aluno obj = new Aluno()
            {
                Id = 0,
                nome = newObj.nome,
                email = newObj.email,
                nascimento = newObj.nascimento,
                turno = newObj.turno,

                endereco = new Endereco()
                {
                    IdEndereco = 0,

                    Cep = newObj.endereco.Cep,

                    Rua = newObj.endereco.Rua,

                    Cidade = newObj.endereco.Cidade,
                    Pais = newObj.endereco.Pais,

                }

            };

            return obj;
        }

        public Aluno Update (Aluno oldObj, UpdateAlunoDto newObj)
        {             
            
            if(!string.IsNullOrEmpty(newObj.email))
                oldObj.email = newObj.email;


            oldObj.endereco = SetEndereco(oldObj.endereco, newObj.endereco);

            return oldObj;
        }

        public Endereco SetEndereco(Endereco oldObj, EnderecoDto newObj)
        {
            Endereco endereco = new Endereco(){

                IdEndereco = oldObj.IdEndereco,
                Cep = oldObj.Cep,
                Rua = oldObj.Rua,
                Cidade = oldObj.Cidade,
                Pais = oldObj.Pais,

            };

            if(!string.IsNullOrEmpty(newObj.Cep))
                endereco.Cep = newObj.Cep;

            if(!(newObj.Rua == string.Empty))
                endereco.Rua = newObj.Rua;

            if(!(newObj.Cidade == string.Empty))
                endereco.Cidade = newObj.Cidade;

            if(!(newObj.Pais == string.Empty))
                endereco.Pais = newObj.Pais;

            
            return endereco;
        }


        public Professor Create(CreateProfessorDto newObj)
        {
            Professor professor = new Professor()
            {
                // Id = 0,
                nome = newObj.nome,
                email = newObj.email,
                nascimento = newObj.nascimento,
                disciplinaLecionada = newObj.disciplinaLecionada,
                // enderecoId = 0,

                endereco = new Endereco()
                {
                    IdEndereco = 0,

                    Cep = newObj.endereco.Cep,

                    Rua = newObj.endereco.Rua,

                    Cidade = newObj.endereco.Cidade,
                    Pais = newObj.endereco.Pais,

                }                

            };

            return professor;
        }

        public Professor Update (Professor oldObj, UpdateProfessorDto newObj)
        {             
            
            if(!string.IsNullOrEmpty(newObj.email))
                oldObj.email = newObj.email;


            oldObj.endereco = SetEndereco(oldObj.endereco, newObj.endereco);

            return oldObj;
        }
    }
}