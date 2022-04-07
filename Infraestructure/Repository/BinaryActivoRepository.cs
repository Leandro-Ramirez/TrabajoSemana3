#region Usos
using System;
using System.Linq;
using System.Text;
using Domain.Entities;
using Domain.Interfaces;
using System.Threading.Tasks;
using System.Collections.Generic;
#endregion

namespace Infraestructure.Repository
{
    public class BinaryActivoRepository : IActivoModel
    {
        
        private RAFContext context;
        private const int SIZE = 119;
        

        public BinaryActivoRepository()
        {
            context = new RAFContext("activo", SIZE);
        }

        
        
        public void Add(Activo t)
        {
            try
            {
                context.Create<Activo>(t);
            }
            catch (Exception)
            {
                throw;
            }
        }
        

        
        public void Delete(int id, List<int> listaIds)
        {
            try
            {
                context.Delete<Activo>(id, listaIds);
            }
            catch (Exception)
            {
                throw;
            }
        }
       

        
        public Activo GetById(int id)
        {
            try
            {
                return context.Get<Activo>(id);
            }
            catch (Exception)
            {
                throw;
            }
        }
        

       
        public List<Activo> Read()
        {
            try
            {
                return context.GetAll<Activo>();
            }
            catch (Exception)
            {
                throw;
            }
        }
      

        
        public void Update(Activo t, int id)
        {
            try
            {
                context.Update(t, id);
            }
            catch (Exception)
            {
                throw;
            }
        }
       

        
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
        
       
    }
}