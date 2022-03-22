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
        void Delete(T t);
        List<T> Read();
    }
}