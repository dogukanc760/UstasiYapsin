using Core.Utilities.Results;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UstasiYapsinAPI.Entities.Concrete;

namespace Business.Abstract
{
    public interface IOrderFromCustomerService
    {
        IDataResult<List<OrderFromCustomer>> GetList();
        IDataResult<List<OrderFromCustomer>> GetOrderListById(int Id);
        IDataResult<OrderFromCustomer> GetOrderById(int Id);
        IResult Add(OrderFromCustomer orderFromCustomer);
        IResult Update(OrderFromCustomer orderFromCustomer);
        IResult Delete(OrderFromCustomer orderFromCustomer);
    }
}
