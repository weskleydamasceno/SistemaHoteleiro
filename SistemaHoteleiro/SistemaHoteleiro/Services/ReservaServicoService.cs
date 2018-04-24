using SistemaHoteleiro.Models;
using System;
using System.Collections.Generic;
using System.Text;
using SistemaHoteleiro.Repositories;

namespace SistemaHoteleiro.Services
{
    public class ReservaServicoService : ServiceBase<ReservaServico>, IReservaServicoService
    {
        public ReservaServicoService(IRepositoryBase<ReservaServico> repositorio) : base(repositorio)
        {
        }
    }
}
