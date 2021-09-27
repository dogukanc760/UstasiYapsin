using Core.Utilities.Results;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UstasiYapsinAPI.Entities.Concrete;

namespace Business.Abstract
{
    public interface IFrequentlyQuestionAnswerService
    {
        IDataResult<List<FrequentlyQuestionAnswer>> GetList();
        IDataResult<List<FrequentlyQuestionAnswer>> GetFrequentlyAnswerById(int Id);

        IResult Add(FrequentlyQuestionAnswer frequentlyQuestionAnswer);
        IResult Update(FrequentlyQuestionAnswer frequentlyQuestionAnswer);
        IResult Delete(FrequentlyQuestionAnswer frequentlyQuestionAnswer);
    }
}
