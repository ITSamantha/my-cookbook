using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm.BD
{
    public class PairForList
    {
        public string name;
        public double index;
        public long id;
       public PairForList(long id, string name, double index)
        {
            this.id = id;
            this.name = name;
            this.index = index;
        }
    }
}
