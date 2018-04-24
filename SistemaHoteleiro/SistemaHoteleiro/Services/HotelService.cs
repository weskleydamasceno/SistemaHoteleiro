using SistemaHoteleiro.Models;
using System;
using System.Collections.Generic;
using System.Text;
using SistemaHoteleiro.Repositories;

namespace SistemaHoteleiro.Services
{
    public class HotelService : ServiceBase<Hotel>, IHotelService
    {
        public HotelService(IRepositoryBase<Hotel> repositorio) : base(repositorio)
        {
        }
    }
}
