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
    public class AnswerForOrderQuestionManager: IAnswerForOrderQuestionService
    {
        private IAnswerForOrderQuestionDal _answerForOrderQuestionDal;
        public AnswerForOrderQuestionManager(IAnswerForOrderQuestionDal answerForOrderQuestionDal)
        {
            _answerForOrderQuestionDal = answerForOrderQuestionDal;
        }

        public IResult Add(AnswerForOrderQuestion answerForOrderQuestion)
        {
            _answerForOrderQuestionDal.Add(answerForOrderQuestion);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(AnswerForOrderQuestion answerForOrderQuestion)
        {
            _answerForOrderQuestionDal.Delete(answerForOrderQuestion);
            return new SuccessResult(Messages.Removed);
        }

        public IDataResult<List<AnswerForOrderQuestion>> GetAnswerForOrderById(int Id)
        {
            return new SuccessDataResult<List<AnswerForOrderQuestion>>(_answerForOrderQuestionDal.GetList(x => x.QuestionAnswerId == Id).ToList());
        }

        public IDataResult<List<AnswerForOrderQuestion>> GetList()
        {
            return new SuccessDataResult<List<AnswerForOrderQuestion>>(_answerForOrderQuestionDal.GetList().ToList());
        }

        public IResult Update(AnswerForOrderQuestion answerForOrderQuestion)
        {
            _answerForOrderQuestionDal.Add(answerForOrderQuestion);
            return new SuccessResult(Messages.Updated);
        }
    }
}
