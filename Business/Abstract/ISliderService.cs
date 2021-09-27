using Core.Utilities.Results;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UstasiYapsinAPI.Entities.Concrete;

namespace Business.Abstract
{
    public interface ISliderService
    {
        IDataResult<List<Slider>> GetList();
        IDataResult<List<Slider>> GetSliderById(int Id);

        IResult Add(Slider slider);
        IResult Update(Slider slider);
        IResult Delete(Slider slider);
    }
}
