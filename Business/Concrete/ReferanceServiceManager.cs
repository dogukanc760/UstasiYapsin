using Business.Abstract;
using Business.Constants;

using Core.Utilities.Results;

using DataAccess.Abstract;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UstasiYapsinAPI.Entities.Concrete;

namespace Business.Concrete
{
    public class ReferanceServiceManager : IReferanceService
    {
        private IReferanceDal _referanceDal;
        public ReferanceServiceManager(IReferanceDal referanceDal)
        {
            _referanceDal = referanceDal;
        }
        public IResult Add(Referance referance)
        {
            _referanceDal.Add(referance);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Referance referance)
        {
            _referanceDal.Delete(referance);
            return new SuccessResult(Messages.Removed);
        }

        public IDataResult<List<Referance>> GetList()
        {
            return new SuccessDataResult<List<Referance>>(_referanceDal.GetList().ToList());
        }

        public IDataResult<List<Referance>> GetReferanceById(int Id)
        {
            return new SuccessDataResult<List<Referance>>(_referanceDal.GetList(x=>x.UserId == Id).ToList());
        }

        public IResult Update(Referance referance)
        {
            _referanceDal.Update(referance);
            return new SuccessResult(Messages.Updated);
        }
    }
}
