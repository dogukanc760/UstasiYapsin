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
    public class IlcelerManager : IlcelerService
    {
        private IlcelerDal _ılcelerDal;
        public IlcelerManager(IlcelerDal ılcelerDal)
        {
            _ılcelerDal = ılcelerDal;
        }
        public IResult Add(Ilceler ılceler)
        {
            _ılcelerDal.Add(ılceler);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Ilceler ılceler)
        {
            _ılcelerDal.Delete(ılceler);
            return new SuccessResult(Messages.Removed);
        }

        public IDataResult<List<Ilceler>> GetIlceById(int Id)
        {
            return new SuccessDataResult<List<Ilceler>>(_ılcelerDal.GetList(x => x.IlId == Id).ToList());
        }

        public IDataResult<List<Ilceler>> GetList()
        {
            return new SuccessDataResult<List<Ilceler>>(_ılcelerDal.GetList().ToList());
        }

        public IResult Update(Ilceler ılceler)
        {
            _ılcelerDal.Update(ılceler);
            return new SuccessResult(Messages.Updated);
        }
    }
}
