using Business.Abstract;
using Business.Constants;

using Core.Entities.Concrete;
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
    public class AddressManager : IAddressService
    {

        private IAddressDal _adressDal;
        public AddressManager(IAddressDal addressDal)
        {
            _adressDal = addressDal;
        }

        public IResult Add(Address address)
        {
            _adressDal.Add(address);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Address address)
        {
            _adressDal.Delete(address);
            return new SuccessResult(Messages.Removed);
        }

        public IDataResult<List<Address>> GetAdressByUser(int userId)
        {
            return new SuccessDataResult<List<Address>>(_adressDal.GetList(x=>x.UserId == userId).ToList());
        }

        public IDataResult<List<Address>> GetList()
{
            return new SuccessDataResult<List<Address>>(_adressDal.GetList().ToList());
        }

        public IResult Update(Address address)
        {
            _adressDal.Update(address);
            return new SuccessResult(Messages.Updated);
        }
    }
}
