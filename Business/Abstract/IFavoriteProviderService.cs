using Core.Utilities.Results;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UstasiYapsinAPI.Entities.Concrete;

namespace Business.Abstract
{
    public interface IFavoriteProviderService
    {
        IDataResult<List<FavoriteProvider>> GetList();
        IDataResult<List<FavoriteProvider>> GetFavoriteById(int Id);

        IResult Add(FavoriteProvider favoriteProvider);
        IResult Update(FavoriteProvider favoriteProvider);
        IResult Delete(FavoriteProvider favoriteProvider);
    }
}
