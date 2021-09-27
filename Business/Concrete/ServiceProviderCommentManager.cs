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
    public class ServiceProviderCommentManager : IServiceProviderCommentService
    {
        private IServiceProviderCommentDal _providerComment;
        public ServiceProviderCommentManager(IServiceProviderCommentDal providerComment)
        {
            _providerComment = providerComment;
        }
        public IResult Add(ServiceProviderComment serviceProviderComment)
        {
            _providerComment.Add(serviceProviderComment);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(ServiceProviderComment serviceProviderComment)
        {
            _providerComment.Delete(serviceProviderComment);
            return new SuccessResult(Messages.Removed);
        }

        public IDataResult<List<ServiceProviderComment>> GetList()
        {
            return new SuccessDataResult<List<ServiceProviderComment>>(_providerComment.GetList().ToList());
        }

        public IDataResult<List<ServiceProviderComment>> GetServiceProviderCommentsById(int Id)
        {
            return new SuccessDataResult<List<ServiceProviderComment>>(_providerComment.GetList(x=>x.ServiceProviderId == Id).ToList());
        }

        public IResult Update(ServiceProviderComment serviceProviderComment)
        {
            _providerComment.Update(serviceProviderComment);
            return new SuccessResult(Messages.Removed);
        }
    }
}
