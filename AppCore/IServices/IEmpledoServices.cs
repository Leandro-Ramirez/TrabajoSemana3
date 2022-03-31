using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.IServices
{
    interface IEmpledoServices : IServices<Empleado>
    {

        Empleado GeyById(int id);


    }
}
