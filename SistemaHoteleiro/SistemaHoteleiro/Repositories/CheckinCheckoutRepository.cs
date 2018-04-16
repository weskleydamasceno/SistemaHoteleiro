﻿using SistemaHoteleiro.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaHoteleiro.Repositories
{
    class CheckinCheckoutRepository : RepositoryBase<CheckinCheckout>, ICheckinCheckoutRepository
    {
        public CheckinCheckoutRepository(SistemaHoteleiroContexto contexto) : base(contexto)
        {
        }
    }
}