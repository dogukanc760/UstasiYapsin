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
    public class SectorManager : ISectorService
    {
        private ISectorDal _sectorDal;
        public SectorManager(ISectorDal sectorDal)
        {
            _sectorDal = sectorDal;
        }
        public IResult Add(Sector sector)
        {
            _sectorDal.Add(sector);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Sector sector)
        {
            _sectorDal.Delete(sector);
            return new SuccessResult(Messages.Removed);
        }

        public IDataResult<List<Sector>> GetList()
        {
            return new SuccessDataResult<List<Sector>>(_sectorDal.GetList().ToList());
        }

        public IDataResult<List<Sector>> GetSectorById(int Id)
        {
            return new SuccessDataResult<List<Sector>>(_sectorDal.GetList(x=>x.CategoryId == Id).ToList());
        }

        public IResult Update(Sector sector)
        {
            _sectorDal.Update(sector);
            return new SuccessResult(Messages.Updated);
        }
    }
}
