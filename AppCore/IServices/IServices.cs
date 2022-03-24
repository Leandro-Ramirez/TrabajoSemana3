#region Usos
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
#endregion

namespace AppCore.IServices
{
    public interface IServices<T>
    {
        void Add(T t);
        void Delete(int id);
        void Delete(int id, List<int> listaIds);
        void Update(T t, int id);
        List<T> Read();
    }
}