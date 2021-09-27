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
    public class MobileImageManager : IMobileImageService
    {

        private IMobileImageDal _mobileImageDal;
        public MobileImageManager(IMobileImageDal mobileImageDal)
        {
            _mobileImageDal = mobileImageDal;
        }

        public IResult Add(MobileImage mobileImage)
        {
            _mobileImageDal.Add(mobileImage);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(MobileImage mobileImage)
        {
            _mobileImageDal.Delete(mobileImage);
            return new SuccessResult(Messages.Removed);
        }

        public IDataResult<List<MobileImage>> GetList()
        {
            return new SuccessDataResult<List<MobileImage>>(_mobileImageDal.GetList().ToList());
        }

        public IDataResult<List<MobileImage>> GetListById(int Id)
        {
            return new SuccessDataResult<List<MobileImage>>(_mobileImageDal.GetList(x=>x.Id == Id).ToList());
        }

        public IDataResult<MobileImage> GetMobileImageById(int Id)
        {
            return new SuccessDataResult<MobileImage>(_mobileImageDal.Get(x=>x.Id == Id));
        }

        public IResult Update(MobileImage mobileImage)
        {
            _mobileImageDal.Update(mobileImage);
            return new SuccessResult(Messages.Updated);
        }
    }
}
