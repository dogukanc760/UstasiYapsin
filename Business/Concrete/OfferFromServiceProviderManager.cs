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
    public class OfferFromServiceProviderManager : IOfferFromServiceProviderService
    {
        private IOfferFromServiceProviderDal _offerFromServiceDal;
        public OfferFromServiceProviderManager(IOfferFromServiceProviderDal offerFromServiceProviderDal)
        {
            _offerFromServiceDal = offerFromServiceProviderDal;
        }
        public IResult Add(OfferFromServiceProvider offerFromServiceProvider)
        {
            _offerFromServiceDal.Add(offerFromServiceProvider);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(OfferFromServiceProvider offerFromServiceProvider)
        {
            _offerFromServiceDal.Delete(offerFromServiceProvider);
            return new SuccessResult(Messages.Removed);
        }

        public IDataResult<OfferFromServiceProvider> GetById(int Id)
        {
            return new SuccessDataResult<OfferFromServiceProvider>(_offerFromServiceDal.Get(x=>x.Id == Id));
        }

        public IDataResult<List<OfferFromServiceProvider>> GetList()
        {
            return new SuccessDataResult<List<OfferFromServiceProvider>>(_offerFromServiceDal.GetList().ToList());
        }

        public IDataResult<List<OfferFromServiceProvider>> GetOfferListById(int Id)
        {
            return new SuccessDataResult<List<OfferFromServiceProvider>>(_offerFromServiceDal.GetList(x => x.ServiceProviderId == Id).ToList());
        }

        public IResult Update(OfferFromServiceProvider offerFromServiceProvider)
        {
            return new SuccessResult(Messages.Updated);
        }
    }
}
