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
    public class ReferancePhotosManager : IReferancePhotosService
    {
        private IReferancePhotoDal _referancePhotosDal;
        public ReferancePhotosManager(IReferancePhotoDal referancePhotoDal)
        {
            _referancePhotosDal = referancePhotoDal;
        }
        public IResult Add(ReferancePhoto referancePhoto)
        {
            _referancePhotosDal.Add(referancePhoto);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(ReferancePhoto referancePhoto)
        {
            _referancePhotosDal.Delete(referancePhoto);
            return new SuccessResult(Messages.Removed);
        }

        public IDataResult<List<ReferancePhoto>> GetList()
        {
            return new SuccessDataResult<List<ReferancePhoto>>(_referancePhotosDal.GetList().ToList());
        }

        public IDataResult<List<ReferancePhoto>> GetPhotosById(int Id)
        {
            return new SuccessDataResult<List<ReferancePhoto>>(_referancePhotosDal.GetList(x=>x.ReferanceId == Id).ToList());
        }

        public IResult Update(ReferancePhoto referancePhoto)
        {
            _referancePhotosDal.Update(referancePhoto);
            return new SuccessResult(Messages.Updated);
        }
    }
}
