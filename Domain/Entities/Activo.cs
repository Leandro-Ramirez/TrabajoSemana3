#region Usos
using System;
using Domain.Enum;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
#endregion

namespace Domain.Entities
{
    public class Activo
    {
        #region Get & Set
        public int Id { get; set; }
        public String Nombre { get; set; }
        public double Valor { get; set; }
        public int VidaUtil { get; set; }
        public double ValorResidual { get; set; }
        #endregion
    }
}