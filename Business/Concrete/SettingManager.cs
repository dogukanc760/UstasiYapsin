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
    public class SettingManager : ISettingService
    {
        private ISettingDal _settingDal;
        public SettingManager(ISettingDal settingDal)
        {
            _settingDal = settingDal;
        }
        public IResult Add(Setting setting)
        {
            _settingDal.Add(setting);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Setting setting)
        {
            _settingDal.Delete(setting);
            return new SuccessResult(Messages.Removed);
        }

        public IDataResult<List<Setting>> GetList()
        {
            return new SuccessDataResult<List<Setting>>(_settingDal.GetList().ToList());
        }

        public IDataResult<List<Setting>> GetSettingById(int Id)
        {
            return new SuccessDataResult<List<Setting>>(_settingDal.GetList(x=>x.Id == Id).ToList());
        }

        public IResult Update(Setting setting)
        {
            _settingDal.Update(setting);
            return new SuccessResult(Messages.Updated);
        }
    }
}
