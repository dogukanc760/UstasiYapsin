using Core.Utilities.Results;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UstasiYapsinAPI.Entities.Concrete;

namespace Business.Abstract
{
    public interface IQuestionMainService
    {
        IDataResult<List<QuestionMain>> GetList();
        IDataResult<List<QuestionMain>> GetQuestionsById(int Id);

        IResult Add(QuestionMain questionMain);
        IResult Update(QuestionMain questionAnswer);
        IResult Delete(QuestionMain questionAnswer);
    }
}
