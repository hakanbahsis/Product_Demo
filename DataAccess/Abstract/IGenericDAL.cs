using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IGenericDAL<T> where T : class
    {
        void Insert(T item);
        void Update(T item);
        void Delete(T item);
        List<T> GetList();
        T GetById(int id);
    }
}
