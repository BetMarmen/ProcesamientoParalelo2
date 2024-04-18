using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo3
{
    public class StringRepository : IRepository<string>
    {
        private List<string> _list = new List<string>();
        public void Add(string item)
        {
            _list.Add(item);
        }

        public List<string> GetAll()
        {
            return _list;
        }
    }
}
