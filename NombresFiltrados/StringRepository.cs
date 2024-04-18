using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NombresFiltrados
{
    public class StringRepository : IRepository<String>
    {
        private List<String> _list = new List<String>();
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
