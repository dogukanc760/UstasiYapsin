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
    public class PhotosForOrderManager : IPhotosForOrderService
    {
        private IPhotosForOrderDal _photosForOrderDal;
        public PhotosForOrderManager(IPhotosForOrderDal photosForOrderDal)
        {
            _photosForOrderDal = photosForOrderDal;
        }
        public IResult Add(PhotosForOrder photosForOrder)
        {
            _photosForOrderDal.Add(photosForOrder);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(PhotosForOrder photosForOrder)
        {
            _photosForOrderDal.Delete(photosForOrder);
            return new SuccessResult(Messages.Removed);
        }

        public IDataResult<List<PhotosForOrder>> GetList()
        {
            return new SuccessDataResult<List<PhotosForOrder>>(_photosForOrderDal.GetList().ToList());
        }

        public IDataResult<List<PhotosForOrder>> GetPhotosForOrderById(int Id)
        {
            return new SuccessDataResult<List<PhotosForOrder>>(_photosForOrderDal.GetList(x=>x.OrderFromId == Id).ToList());
        }

        public IResult Update(PhotosForOrder photosForOrder)
        {
            _photosForOrderDal.Update(photosForOrder);
            return new SuccessResult(Messages.Updated);
        }
    }
}
