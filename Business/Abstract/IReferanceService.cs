using Core.Utilities.Results;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UstasiYapsinAPI.Entities.Concrete;

namespace Business.Abstract
{
    public interface IReferanceService
    {
        IDataResult<List<Referance>> GetList();
        IDataResult<List<Referance>> GetReferanceById(int Id);

        IResult Add(Referance referance);
        IResult Update(Referance referance);
        IResult Delete(Referance referance);
    }
}
