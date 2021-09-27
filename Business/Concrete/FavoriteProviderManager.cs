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
    public class FavoriteProviderManager: IFavoriteProviderService
    {
        private IFavoriteProviderDal _favoriteProviderDal;
        public FavoriteProviderManager(IFavoriteProviderDal favoriteProviderDal)
        {
            _favoriteProviderDal = favoriteProviderDal;
        }

        public IResult Add(FavoriteProvider favoriteProvider)
        {
            _favoriteProviderDal.Add(favoriteProvider);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(FavoriteProvider favoriteProvider)
        {
            _favoriteProviderDal.Delete(favoriteProvider);
            return new SuccessResult(Messages.Removed);
        }

        public IDataResult<List<FavoriteProvider>> GetFavoriteById(int Id)
        {
            return new SuccessDataResult<List<FavoriteProvider>>(_favoriteProviderDal.GetList(x=>x.Id == Id).ToList());
        }

        public IDataResult<List<FavoriteProvider>> GetList()
        {
            return new SuccessDataResult<List<FavoriteProvider>>(_favoriteProviderDal.GetList().ToList());
        }

        public IResult Update(FavoriteProvider favoriteProvider)
        {
            _favoriteProviderDal.Update(favoriteProvider);
            return new SuccessResult(Messages.Updated);
        }
    }
}
