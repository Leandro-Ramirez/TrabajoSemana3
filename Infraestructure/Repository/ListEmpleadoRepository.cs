using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
    class ListEmpleadoRepository : BaseRepositoy<Empleado>, IEmpleadoModel
    {




        public Empleado GetById(int id)
        {
            return data.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
