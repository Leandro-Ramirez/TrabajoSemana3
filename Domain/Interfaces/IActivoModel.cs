#region Usos
using System;
using Domain.Enum;
using System.Linq;
using System.Text;
using Domain.Entities;
using System.Threading.Tasks;
using System.Collections.Generic;
#endregion

namespace Domain.Interfaces
{
    public interface IActivoModel : IModel<Activo>
    {
        Activo GetById(int id);
    }
}