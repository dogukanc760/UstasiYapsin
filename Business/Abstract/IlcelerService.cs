using Core.Utilities.Results;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UstasiYapsinAPI.Entities.Concrete;

namespace Business.Abstract
{
    public interface IlcelerService
    {
        IDataResult<List<Ilceler>> GetList();
        IDataResult<List<Ilceler>> GetIlceById(int Id);

        IResult Add(Ilceler ılceler);
        IResult Update(Ilceler ılceler);
        IResult Delete(Ilceler ılceler);
    }
}
