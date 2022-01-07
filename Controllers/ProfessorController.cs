using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Data.Dtos.Professor;
using API.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfessorController : ControllerBase
    {
        //interface com o banco
        private EscolaContext _context;

        //Realiza as conversões DTO
        private IMapper _mapper;

        //Os parâmetros vem do Startup.cs
        public ProfessorController(EscolaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllProfessor()
        {
            return Ok(_context.Professores.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetProfessorById(int id)
        {
            Professor professor = _context.Professores.FirstOrDefault(professor => professor.Id == id);
            
            return Ok(professor);
        }

        [HttpPost]
        public IActionResult PostProfessor(CreateProfessorDto newProfessor)
        {
            Professor professor = _mapper.Map<Professor>(newProfessor);

            _context.Professores.Add(professor);

            _context.SaveChanges();

            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProfessor(int id, UpdateProfessorDto updateProfessor)
        {
            Professor professor = _context.Professores.FirstOrDefault(professor => professor.Id == id);

            professor.email = updateProfessor.email;
            professor.endereco = updateProfessor.endereco;

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