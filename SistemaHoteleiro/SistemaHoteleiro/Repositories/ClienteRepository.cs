using Microsoft.EntityFrameworkCore;
using SistemaHoteleiro.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaHoteleiro.Repositories
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
        public ClienteRepository(SistemaHoteleiroContexto contexto) : base(contexto)
        {
            contexto.Clientes.Include(c => c.Pessoa);
            contexto.Clientes.Include(c => c.ClienteTelefones);
        }
    }
}
