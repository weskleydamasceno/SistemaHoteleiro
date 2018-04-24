using SistemaHoteleiro.Models;
using System;
using System.Collections.Generic;
using System.Text;
using SistemaHoteleiro.Repositories;

namespace SistemaHoteleiro.Services
{
    public class ReservaService : ServiceBase<Reserva>, IReservaService
    {
        public ReservaService(IRepositoryBase<Reserva> repositorio) : base(repositorio)
        {
        }
    }
}
