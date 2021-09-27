using Core.DataAccess;
using Core.Entities.Concrete;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UstasiYapsinAPI.Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IAnswerForOrderQuestionDal : IEntityRepository<AnswerForOrderQuestion>
    {
    }
}
