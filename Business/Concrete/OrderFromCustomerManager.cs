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
    public class OrderFromCustomerManager : IOrderFromCustomerService
    {
        private IOrderFromCustomerDal _orderFromCustomerDal;
        public OrderFromCustomerManager(IOrderFromCustomerDal orderFromCustomerDal)
        {
            _orderFromCustomerDal = orderFromCustomerDal;
        }
        public IResult Add(OrderFromCustomer orderFromCustomer)
        {
            _orderFromCustomerDal.Add(orderFromCustomer);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(OrderFromCustomer orderFromCustomer)
        {
            _orderFromCustomerDal.Delete(orderFromCustomer);
            return new SuccessResult(Messages.Removed);
        }

        public IDataResult<List<OrderFromCustomer>> GetList()
        {
            return new SuccessDataResult<List<OrderFromCustomer>>(_orderFromCustomerDal.GetList().ToList());
        }

        public IDataResult<OrderFromCustomer> GetOrderById(int Id)
        {
            return new SuccessDataResult<OrderFromCustomer>(_orderFromCustomerDal.Get(x=>x.Id == Id));
        }

        public IDataResult<List<OrderFromCustomer>> GetOrderListById(int Id)
        {
            return new SuccessDataResult<List<OrderFromCustomer>>(_orderFromCustomerDal.GetList(x=>x.ServiceUserId == Id).ToList());
        }

        public IResult Update(OrderFromCustomer orderFromCustomer)
        {
            _orderFromCustomerDal.Update(orderFromCustomer);
            return new SuccessResult(Messages.Updated);
        }
    }
}
