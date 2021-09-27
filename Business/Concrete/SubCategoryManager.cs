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
    public class SubCategoryManager : ISubCategoryService
    {
        private ISubCategoryDal _subCategoryDal;
        public SubCategoryManager(ISubCategoryDal subCategoryDal)
        {
            _subCategoryDal = subCategoryDal;
        }
        public IResult Add(SubCategory subCategory)
        {
            _subCategoryDal.Add(subCategory);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(SubCategory subCategory)
        {
            _subCategoryDal.Delete(subCategory);
            return new SuccessResult(Messages.Removed);
        }

        public IDataResult<List<SubCategory>> GetList()
        {
            return new SuccessDataResult<List<SubCategory>>(_subCategoryDal.GetList().ToList());
        }

        public IDataResult<List<SubCategory>> GetSubByCategoryId(int Id)
        {
            return new SuccessDataResult<List<SubCategory>>(_subCategoryDal.GetList(x=>x.CategoryId == Id).ToList());
        }

        public IDataResult<List<SubCategory>> GetSubById(int Id)
        {
            return new SuccessDataResult<List<SubCategory>>(_subCategoryDal.GetList(x=>x.Id == Id).ToList());
        }

        public IResult Update(SubCategory subCategory)
        {
            _subCategoryDal.Update(subCategory);
            return new SuccessResult(Messages.Updated);
        }
    }
}
