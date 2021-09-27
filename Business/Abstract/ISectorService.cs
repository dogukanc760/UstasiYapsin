using Core.Utilities.Results;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UstasiYapsinAPI.Entities.Concrete;

namespace Business.Abstract
{
    public interface ISectorService
    {
        IDataResult<List<Sector>> GetList();
        IDataResult<List<Sector>> GetSectorById(int Id);

        IResult Add(Sector sector);
        IResult Update(Sector sector);
        IResult Delete(Sector sector);
    }
}
