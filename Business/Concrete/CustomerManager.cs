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
    public class CustomerManager:ICustomerService
    {
        private ICustomerDAL _customerDal;

        public CustomerManager(ICustomerDAL customerDal)
        {
            _customerDal = customerDal;
        }

        public void TInsert(Customer entity)
        {
            _customerDal.Insert(entity);
        }

        public void TDelete(Customer entity)
        {
            _customerDal.Delete(entity);
        }

        public void TUpdate(Customer entity)
        {
            _customerDal.Update(entity);
        }

        public List<Customer> TGetlist()
        {
            return _customerDal.GetList();
        }

        public Customer TGetById(int id)
        {
            return _customerDal.GetById(id);
        }

        public List<Customer> GetCustomersListWithJob()
        {
            return _customerDal.GetCustomerListWihtJob();
        }
    }
}
