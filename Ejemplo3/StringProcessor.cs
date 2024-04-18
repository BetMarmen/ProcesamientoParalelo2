using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo3
{
    public class StringProcessor
    {
        private readonly IRepository<string> _repository;

        public StringProcessor(IRepository<string> repository)
        {
            _repository=repository;
        }
        public List<string> FilterStringStartingWithE()
        {
            return _repository
                .GetAll()
                .AsParallel() // Procesamiento en paralelo
                .Where(s => s.StartsWith("E", StringComparison.OrdinalIgnoreCase))
                .ToList();
        }
    }
}
