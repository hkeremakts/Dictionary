using Business.Abstract;
using Business.Constant;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Extensions;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Xml.Linq;

namespace Business.Concrete
{
    public class WordManager : IWordService
    {
        IWordDal _wordDal;
        public WordManager(IWordDal dal)
        {
            _wordDal = dal;
        }
        [ValidationAspect(typeof(WordValidator))]
        public IResult Add(Word word)
        {
            string[] definitions = GetDefinitionsArray(word);
            var result = BusinessRules.Run(
                CheckIfWordAlreadyExists(word.Name),
                CheckIfDefinitionsAreNull(definitions),
                CheckIfNameIsntNull(word.Name)
                );
            if (result != null)
                return new ErrorResult(result.Message);
            for (int i = 0; i < definitions.Length; i++)
            {
                definitions[i] = WordReplacements(definitions[i]);
                definitions[i] = SentenceOrganizations(definitions[i]);
            }
            _wordDal.Add(CreateWord(word.Name, definitions, word.Translation));
            return new SuccessResult(Messages.WordAdded);
        }
        public IResult Delete(Word word)
        {
            _wordDal.Delete(word);
            return new SuccessResult(Messages.WordDeleted);
        }

        public IDataResult<List<Word>> GetAllWords()
        {
            return new SuccessDataResult<List<Word>>(_wordDal.GetAll());
        }

        public IDataResult<Word> GetWordByName(string name)
        {
            var result = BusinessRules.Run(
                CheckIfNameIsntNull(name),
                CheckIfWordExists(name));
            if (result!=null)
                return new ErrorDataResult<Word>(result.Message);
            var word = _wordDal.Get(w => w.Name == name);
            return new SuccessDataResult<Word>(word);
        }
        [ValidationAspect(typeof(WordValidator))]
        public IResult Update(Word word)
        {
            string[] definitions = GetDefinitionsArray(word);
            var result = BusinessRules.Run(
                CheckIfWordAlreadyExists(word.Name),
                CheckIfDefinitionsAreNull(definitions)
                );
            if (result != null)
                return new ErrorResult(result.Message);
            for (int i = 0; i < definitions.Length; i++)
            {
                definitions[i] = WordReplacements(definitions[i]);
                definitions[i] = SentenceOrganizations(definitions[i]);
            }
            _wordDal.Update(word);
            return new SuccessResult(Messages.WordUpdated);
        }
        private string WordReplacements(string str)
        {
            str = str.ReplaceWord("smth", "something");
            str = str.ReplaceWord("sb", "somebody");
            return str;
        }
        private string SentenceOrganizations(string str)
        {
            str = str.Trim();
            if (!str.EndsWith('.')&&str.Length>0)
                str = str.Insert(str.Length, ".");
            return str;
        }
        private Word CreateWord(string name, string[] definitions, string translation)
        {
            int j = 0;
            Word word = new Word()
            {
                Name = name,
                Translation = translation
            };
            var result = word.GetType().GetProperties().Where(x => x.Name.Contains("Definition")).ToArray();
            for (int i = 0; i < definitions.Length; i++)
            {
                if (definitions[i].Length>0)
                {
                    result[j].SetValue(word, definitions[i]);
                    j++;
                }
            }
            return word;
        }
        private string[] GetDefinitionsArray(Word word)
        {
            var result = word.GetType().GetProperties().Where(x => x.Name.Contains("Definition")).ToArray();
            string[] definitions = new string[result.Length];
            for (int i = 0; i < result.Length; i++)
                definitions[i] = result[i].GetValue(word).ToString();
            return definitions;
        }
        private IResult CheckIfWordAlreadyExists(string name)
        {
            if (this.GetWordByName(name).Data!=null)
                return new ErrorResult(Messages.WordAlreadyExists);
            return new SuccessResult();
        }
        private IResult CheckIfDefinitionsAreNull(string[] definitions)
        {
            for (int i = 0; i < definitions.Length; i++)
            {
                if (definitions[i].Length>0)
                    return new SuccessResult();
            }
            return new ErrorResult(Messages.WordDontHaveAnyDefinition);
        }
        private IResult CheckIfWordExists(string name)
        {
            var result = _wordDal.Get(w => w.Name == name);
            if (result == null)
                return new ErrorResult(Messages.WordDoesntExist);
            return new SuccessResult();
        }
        private IResult CheckIfNameIsntNull(string name)
        {
            if (name.Length<1)
                return new ErrorResult(Messages.NameIsNull);
            return new SuccessResult();
        }
    }
}
