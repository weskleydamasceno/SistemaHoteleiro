using SistemaHoteleiro.Models;
using System;
using System.Collections.Generic;
using System.Text;
using SistemaHoteleiro.Repositories;

namespace SistemaHoteleiro.Services
{
    public class CheckinCheckoutService : ServiceBase<CheckinCheckout>, ICheckinCheckoutService
    {
        public CheckinCheckoutService(IRepositoryBase<CheckinCheckout> repositorio) : base(repositorio)
        {
        }
    }
}
