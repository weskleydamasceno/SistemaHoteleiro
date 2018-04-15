using SistemaHoteleiro.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaHoteleiro.Repositories
{
    public class ReservaServicoRepository : RepositoryBase<ReservaServico>, IReservaServicoRepository
    {
        public ReservaServicoRepository(SistemaHoteleiroContexto contexto) : base(contexto)
        {
        }
    }
}
