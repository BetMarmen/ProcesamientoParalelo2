using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosPrimos
{
    public class NumberRepository : IRepository<int>
    {
        private List<int> _list = new List<int>();
        public void Add(int item)
        {
            _list.Add(item);
        }


        List<int> IRepository<int>.GetAll()
        {
           return _list;
        }
    }
}
