#region Usos
using System;
using Domain.Enum;
using System.Linq;
using System.Text;
using Domain.Interfaces;
using AppCore.Processes;
using System.Threading.Tasks;
using System.Collections.Generic;
#endregion

namespace AppCore.Factories
{
    public static class FactoryDeducciones
    {
        public static IDepreciacionModel FactoryDepreciacion(Depreciacion depreciacion)
        {
            if (depreciacion == Depreciacion.LineaRecta)
            {
                return new LineaRecta();
            }
            else
            {
                return new SDA();
            }
        }
    }
}