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
    public class FrequentlyQustionAnswerManager:IFrequentlyQuestionAnswerService
    {
        private IFrequentlyQuestionAnswerDal _frequentlyQuestionDal;
        public FrequentlyQustionAnswerManager(IFrequentlyQuestionAnswerDal frequentlyQuestionDal)
        {
            _frequentlyQuestionDal = frequentlyQuestionDal;
        }

        public IResult Add(FrequentlyQuestionAnswer frequentlyQuestionAnswer)
        {
            _frequentlyQuestionDal.Add(frequentlyQuestionAnswer);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(FrequentlyQuestionAnswer frequentlyQuestionAnswer)
        {
            _frequentlyQuestionDal.Delete(frequentlyQuestionAnswer);
            return new SuccessResult(Messages.Removed);
        }

        public IDataResult<List<FrequentlyQuestionAnswer>> GetFrequentlyAnswerById(int Id)
        {
            return new SuccessDataResult<List<FrequentlyQuestionAnswer>>(_frequentlyQuestionDal.GetList(x=>x.Id == Id).ToList());
        }

        public IDataResult<List<FrequentlyQuestionAnswer>> GetList()
        {
            return new SuccessDataResult<List<FrequentlyQuestionAnswer>>(_frequentlyQuestionDal.GetList().ToList());
        }

        public IResult Update(FrequentlyQuestionAnswer frequentlyQuestionAnswer)
        {
            _frequentlyQuestionDal.Update(frequentlyQuestionAnswer);
            return new SuccessResult(Messages.Updated);
        }
    }
}
