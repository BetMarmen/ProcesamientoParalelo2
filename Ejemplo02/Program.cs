using Ejemplo02;
using System.Diagnostics;

var stopwatch= new Stopwatch();
stopwatch.Start();
var repository = new StringRepository(10000, 10);
var processor= new StringProcessor(repository);
var filterStrings = processor.FilterString();
foreach (var filterString in filterStrings)
    Console.WriteLine(filterString);
stopwatch.Stop();
Console.WriteLine($"Tiempo transcurrido: {stopwatch.ElapsedMilliseconds} ms");
