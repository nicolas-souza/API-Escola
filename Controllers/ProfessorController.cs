using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Data.Dtos;
using API.Data.Dtos.ProfessorDto;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfessorController : ControllerBase
    {
        //interface com o banco
        private EscolaContext _context;

        private SolucionaDto dto = new SolucionaDto();

        
        //Os parâmetros vem do Startup.cs
        public ProfessorController(EscolaContext context)
        {
            _context = context;
            
        }

        [HttpGet]
        public IActionResult GetAllProfessor()
        {
            var Allprofessor = 
                from professor in _context.Professores
                from endereco in _context.Enderecos
                where professor.enderecoId == endereco.IdEndereco
                select new 
                {
                    nome = professor.nome,
                    email = professor.email,
                    nascimento = professor.nascimento,
                    disciplina = professor.disciplinaLecionada, 
                    endereco = new {
                        Cep = endereco.Cep,
                        Rua = endereco.Rua,
                        Cidade = endereco.Cidade,
                        Pais = endereco.Pais
                    }
                };

            return Ok(Allprofessor);
        }

        [HttpGet("{id}")]
        public IActionResult GetProfessorById(int id)
        {
            Professor professor = _context.Professores.AsNoTracking().FirstOrDefault(professor => professor.Id == id);    

            professor.endereco = _context.Enderecos.AsNoTracking().FirstOrDefault(endereco => endereco.IdEndereco == professor.enderecoId);        
             
            return Ok(professor);
        }

        [HttpPost]
        public IActionResult PostProfessor(CreateProfessorDto newProfessor)
        {
            Professor professor = dto.Create(newProfessor);

            _context.Professores.Add(professor);

            _context.SaveChanges();

            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProfessor(int id, UpdateProfessorDto updateProfessor)
        {
            
            Professor professor = _context.Professores.AsNoTracking().FirstOrDefault(aluno => aluno.Id == id);

            professor.endereco = _context.Enderecos.AsNoTracking().FirstOrDefault(endereco => endereco.IdEndereco == professor.enderecoId);

            professor = dto.Update(professor, updateProfessor);

            _context.Professores.Update(professor);

            _context.SaveChanges();

            return Ok(GetProfessorById(id));
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProfessorById(int id)
        {
            Professor professor = _context.Professores.FirstOrDefault(professor => professor.Id == id);

            if (professor != null)
            {
                _context.Professores.Remove(professor);
            }
            else 
            {
                return NotFound();
            }

            _context.SaveChanges();

            return Ok(professor);
        }      


    }
}