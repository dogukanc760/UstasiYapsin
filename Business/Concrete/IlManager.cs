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
    public class IlManager : IlService
    {
        private IlDal _ılDal;
        public IlManager(IlDal ılDal)
        {
            _ılDal = ılDal;
        }
        public IResult Add(Iller ıller)
        {
            _ılDal.Add(ıller);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Iller ıller)
        {
            _ılDal.Delete(ıller);
            return new SuccessResult(Messages.Removed);
        }

        public IDataResult<List<Iller>> GetIllerById(int Id)
        {
            return new SuccessDataResult<List<Iller>>(_ılDal.GetList(x=>x.IlId == Id).ToList());
        }

        public IDataResult<List<Iller>> GetList()
        {
            return new SuccessDataResult<List<Iller>>(_ılDal.GetList().ToList());
        }

        public IResult Update(Iller ıller)
        {
            _ılDal.Update(ıller);
            return new SuccessResult(Messages.Updated);
        }
    }
}
