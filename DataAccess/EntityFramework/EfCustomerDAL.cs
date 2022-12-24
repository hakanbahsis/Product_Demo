using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using DataAccess.Concrete.Context;
using DataAccess.Repositories;
using Entitiy.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.EntityFramework
{
    public class EfCustomerDAL:GenericRepository<Customer>,ICustomerDAL
    {
        public List<Customer> GetCustomerListWihtJob()
        {
            using (var context=new Context())
            {
                return context.Customers.Include(x => x.Job).ToList();
            }
        }
    }
}
