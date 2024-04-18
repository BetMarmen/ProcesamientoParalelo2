using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo02
{
    public class StringProcessor
    {
        private readonly IRepository<String> _repository;
        public StringProcessor(IRepository<String> repository)
        {
            _repository = repository;
        }
        public List<String> FilterString()=>
            _repository.GetAll().AsParallel().Where(s=>s.Contains("W")).ToList();
    }
}
