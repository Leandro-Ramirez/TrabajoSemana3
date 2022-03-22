#region Usos
using System;
using System.Linq;
using System.Text;
using Domain.Entities;
using System.Threading.Tasks;
using System.Collections.Generic;
#endregion

namespace Domain.Interfaces
{
    public interface IDepreciacionModel
    {
        List<double> Depreciacion(Activo activo);
    }
}