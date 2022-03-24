#region Usos
using System;
using System.Linq;
using System.Text;
using Domain.Entities;
using AppCore.IServices;
using Domain.Interfaces;
using System.Threading.Tasks;
using System.Collections.Generic;
#endregion

namespace AppCore.Services
{
    public class ActivoServices : BaseServices<Activo>, IActivoServices
    {
        IActivoModel activoModel;

        public ActivoServices(IActivoModel model) : base(model)
        {
            this.activoModel = model;
        }

        #region ObtenerElId
        public Activo GetById(int id)
        {
            return activoModel.GetById(id);
        }
        #endregion
    }
}