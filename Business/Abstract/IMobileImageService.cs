using Core.Utilities.Results;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UstasiYapsinAPI.Entities.Concrete;

namespace Business.Abstract
{
    public interface IMobileImageService
    {
        IDataResult<List<MobileImage>> GetList();
        IDataResult<List<MobileImage>> GetListById(int Id);
        IDataResult<MobileImage> GetMobileImageById(int Id);

        IResult Add(MobileImage mobileImage);
        IResult Update(MobileImage mobileImage);
        IResult Delete(MobileImage mobileImage);
    }
}
