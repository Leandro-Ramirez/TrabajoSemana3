#region Usos
using System;
using System.Linq;
using System.Text;
using AppCore.IServices;
using Domain.Interfaces;
using System.Threading.Tasks;
using System.Collections.Generic;
#endregion

namespace AppCore.Services
{
    public abstract class BaseServices<T> : IServices<T>
    {

        #region Globales
        private IModel<T> Model;
        #endregion

        #region Protected
        protected BaseServices(IModel<T> model)
        {
            this.Model = model;
        }
        #endregion


        #region Añadir
        public void Add(T t)
        {
            Model.Add(t);
        }
        #endregion

        #region Eliminar
        public void Delete(int id)
        {
            Model.Delete(id);
        }
        public void Delete(int id, List<int> listaIds)
        {
            Model.Delete(id, listaIds);
        }
        #endregion

        #region Leer
        public List<T> Read()
        {
            return Model.Read();
        }
        #endregion

        #region Actualizar
        public void Update(T t, int id)
        {
            Model.Update(t, id);
        }
        #endregion
    }
}