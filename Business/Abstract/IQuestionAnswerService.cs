using Core.Utilities.Results;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UstasiYapsinAPI.Entities.Concrete;

namespace Business.Abstract
{
    public interface IQuestionAnswerService
    {
        IDataResult<List<QuestionAnswer>> GetList();
        IDataResult<List<QuestionAnswer>> GetAnswerById(int Id);

        IResult Add(QuestionAnswer questionAnswer);
        IResult Update(QuestionAnswer questionAnswer);
        IResult Delete(QuestionAnswer questionAnswer);
    }
}
