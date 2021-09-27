﻿using Core.DataAccess;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UstasiYapsinAPI.Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IWalletDal : IEntityRepository<Wallet>
    {
    }
}
