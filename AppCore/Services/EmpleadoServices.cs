using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;

namespace AppCore.Services
{
    class EmpleadoServices : BaseServices<Empleado>, IEmpleadoServices
    {

        IEmpleadoModel EmpleadoModel;


        public EmpleadoServices(IEmpleadoModel model) : base(model)
        {

            this.EmpleadoModel = model;
        }


        public Empleado GetById(int id)
        {
            throw new NotImplementedException();
        }


    }
}
