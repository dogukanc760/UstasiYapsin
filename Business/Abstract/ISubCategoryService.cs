using Core.Utilities.Results;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UstasiYapsinAPI.Entities.Concrete;

namespace Business.Abstract
{
    public interface ISubCategoryService
    {
        IDataResult<List<SubCategory>> GetList();
        IDataResult<List<SubCategory>> GetSubByCategoryId(int Id);
        IDataResult<List<SubCategory>> GetSubById(int Id);
        IResult Add(SubCategory subCategory);
        IResult Update(SubCategory subCategory);
        IResult Delete(SubCategory subCategory);
    }
}
