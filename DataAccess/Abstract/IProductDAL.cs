using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entitiy.Concrete;

namespace DataAccess.Abstract
{
    public interface IProductDAL:IGenericDAL<Product>
    {
        List<Product> GetProductListWihtCategory();
    }
}
