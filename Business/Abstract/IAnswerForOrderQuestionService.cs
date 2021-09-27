using Core.Utilities.Results;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UstasiYapsinAPI.Entities.Concrete;

namespace Business.Abstract
{
    public interface IAnswerForOrderQuestionService
    {
        IDataResult<List<AnswerForOrderQuestion>> GetList();
        IDataResult<List<AnswerForOrderQuestion>> GetAnswerForOrderById(int Id);

        IResult Add(AnswerForOrderQuestion answerForOrderQuestion);
        IResult Update(AnswerForOrderQuestion answerForOrderQuestion);
        IResult Delete(AnswerForOrderQuestion answerForOrderQuestion);
    }
}
