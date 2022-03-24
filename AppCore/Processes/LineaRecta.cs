#region Usos
using System;
using System.Linq;
using System.Text;
using Domain.Entities;
using Domain.Interfaces;
using System.Threading.Tasks;
using System.Collections.Generic;
#endregion

namespace AppCore.Processes
{
    public class LineaRecta : IDepreciacionModel
    {
        public List<double> Depreciacion(Activo activo)
        {
            double depreciacion = (activo.Valor - activo.ValorResidual) / activo.VidaUtil;
            return Enumerable.Repeat<double>(depreciacion, activo.VidaUtil).ToList();
        }
    }
}