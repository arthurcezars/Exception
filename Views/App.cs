using System;
using UCLFlix.Classes;

namespace UCLFlix.Views
{
    public class App
    {
        public static void InprimirCatalogo(){
            foreach (var programa in Programa.repositorioProgramas)
            {
                var filme = programa as Filme;

                if (filme == null)
                {
                    var serie = programa as Serie;

                    Console.WriteLine("Serie:");
                    Console.WriteLine(serie.Nome);
                    Console.WriteLine(serie.Genero);
                    Console.WriteLine(serie.Ano);
                    Console.WriteLine(serie.Temporadas);
                }
                else
                {
                    Console.WriteLine("Filme:");
                    Console.WriteLine(filme.Nome);
                    Console.WriteLine(filme.Genero);
                    Console.WriteLine(filme.Ano);
                }
                Console.WriteLine();
            }
        }
    }
}