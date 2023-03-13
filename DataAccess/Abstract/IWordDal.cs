﻿using Core.DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IWordDal:IEntityRepository<Word>
    {
        void Update(Word word, Word updatedWord);
    }
}