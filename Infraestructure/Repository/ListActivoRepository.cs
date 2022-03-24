#region Usos
using System;
using Domain.Enum;
using System.Linq;
using System.Text;
using Domain.Entities;
using Domain.Interfaces;
using System.Threading.Tasks;
using System.Collections.Generic;
#endregion

namespace Infraestructure.Repository
{
    public class ListActivoRepository : BaseRepositoy<Activo>, IActivoModel
    {
        #region ObtenerElId
        public Activo GetById(int id)
        {
            return data.Where(x => x.Id == id).FirstOrDefault();

            //foreach(Activo activo in data)
            //{
            //    if (activo.Id == id)
            //    {
            //        return activo;
            //    }
            //}
            //return null;
        }
        #endregion
    }
}