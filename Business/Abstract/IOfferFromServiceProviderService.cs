using Core.Utilities.Results;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UstasiYapsinAPI.Entities.Concrete;

namespace Business.Abstract
{
    public interface IOfferFromServiceProviderService
    {
        IDataResult<List<OfferFromServiceProvider>> GetList();
        IDataResult<List<OfferFromServiceProvider>> GetOfferListById(int Id);
        IDataResult<OfferFromServiceProvider> GetById(int Id);
        IResult Add(OfferFromServiceProvider offerFromServiceProvider);
        IResult Update(OfferFromServiceProvider offerFromServiceProvider);
        IResult Delete(OfferFromServiceProvider offerFromServiceProvider);
    }
}
