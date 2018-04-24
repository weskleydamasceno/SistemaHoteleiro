using SistemaHoteleiro.Models;
using System;
using System.Collections.Generic;
using System.Text;
using SistemaHoteleiro.Repositories;

namespace SistemaHoteleiro.Services
{
    public class ServicoService : ServiceBase<Servico>, IServicoService
    {
        public ServicoService(IRepositoryBase<Servico> repositorio) : base(repositorio)
        {
        }
    }
}
