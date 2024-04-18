using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosPrimos
{
    public class PrimeNumberProcessor
    {
        private readonly IRepository<int> _repository;

        public PrimeNumberProcessor(IRepository<int> repository)
        {
            _repository=repository;
        }
        public List<int> FindPrimesInRange(int start, int end)
        {
            var primes = new List<int>();

            // Iterar sobre el rango dado y encontrar números primos
            Parallel.For(start, end + 1, (i) =>
            {
                if (IsPrime(i))
                {
                    lock (primes)
                    {
                        primes.Add(i);
                    }
                }
            });

            return primes;
        }
        private bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
