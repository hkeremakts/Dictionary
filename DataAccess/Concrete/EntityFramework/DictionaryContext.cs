using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class DictionaryContext:DbContext
    {
        public DictionaryContext():base("DictionaryDatabase")
        {
            Database.SetInitializer<DictionaryContext>(new DropCreateDatabaseIfModelChanges<DictionaryContext>());
        }
        public DbSet<Word> Words { get; set; }
    }
}
