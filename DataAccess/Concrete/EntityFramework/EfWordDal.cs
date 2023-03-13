using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfWordDal : EfEntityRepositoryBase<Word, DictionaryContext>, IWordDal
    {
        public void Update(Word word, Word updatedWord)
        {
            using (DictionaryContext context = new DictionaryContext())
            {
                var a = context.Words.SingleOrDefault(x => x.Id == word.Id);
                a.Definition1 = updatedWord.Definition1;
                a.Definition2 = updatedWord.Definition2;
                a.Definition3 = updatedWord.Definition3;
                a.Definition4 = updatedWord.Definition4;
                a.Definition5 = updatedWord.Definition5;
                a.Translation = updatedWord.Translation;
                context.SaveChanges();
            }
        }
    }
}
