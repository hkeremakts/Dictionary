using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Word:IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Definition1 { get; set; }
        public string Definition2 { get; set; }
        public string Definition3 { get; set; }
        public string Definition4 { get; set; }
        public string Definition5 { get; set; }
        public string Translation { get; set; }
    }
}
