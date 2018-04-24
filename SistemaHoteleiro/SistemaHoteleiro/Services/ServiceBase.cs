using SistemaHoteleiro.Models;
using SistemaHoteleiro.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SistemaHoteleiro.Services
{
    public class ServiceBase<T> : IServiceBase<T> where T : class, IEntidade
    {
        private readonly IRepositoryBase<T> _repositorio;

        public ServiceBase(IRepositoryBase<T> repositorio)
        {
            this._repositorio = repositorio;
        }

        public virtual void Add(T entidade)
        {
            _repositorio.Add(entidade);
        }

        public virtual T Find(int id)
        {
            return _repositorio.Find(id);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _repositorio.GetAll();
        }

        public virtual void Remove(int id)
        {
            _repositorio.Remove(id);
        }

        public virtual void Update(T entidade)
        {
            _repositorio.Update(entidade);
        }
    }
}
