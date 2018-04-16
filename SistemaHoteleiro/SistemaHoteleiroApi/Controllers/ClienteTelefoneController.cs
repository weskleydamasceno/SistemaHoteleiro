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
    public class ClienteTelefoneController : Controller
    {
        private readonly IClienteTelefoneRepository _repositorio;

        public ClienteTelefoneController(IClienteTelefoneRepository repositorio)
        {
            _repositorio = repositorio;
        }

        [HttpGet]
        public IEnumerable<ClienteTelefone> GetAll()
        {
            return _repositorio.GetAll();
        }

        [HttpGet("{id}", Name = "GetClienteTelefone")]
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
        public IActionResult Create([FromBody] ClienteTelefone clienteTelefone)
        {
            if (clienteTelefone == null)
            {
                return BadRequest();
            }

            _repositorio.Add(clienteTelefone);

            return CreatedAtRoute("GetClienteTelefone", new { id = clienteTelefone.Id }, clienteTelefone);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] ClienteTelefone item)
        {
            if (item == null || item.Id != id)
            {
                return BadRequest();
            }

            var clienteTelefone = _repositorio.Find(id);
            if (clienteTelefone == null)
            {
                return NotFound();
            }

            clienteTelefone.Telefone = item.Telefone;
            clienteTelefone.ClienteId = item.ClienteId;

            _repositorio.Update(clienteTelefone);
            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var clienteTelefone = _repositorio.Find(id);
            if (clienteTelefone == null)
            {
                return NotFound();
            }

            _repositorio.Remove(id);
            return new NoContentResult();
        }
    }
}
