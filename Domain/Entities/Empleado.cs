using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Empleado
    {

        public int Codigo { get ; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public Estado Estado { get; set; }
    }
}
