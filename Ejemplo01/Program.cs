using System.Diagnostics;

var numeros = Enumerable.Range(1, 10000);
var sw=new Stopwatch();
sw.Start();


// Opt in to PLINQ with AsParallel.
var numerospares = from num in numeros.AsParallel().AsOrdered()
               where num % 2 == 0
               select num;
sw.Stop();

Console.WriteLine("{0} números pares de {1} total,tiempo {2}",
                  numerospares.Count(), numeros.Count(),sw.ElapsedMilliseconds);

// The example displays the following output:
//       5000 even numbers out of 10000 total
