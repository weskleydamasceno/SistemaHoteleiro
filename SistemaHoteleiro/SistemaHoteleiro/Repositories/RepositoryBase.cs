using SistemaHoteleiro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaHoteleiro.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class, IEntidade
    {
        private readonly SistemaHoteleiroContexto _contexto;

        public RepositoryBase(SistemaHoteleiroContexto contexto)
        {
            this._contexto = contexto;
        }

        public virtual void Add(T entidade)
        {
            _contexto.Set<T>().Add(entidade);
            _contexto.SaveChanges();
        }

        public virtual T Find(int id)
        {
            return _contexto.Set<T>().FirstOrDefault(c => c.Id == id);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _contexto.Set<T>().ToList();
        }

        public virtual void Remove(int id)
        {
            var entidade = _contexto.Set<T>().First(c => c.Id == id);
            _contexto.Set<T>().Remove(entidade);
            _contexto.SaveChanges();
        }

        public virtual void Update(T entidade)
        {
            _contexto.Set<T>().Update(entidade);
        }
    }
}
