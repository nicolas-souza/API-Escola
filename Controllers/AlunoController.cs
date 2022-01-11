using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Data.Dtos;
using API.Data.Dtos.AlunoDto;
using API.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {

        private EscolaContext _context;

        private SolucionaDto dto = new SolucionaDto();

        public AlunoController(EscolaContext context)
        {
            _context = context;

        }

        [HttpGet]
        public IActionResult GetAllAluno()
        {
            var alunos =
                from aluno in _context.Alunos
                from endereco in _context.Enderecos
                where aluno.enderecoId == endereco.IdEndereco
                select new
                {
                    Nome = aluno.nome,

                    Email = aluno.email, 

                    Ano = aluno.ano,

                    Turno = aluno.turno,

                    Endereco =                     
                        new
                        {
                            Cep = endereco.Cep,
                            Rua = endereco.Rua,
                            Cidade = endereco.Cidade,
                            Pais = endereco.Pais
                        }
                };
            return Ok(alunos);
        }

[HttpGet("{id}")]
public IActionResult GetAlunoById(int id)
{
    Aluno aluno = _context.Alunos.AsNoTracking().FirstOrDefault(aluno => aluno.Id == id);

    aluno.endereco = _context.Enderecos.AsNoTracking().FirstOrDefault(endereco => endereco.IdEndereco == aluno.enderecoId);

    return Ok(aluno);
}

[HttpPost]
public IActionResult PostAluno(CreateAlunoDto newObj)
{
    try
    {
        Aluno obj = new Aluno();

        obj = dto.Create(newObj);

        _context.Alunos.Add(obj);

        _context.SaveChanges();
    }
    catch (Exception ex)
    {

    }


    return Ok();
}

[HttpPut("{id}")]
public IActionResult UpdateAluno(int id, UpdateAlunoDto updateAluno)
{
    Aluno aluno = _context.Alunos.AsNoTracking().FirstOrDefault(aluno => aluno.Id == id);

    aluno.endereco = _context.Enderecos.AsNoTracking().FirstOrDefault(endereco => endereco.IdEndereco == aluno.enderecoId);

    aluno = dto.Update(aluno, updateAluno);

    _context.Alunos.Update(aluno);

    _context.SaveChanges();

    return Ok(aluno);
}

[HttpDelete("{id}")]
public IActionResult DeleteProfessorById(int id)
{
    Aluno aluno = _context.Alunos.FirstOrDefault(aluno => aluno.Id == id);

    if (aluno != null)
    {
        _context.Alunos.Remove(aluno);
    }
    else
    {
        return NotFound();
    }

    _context.SaveChanges();

    return Ok(aluno);
}

    }
}