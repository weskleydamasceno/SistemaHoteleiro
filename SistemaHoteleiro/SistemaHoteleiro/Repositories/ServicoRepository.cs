using SistemaHoteleiro.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaHoteleiro.Repositories
{
    public class ServicoRepository : RepositoryBase<Servico>, IServicoRepository
    {
        public ServicoRepository(SistemaHoteleiroContexto contexto) : base(contexto)
        {
        }
    }
}
