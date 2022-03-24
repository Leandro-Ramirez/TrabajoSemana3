#region Usos
using System;
using System.Linq;
using System.Text;
using Domain.Interfaces;
using System.Threading.Tasks;
using System.Collections.Generic;
#endregion

namespace Infraestructure.Repository
{
    public abstract class BaseRepositoy<T> : IModel<T>
    {
        public List<T> data;

        protected BaseRepositoy()
        {
            data = new List<T>();
        }

        #region Añadir
        public void Add(T t)
        {
            data.Add(t);
        }
        #endregion

        #region Eliminar
        public void Delete(T t)
        {
            data.Remove(t);
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
        public void Delete(int id, List<int> listaIds)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Leer
        public List<T> Read()
        {
            return data;
        }
        #endregion

        #region Actualizar
        public void Update(T t, int id)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}