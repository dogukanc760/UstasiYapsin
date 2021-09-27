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
    public class QuestionAnswerManager : IQuestionAnswerService
    {
        private IQuestionAnswerDal _questionAnswerDal;
        public QuestionAnswerManager(IQuestionAnswerDal questionAnswerDal)
        {
            _questionAnswerDal = questionAnswerDal;
        }
        public IResult Add(QuestionAnswer questionAnswer)
        {
            _questionAnswerDal.Add(questionAnswer);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(QuestionAnswer questionAnswer)
        {
            _questionAnswerDal.Delete(questionAnswer);
            return new SuccessResult(Messages.Removed);
        }

        public IDataResult<List<QuestionAnswer>> GetAnswerById(int Id)
        {
            return new SuccessDataResult<List<QuestionAnswer>>(_questionAnswerDal.GetList(x=>x.QuestionMainId == Id).ToList());
        }

        public IDataResult<List<QuestionAnswer>> GetList()
        {
            return new SuccessDataResult<List<QuestionAnswer>>(_questionAnswerDal.GetList().ToList());
        }

        public IResult Update(QuestionAnswer questionAnswer)
        {
            _questionAnswerDal.Add(questionAnswer);
            return new SuccessResult(Messages.Updated);
        }
    }
}
