using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UstasiYapsinAPI.Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfReferanceDal : EfEntityRepositoryBase<Referance, NorthwindContext>, IReferanceDal
    {
    }
}
