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
        }
    }
}
