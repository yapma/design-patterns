using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class MyCollection
    {
        private readonly ISort sortAlg;

        public MyCollection(ISort sortAlg)
        {
            this.sortAlg = sortAlg;
        }

        public void Sort()
        {
            sortAlg.Sort();
        }
    }
}
