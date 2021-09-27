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
    public class BusinessUserManager: IBusinessUserService
    {
        private IBusinessUserDal _businessUserDal;
        public BusinessUserManager(IBusinessUserDal businessUserDal)
        {
            _businessUserDal = businessUserDal;
        }

        public IResult Add(BusinessUser businessUser)
        {
            _businessUserDal.Add(businessUser);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(BusinessUser businessUser)
        {
            _businessUserDal.Delete(businessUser);
            return new SuccessResult(Messages.Removed);
        }

        public IDataResult<List<BusinessUser>> GetList()
        {
            return new SuccessDataResult<List<BusinessUser>>(_businessUserDal.GetList().ToList());
        }

        public IDataResult<BusinessUser> GetUserById(int Id)
        {
            return new SuccessDataResult<BusinessUser>(_businessUserDal.Get(x=>x.Id == Id));
        }

        public IResult Update(BusinessUser businessUser)
        {
            _businessUserDal.Update(businessUser);
            return new SuccessResult(Messages.Updated);
        }
    }
}
