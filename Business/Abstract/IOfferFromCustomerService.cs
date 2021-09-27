using Core.Utilities.Results;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UstasiYapsinAPI.Entities.Concrete;

namespace Business.Abstract
{
    public interface IOfferFromCustomerService
    {
        IDataResult<List<OfferFromCustomer>> GetList();
        IDataResult<List<OfferFromCustomer>> GetOfferListById(int Id);
        IDataResult<OfferFromCustomer> GetOfferById(int Id);

        IResult Add(OfferFromCustomer offerFromCustomer);
        IResult Update(OfferFromCustomer offerFromCustomer);
        IResult Delete(OfferFromCustomer offerFromCustomer);
    }
}
