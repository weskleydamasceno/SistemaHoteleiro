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
    public class PessoaController : Controller
    {
        private readonly IPessoaRepository _repositorio;

        public PessoaController(IPessoaRepository repositorio)
        {
            _repositorio = repositorio;
        }

        [HttpGet]
        public IEnumerable<Pessoa> GetAll()
        {
            return _repositorio.GetAll();
        }

        [HttpGet("{id}", Name = "GetPessoa")]
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
        public IActionResult Create([FromBody] Pessoa pessoa)
        {
            if (pessoa == null)
            {
                return BadRequest();
            }

            _repositorio.Add(pessoa);

            return CreatedAtRoute("GetPessoa", new { id = pessoa.Id }, pessoa);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Pessoa item)
        {
            if (item == null || item.Id != id)
            {
                return BadRequest();
            }

            var pessoa = _repositorio.Find(id);
            if (pessoa == null)
            {
                return NotFound();
            }

            pessoa.Nome = item.Nome;
            pessoa.Cpf = item.Cpf;
            pessoa.DataNasc = item.DataNasc;
            pessoa.Rua = item.Rua;
            pessoa.Bairro = item.Bairro;
            pessoa.Cidade = item.Cidade;

            _repositorio.Update(pessoa);
            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var pessoa = _repositorio.Find(id);
            if (pessoa == null)
            {
                return NotFound();
            }

            _repositorio.Remove(id);
            return new NoContentResult();
        }
    }
}