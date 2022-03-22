#region Usos
using System;
using System.Linq;
using System.Text;
using Domain.Entities;
using System.Threading.Tasks;
using System.Collections.Generic;
#endregion

namespace AppCore.IServices
{
   public interface IActivoServices: IServices<Activo>
    {
        Activo ObtenerElId(int id);
    }
}