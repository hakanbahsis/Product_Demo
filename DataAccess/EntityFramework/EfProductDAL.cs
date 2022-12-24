using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using DataAccess.Concrete.Context;
using DataAccess.Repositories;
using Entitiy.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.EntityFramework
{
    public class EfProductDAL:GenericRepository<Product>,IProductDAL
    {
        public List<Product> GetProductListWihtCategory()
        {
            using (var context = new Context())
            {
                return context.Products.Include(x => x.Category).ToList();
            }
        }
    }
}
