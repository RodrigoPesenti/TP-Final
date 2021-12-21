using System;
using System.Collections.Generic;


namespace TP_Final.DAL
{
    public interface IRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// Añade una <paramref name="pEntity"/> a la base de datos
        /// </summary>
        /// <param name="pEntity"></param>
        public void Add(TEntity pEntity);

        /// <summary>
        /// Elimina la <paramref name="pEntity"/> de la base de datos
        /// </summary>
        /// <param name="pEntity"></param>
        public void Remove(TEntity pEntity);
        
        /// <summary>
        /// Devuelve la entidad para el ID asociado
        /// </summary>
        /// <param name="pId"></param>
        /// <returns>Un elemento de tipo correspondiente</returns>
        public TEntity Get(Int64 pId);

        /// <summary>
        /// Devuelve un IEnumerable con todos los elementos de la base de datos
        /// </summary>
        /// <returns>Un InternalDbSet</returns>
        public IEnumerable<TEntity> GetAll();
    }
}
