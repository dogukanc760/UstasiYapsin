using Business.Abstract;
using Business.Constants;

using Core.Utilities.Results;

using DataAccess.Abstract;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UstasiYapsinAPI.Entities.Concrete;

namespace Business.Concrete
{
    public class SliderManager : ISliderService
    {
        private ISliderDal _sliderDal;
        public SliderManager(ISliderDal sliderDal)
        {
            _sliderDal = sliderDal;
        }
        public IResult Add(Slider slider)
        {
            _sliderDal.Add(slider);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Slider slider)
        {
            _sliderDal.Delete(slider);
            return new SuccessResult(Messages.Removed);
        }

        public IDataResult<List<Slider>> GetList()
        {
            return new SuccessDataResult<List<Slider>>(_sliderDal.GetList().ToList());
        }

        public IDataResult<List<Slider>> GetSliderById(int Id)
        {
            return new SuccessDataResult<List<Slider>>(_sliderDal.GetList(x=>x.Id == Id).ToList());
        }

        public IResult Update(Slider slider)
        {
            _sliderDal.Update(slider);
            return new SuccessResult(Messages.Updated);
        }
    }
}
