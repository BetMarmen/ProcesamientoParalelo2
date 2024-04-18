using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialNumeros
{
    public class NumberRepository:IRepository<int>
    {
        private List<int> _list= new List<int>();

        public void Add(int item)
        {
            _list.Add(item);
        }

        public List<int> GetAll()
        {
            return _list;
        }
    }
}
