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
    public class OfferStatusFromProviderManager : IOfferStatusFromProviderService
    {
        private IOfferStatusFromProviderDal _offerStatusProvider;
        public OfferStatusFromProviderManager(IOfferStatusFromProviderDal offerStatusFromProviderDal)
        {
            _offerStatusProvider = offerStatusFromProviderDal;
        }
        public IResult Add(OfferStatusFromProvider offerStatusFromProvider)
        {
            _offerStatusProvider.Add(offerStatusFromProvider);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(OfferStatusFromProvider offerStatusFromProvider)
        {
            _offerStatusProvider.Delete(offerStatusFromProvider);
            return new SuccessResult(Messages.Removed);
        }

        public IDataResult<List<OfferStatusFromProvider>> GetList()
        {
            return new SuccessDataResult<List<OfferStatusFromProvider>>(_offerStatusProvider.GetList().ToList());
        }

        public IDataResult<OfferStatusFromProvider> GetOfferStatusById(int Id)
        {
            return new SuccessDataResult<OfferStatusFromProvider>(_offerStatusProvider.Get(x=>x.Id == Id));
        }

        public IDataResult<List<OfferStatusFromProvider>> GetOfferStatusListById(int Id)
        {
            return new SuccessDataResult<List<OfferStatusFromProvider>>(_offerStatusProvider.GetList(x=>x.OfferId == Id).ToList());
        }

        public IResult Update(OfferStatusFromProvider offerStatusFromProvider)
        {
            _offerStatusProvider.Update(offerStatusFromProvider);
            return new SuccessResult(Messages.Updated);
        }
    }
}
