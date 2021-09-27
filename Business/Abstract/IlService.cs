using Core.Utilities.Results;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UstasiYapsinAPI.Entities.Concrete;

namespace Business.Abstract
{
    public interface IlService
    {
        IDataResult<List<Iller>> GetList();
        IDataResult<List<Iller>> GetIllerById(int Id);

        IResult Add(Iller ıller);
        IResult Update(Iller ıller);
        IResult Delete(Iller ıller);
    }
}
