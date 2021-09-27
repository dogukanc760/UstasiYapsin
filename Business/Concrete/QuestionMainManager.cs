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
    public class QuestionMainManager : IQuestionMainService
    {
        private IQuestionMainDal _questionMainDal;
        public QuestionMainManager(IQuestionMainDal questionMainDal)
        {
            _questionMainDal = questionMainDal;
        }
        public IResult Add(QuestionMain questionMain)
        {
            _questionMainDal.Add(questionMain);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(QuestionMain questionAnswer)
        {
            _questionMainDal.Delete(questionAnswer);
            return new SuccessResult(Messages.Removed);
        }

        public IDataResult<List<QuestionMain>> GetList()
        {
            return new SuccessDataResult<List<QuestionMain>>(_questionMainDal.GetList().ToList());
        }

        public IDataResult<List<QuestionMain>> GetQuestionsById(int Id)
        {
            return new SuccessDataResult<List<QuestionMain>>(_questionMainDal.GetList(x=>x.SubCategoryId == Id).ToList());
        }

        public IResult Update(QuestionMain questionAnswer)
        {
            _questionMainDal.Update(questionAnswer);
            return new SuccessResult(Messages.Updated);
        }
    }
}
