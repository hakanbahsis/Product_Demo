using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entitiy.Concrete;

namespace Business.Concrete
{
    public class ProductManager:IProductService
    {
        private IProductDAL _productDal;
        public ProductManager(IProductDAL productDal)
        {
            _productDal = productDal;
        }
        public void TInsert(Product entity)
        {
           _productDal.Insert(entity);
           
        }

        public void TDelete(Product entity)
        {
            _productDal.Delete(entity);
        }

        public void TUpdate(Product entity)
        {
            _productDal.Update(entity);
        }

        public List<Product> TGetlist()
        {
            return _productDal.GetList();
        }

        public Product TGetById(int id)
        {
            return _productDal.GetById(id);
        }

        public List<Product> GetProductsListWithCategory()
        {
            return _productDal.GetProductListWihtCategory();
        }
    }
}
