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
    public class WalletManager : IWalletService
    {
        private IWalletDal _walletDal;
        public WalletManager(IWalletDal walletDal)
        {
            _walletDal = walletDal;
        }
        public IResult Add(Wallet wallet)
        {
            _walletDal.Add(wallet);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Wallet wallet)
        {
            _walletDal.Delete(wallet);
            return new SuccessResult(Messages.Removed);
        }

        public IDataResult<List<Wallet>> GetList()
        {
            return new SuccessDataResult<List<Wallet>>(_walletDal.GetList().ToList());
        }

        public IDataResult<List<Wallet>> GetWalletById(int Id)
        {
            return new SuccessDataResult<List<Wallet>>(_walletDal.GetList(x=>x.UserId == Id).ToList());
        }

        public IResult Update(Wallet wallet)
        {
            _walletDal.Update(wallet);
            return new SuccessResult(Messages.Updated);
        }
    }
}
