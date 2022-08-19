using Generics.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Data
{
    public class Repositorio<TEntity> : IRepositorio<TEntity> where TEntity : Entity 
    {
        private List<TEntity> _lista;

        public Repositorio()
        {
            _lista = new List<TEntity>();
        }

        public void Adicionar(TEntity entity)
        {
            _lista.Add(entity);
        }

        public List<TEntity> ObterTodos()
        {
            return _lista;
        }
    }
}
