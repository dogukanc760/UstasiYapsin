using Core.Entities;
using Core.Utilities.Results;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UstasiYapsinAPI.Entities.Concrete;

namespace Business.Abstract
{
    public interface IAddressService
    {
        IDataResult<List<Address>> GetList();
        IDataResult<List<Address>> GetAdressByUser(int userId);

        IResult Add(Address address);
        IResult Update(Address address);
        IResult Delete(Address address);
    }
}
