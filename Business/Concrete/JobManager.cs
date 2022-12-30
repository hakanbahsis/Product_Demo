using Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using DataAccess.EntityFramework;
using Entitiy.Concrete;

namespace Business.Concrete
{
    public class JobManager:IGenericService<Job>
    {
        private IJobDAL _jobDal;

        public JobManager(IJobDAL jobDal)
        {
            _jobDal = jobDal;
        }

        public void TInsert(Job entity)
        {
            _jobDal.Insert(entity);
        }

        public void TDelete(Job entity)
        {
            _jobDal.Delete(entity);
        }

        public void TUpdate(Job entity)
        {
           _jobDal.Update(entity);
        }

        public List<Job> TGetlist()
        {
            return _jobDal.GetList();
        }

        public Job TGetById(int id)
        {
            return _jobDal.GetById(id);
        }

       
    }
}
