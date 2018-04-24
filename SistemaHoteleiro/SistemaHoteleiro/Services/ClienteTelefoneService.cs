using SistemaHoteleiro.Models;
using System;
using System.Collections.Generic;
using System.Text;
using SistemaHoteleiro.Repositories;

namespace SistemaHoteleiro.Services
{
    public class ClienteTelefoneService : ServiceBase<ClienteTelefone>, IClienteTelefoneService
    {
        public ClienteTelefoneService(IRepositoryBase<ClienteTelefone> repositorio) : base(repositorio)
        {
        }
    }
}
