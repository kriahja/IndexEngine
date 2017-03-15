using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Words
    {
        public int Id { get; }
        
        public string word { get; set; }
        public ICollection<object> Paths { get; internal set; }

    }
}
