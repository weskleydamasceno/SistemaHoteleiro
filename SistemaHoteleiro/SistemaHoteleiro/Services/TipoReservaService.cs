using SistemaHoteleiro.Models;
using System;
using System.Collections.Generic;
using System.Text;
using SistemaHoteleiro.Repositories;

namespace SistemaHoteleiro.Services
{
    public class TipoReservaService : ServiceBase<TipoReserva>, ITipoReservaService
    {
        public TipoReservaService(IRepositoryBase<TipoReserva> repositorio) : base(repositorio)
        {
        }
    }
}
