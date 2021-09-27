using Core.Utilities.Results;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UstasiYapsinAPI.Entities.Concrete;

namespace Business.Abstract
{
    public interface IPhotosForOrderService
    {
        IDataResult<List<PhotosForOrder>> GetList();
        IDataResult<List<PhotosForOrder>> GetPhotosForOrderById(int Id);

        IResult Add(PhotosForOrder photosForOrder);
        IResult Update(PhotosForOrder photosForOrder);
        IResult Delete(PhotosForOrder photosForOrder);
    }
}
