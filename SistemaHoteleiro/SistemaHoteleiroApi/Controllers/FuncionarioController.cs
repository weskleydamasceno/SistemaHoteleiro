using Microsoft.AspNetCore.Mvc;
using SistemaHoteleiro.Models;
using SistemaHoteleiro.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaHoteleiroApi.Controllers
{
    [Route("api/[controller]")]
    public class FuncionarioController : Controller
    {
        private readonly IFuncionarioRepository _repositorio;

        public FuncionarioController(IFuncionarioRepository repositorio)
        {
            _repositorio = repositorio;
        }

        [HttpGet]
        public IEnumerable<Funcionario> GetAll()
        {
            return _repositorio.GetAll();
        }

        [HttpGet("{id}", Name = "GetFuncionario")]
        public IActionResult GetById(int id)
        {
            var item = _repositorio.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Funcionario funcionario)
        {
            if (funcionario == null)
            {
                return BadRequest();
            }

            _repositorio.Add(funcionario);

            return CreatedAtRoute("GetFuncionario", new { id = funcionario.Id }, funcionario);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Funcionario item)
        {
            if (item == null || item.Id != id)
            {
                return BadRequest();
            }

            var funcionario = _repositorio.Find(id);
            if (funcionario == null)
            {
                return NotFound();
            }

            funcionario.Salario = item.Salario;
            funcionario.PessoaId = item.PessoaId;
            funcionario.HotelId = item.HotelId;

            _repositorio.Update(funcionario);
            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var funcionario = _repositorio.Find(id);
            if (funcionario == null)
            {
                return NotFound();
            }

            _repositorio.Remove(id);
            return new NoContentResult();
        }
    }
}
