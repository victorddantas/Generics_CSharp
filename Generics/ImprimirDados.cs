using Generics.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public static class ImprimirDados 
    {
        public static void Imprimir<TEntity>(this List<TEntity> entities) where TEntity : Entity
        {
            if (entities.Count == 0)
            {
                Console.WriteLine($"Lista de {typeof(TEntity).Name} vazia");
            } 

            foreach (var entity in entities)
            {
                Console.WriteLine(entity);
            }

            Console.WriteLine();

        }

      
    }
}
