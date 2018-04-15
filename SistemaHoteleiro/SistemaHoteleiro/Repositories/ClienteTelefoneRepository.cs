using SistemaHoteleiro.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaHoteleiro.Repositories
{
    public class ClienteTelefoneRepository : RepositoryBase<ClienteTelefone>, IClienteTelefoneRepository
    {
        public ClienteTelefoneRepository(SistemaHoteleiroContexto contexto) : base(contexto)
        {
        }
    }
}
