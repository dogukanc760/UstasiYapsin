using Core.Utilities.Results;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UstasiYapsinAPI.Entities.Concrete;

namespace Business.Abstract
{
    public interface IBusinessUserService
    {
        IDataResult<List<BusinessUser>> GetList();
        IDataResult<BusinessUser> GetUserById(int Id);


        IResult Add(BusinessUser businessUser);
        IResult Update(BusinessUser businessUser);
        IResult Delete(BusinessUser businessUser);
    }
}
