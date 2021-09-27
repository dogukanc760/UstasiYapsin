using Core.Utilities.Results;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UstasiYapsinAPI.Entities.Concrete;

namespace Business.Abstract
{
    public interface ISettingService
    {
        IDataResult<List<Setting>> GetList();
        IDataResult<List<Setting>> GetSettingById(int Id);

        IResult Add(Setting setting);
        IResult Update(Setting setting);
        IResult Delete(Setting setting);
    }
}
