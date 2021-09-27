using Core.Utilities.Results;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UstasiYapsinAPI.Entities.Concrete;

namespace Business.Abstract
{
    public interface IWalletService
    {
        IDataResult<List<Wallet>> GetList();
        IDataResult<List<Wallet>> GetWalletById(int Id);

        IResult Add(Wallet wallet);
        IResult Update(Wallet wallet);
        IResult Delete(Wallet wallet);
    }
}
