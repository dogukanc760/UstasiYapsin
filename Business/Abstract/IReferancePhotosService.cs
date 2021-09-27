using Core.Utilities.Results;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UstasiYapsinAPI.Entities.Concrete;

namespace Business.Abstract
{
    public interface IReferancePhotosService
    {
        IDataResult<List<ReferancePhoto>> GetList();
        IDataResult<List<ReferancePhoto>> GetPhotosById(int Id);

        IResult Add(ReferancePhoto referancePhoto);
        IResult Update(ReferancePhoto referancePhoto);
        IResult Delete(ReferancePhoto referancePhoto);
    }
}
