using Core.Utilities.Results;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UstasiYapsinAPI.Entities.Concrete;

namespace Business.Abstract
{
    public interface IServiceProviderCommentService
    {
        IDataResult<List<ServiceProviderComment>> GetList();
        IDataResult<List<ServiceProviderComment>> GetServiceProviderCommentsById(int Id);

        IResult Add(ServiceProviderComment serviceProviderComment);
        IResult Update(ServiceProviderComment serviceProviderComment);
        IResult Delete(ServiceProviderComment serviceProviderComment);
    }
}
