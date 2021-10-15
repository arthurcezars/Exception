using System;
using System.Collections.Generic;
using UCLFlix.Classes;
using UCLFlix.Repositories;

namespace UCLFlix.Views
{
    public class App
    {
        public static void InprimirCatalogo(){
            List<Programa> catalago = ProgramasRepository.findAll();

            foreach (var programa in catalago)
            {
                var filme = programa as Filme;

                if (filme == null)
                {
                    var serie = programa as Serie;

                    Console.WriteLine("Serie:");
                    Console.WriteLine(serie.ToString());
                }
                else
                {
                    Console.WriteLine("Filme:");
                    Console.WriteLine(filme.ToString());
                }
                Console.WriteLine();
            }
        }
    }
}