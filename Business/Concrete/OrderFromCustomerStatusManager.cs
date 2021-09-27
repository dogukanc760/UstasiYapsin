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
    public class OrderFromCustomerStatusManager : IOrderFromCustomerStatusService
    {
        private IOrderFromCustomerStatusDal _orderFromCustomer;
        public OrderFromCustomerStatusManager(IOrderFromCustomerStatusDal orderFromCustomer)
        {
            _orderFromCustomer = orderFromCustomer;
        }
        public IResult Add(OrderFromCustomerStatus orderFromCustomerStatus)
        {
            _orderFromCustomer.Add(orderFromCustomerStatus);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(OrderFromCustomerStatus orderFromCustomerStatus)
        {
            _orderFromCustomer.Delete(orderFromCustomerStatus);
            return new SuccessResult(Messages.Removed);
        }

        public IDataResult<List<OrderFromCustomerStatus>> GetList()
        {
            return new SuccessDataResult<List<OrderFromCustomerStatus>>(_orderFromCustomer.GetList().ToList());
        }

        public IDataResult<List<OrderFromCustomerStatus>> GetOrderStatusById(int Id)
        {
            return new SuccessDataResult<List<OrderFromCustomerStatus>>(_orderFromCustomer.GetList(x=>x.Id == Id).ToList());
        }

        public IResult Update(OrderFromCustomerStatus orderFromCustomerStatus)
        {
            _orderFromCustomer.Update(orderFromCustomerStatus);
            return new SuccessResult(Messages.Updated);
        }
    }
}
