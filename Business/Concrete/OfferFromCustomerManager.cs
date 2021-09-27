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
    public class OfferFromCustomerManager : IOfferFromCustomerService
    {

        private IOfferFromCustomerDal _offerFromCustomerDal;
        public OfferFromCustomerManager(IOfferFromCustomerDal offerFromCustomerDal)
        {
            _offerFromCustomerDal = offerFromCustomerDal;
        }

        public IResult Add(OfferFromCustomer offerFromCustomer)
        {
            _offerFromCustomerDal.Add(offerFromCustomer);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(OfferFromCustomer offerFromCustomer)
        {
            _offerFromCustomerDal.Delete(offerFromCustomer);
            return new SuccessResult(Messages.Removed);
        }

        public IDataResult<List<OfferFromCustomer>> GetList()
        {
            return new SuccessDataResult<List<OfferFromCustomer>>(_offerFromCustomerDal.GetList().ToList());
        }

        public IDataResult<OfferFromCustomer> GetOfferById(int Id)
        {
            return new SuccessDataResult<OfferFromCustomer>(_offerFromCustomerDal.Get(x=>x.Id == Id));
        }

        public IDataResult<List<OfferFromCustomer>> GetOfferListById(int Id)
        {
            return new SuccessDataResult<List<OfferFromCustomer>>(_offerFromCustomerDal.GetList(x=>x.Id == Id).ToList());
        }

        public IResult Update(OfferFromCustomer offerFromCustomer)
        {
            return new SuccessResult(Messages.Updated);
        }
    }
}
