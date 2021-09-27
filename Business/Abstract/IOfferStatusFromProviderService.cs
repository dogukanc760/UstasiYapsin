using Core.Utilities.Results;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UstasiYapsinAPI.Entities.Concrete;

namespace Business.Abstract
{
    public interface IOfferStatusFromProviderService
    {
        IDataResult<List<OfferStatusFromProvider>> GetList();
        IDataResult<List<OfferStatusFromProvider>> GetOfferStatusListById(int Id);
        IDataResult<OfferStatusFromProvider> GetOfferStatusById(int Id);
        IResult Add(OfferStatusFromProvider offerStatusFromProvider);
        IResult Update(OfferStatusFromProvider offerStatusFromProvider);
        IResult Delete(OfferStatusFromProvider offerStatusFromProvider);
    }
}
