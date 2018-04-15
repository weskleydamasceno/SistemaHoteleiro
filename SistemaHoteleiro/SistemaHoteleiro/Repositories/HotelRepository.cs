using SistemaHoteleiro.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaHoteleiro.Repositories
{
    public class HotelRepository : RepositoryBase<Hotel>, IHotelRepository
    {
        public HotelRepository(SistemaHoteleiroContexto contexto) : base(contexto)
        {
        }
    }
}
