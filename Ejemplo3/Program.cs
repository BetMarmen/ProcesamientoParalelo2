<<<<<<< HEAD
﻿using Ejemplo3;
using System.Diagnostics;

var repository = new StringRepository();

// Agregar nombres al repositorio
string[] nombres = { "Elena", "Juan", "María", "Eduardo", "Ernesto", "Esther", "Ana", "Eva", "Elisa", "Carlos" };
foreach (var nombre in nombres)
{
    repository.Add(nombre);
}

// Procesar nombres que empiezan con 'E'
var stopwatch = new Stopwatch();
stopwatch.Start();

var processor = new StringProcessor(repository);
var nombresConE = processor.FilterStringStartingWithE();

stopwatch.Stop();

// Imprimir nombres que empiezan con 'E'
Console.WriteLine("Nombres que empiezan con 'E':");
foreach (var nombre in nombresConE)
{
    Console.WriteLine(nombre);
}

Console.WriteLine($"Tiempo transcurrido: {stopwatch.ElapsedMilliseconds} ms");
=======
﻿
>>>>>>> 16599bb80b8c08b6d2cc3068148c30f44f3eae3a
