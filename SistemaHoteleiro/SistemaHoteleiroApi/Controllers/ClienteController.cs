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
    public class ClienteController : Controller
    {
        private readonly IClienteRepository _repositorio;

        public ClienteController(IClienteRepository repositorio)
        {
            _repositorio = repositorio;
        }

        [HttpGet]
        public IEnumerable<Cliente> GetAll()
        {
            return _repositorio.GetAll();
        }

        [HttpGet("{id}", Name = "GetCliente")]
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
        public IActionResult Create([FromBody] Cliente cliente)
        {
            if (cliente == null)
            {
                return BadRequest();
            }

            _repositorio.Add(cliente);

            return CreatedAtRoute("GetCliente", new { id = cliente.Id }, cliente);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Cliente item)
        {
            if (item == null || item.Id != id)
            {
                return BadRequest();
            }

            var cliente = _repositorio.Find(id);
            if (cliente == null)
            {
                return NotFound();
            }

            cliente.Email = item.Email;
            cliente.PessoaId = item.PessoaId;

            _repositorio.Update(cliente);
            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var cliente = _repositorio.Find(id);
            if (cliente == null)
            {
                return NotFound();
            }

            _repositorio.Remove(id);
            return new NoContentResult();
        }
    }
}
