using SistemaHoteleiro.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaHoteleiro.Repositories
{
    public class TipoReservaRepository : RepositoryBase<TipoReserva>, ITipoReservaRepository
    {
        public TipoReservaRepository(SistemaHoteleiroContexto contexto) : base(contexto)
        {
        }
    }
}
