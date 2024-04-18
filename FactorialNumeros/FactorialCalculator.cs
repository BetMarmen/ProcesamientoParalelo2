using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FactorialNumeros
{
    public class FactorialCalculator
    {
        private readonly IRepository<int> _repository;

        public FactorialCalculator(IRepository<int> repository)
        {
            _repository=repository;
        }
        public List<BigInteger> CalculateFactorials()
        {
            var factorials = new List<BigInteger>();

            Parallel.ForEach(_repository.GetAll(), (number) =>
            {
                factorials.Add(Factorial(number));
            });

            return factorials;
        }
        private BigInteger Factorial(int n)
        {
            BigInteger result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}