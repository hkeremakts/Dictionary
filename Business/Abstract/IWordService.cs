using Core.Utilities.Results;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IWordService
    {
        IDataResult<List<Word>> GetAllWords();
        IDataResult<Word> GetWordByName(string name);
        IResult Add(Word word);
        IResult Delete(Word word);
        IResult Update(Word word);
    }
}
