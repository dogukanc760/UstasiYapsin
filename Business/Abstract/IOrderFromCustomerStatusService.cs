using Core.Utilities.Results;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UstasiYapsinAPI.Entities.Concrete;

namespace Business.Abstract
{
    public interface IOrderFromCustomerStatusService
    {
        IDataResult<List<OrderFromCustomerStatus>> GetList();
        IDataResult<List<OrderFromCustomerStatus>> GetOrderStatusById(int Id);

        IResult Add(OrderFromCustomerStatus orderFromCustomerStatus);
        IResult Update(OrderFromCustomerStatus orderFromCustomerStatus);
        IResult Delete(OrderFromCustomerStatus orderFromCustomerStatus);
    }
}
