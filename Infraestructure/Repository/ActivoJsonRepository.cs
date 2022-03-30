using Domain.Entities;
using Domain.SubModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
    public class ActivoJsonRepository
    {

        private RAFContext context;
        private int SIZE = 1600;

        public ActivoJsonRepository()
        {
            context = new RAFContext("activoJson", SIZE);
        }
        public void Add(Activo t)
        {
            try
            {
                t.Id = context.GetLastId() + 1;
                context.Create<ActivoSubModel>(ActivoSubModel.Convert(t));
            }
            catch (Exception)
            {
                throw;

            }
            
        }

        public void Delete(Activo t)
        {
            throw new NotImplementedException();
        }

        public Activo GetById(Activo t)
        {
            throw new NotImplementedException();
        }

        public List<Activo> Read()
        {
            List<ActivoSubModel> activoSubModels = context.GetAll<ActivoSubModel>();
            return activoSubModels.Count == 0 ? new List<Activo>() :
                activoSubModels.Select(x => ActivoSubModel.Convert(x)).ToList();
        }
    }
}
