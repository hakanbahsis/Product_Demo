using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using DataAccess.Repositories;
using Entitiy.Concrete;

namespace DataAccess.EntityFramework
{
    public class EfProductDAL:GenericRepository<Product>,IProductDAL
    {
    }
}
