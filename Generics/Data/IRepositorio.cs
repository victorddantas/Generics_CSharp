using Generics.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Data
{
    public interface IRepositorio<TEntity> where  TEntity : Entity
    {
        public void Adicionar(TEntity entity);
        public List<TEntity> ObterTodos();

    }
}
