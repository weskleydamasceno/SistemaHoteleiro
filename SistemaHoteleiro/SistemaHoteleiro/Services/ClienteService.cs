using SistemaHoteleiro.Models;
using System;
using System.Collections.Generic;
using System.Text;
using SistemaHoteleiro.Repositories;

namespace SistemaHoteleiro.Services
{
    public class ClienteService : ServiceBase<Cliente>, IClienteService
    {
        public ClienteService(IRepositoryBase<Cliente> repositorio) : base(repositorio)
        {
        }
    }
}
