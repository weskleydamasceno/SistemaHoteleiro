using Microsoft.EntityFrameworkCore;
using SistemaHoteleiro.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaHoteleiro.Repositories
{
    public class ReservaRepository : RepositoryBase<Reserva>, IReservaRepository
    {
        public ReservaRepository(SistemaHoteleiroContexto contexto) : base(contexto)
        {
            contexto.Reservas.Include(r => r.TipoReserva);
        }
    }
}
