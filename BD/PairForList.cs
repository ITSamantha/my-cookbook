using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm.BD
{
    public class PairForList
    {
     
        public double index;
        public long id;
       public PairForList(long id,  double index)
        {
            this.id = id;
         
            this.index = index;
        }
    }
}
