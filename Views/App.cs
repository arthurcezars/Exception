using System;
using System.Collections.Generic;
using UCLFlix.Classes;
using UCLFlix.Repositories;
using UCLFlix.Utils;
using System.Threading;

namespace UCLFlix.Views
{
    public class App
    {

        public static int ListarProgramas(){
            List<Programa> lista = ProgramasRepository.findAll();
            int c = 1;
            Console.Clear();
            Table.PrintLine();
            Table.PrintRow("##### Catalago de Programas #####");
            Table.PrintLine();
            Table.PrintRow("ID", "NOME", "GENERO");
            Table.PrintLine();
            foreach (var item in lista)
            {   
                Table.PrintRow( c.ToString() ,item.Nome, Enum.GetName(item.Genero));
                // System.Console.WriteLine($"{c} - {item.Nome} | {Enum.GetName(item.Genero)}");
                c++;
            }
            Table.PrintLine();
            return lista.Count;
        }

        public static int ListarProgramasRecomendados(DistEucl distEucl)
        {
            ListarProgramas();
            Console.WriteLine();

            Table.PrintLine();
            Table.PrintRow("##### Catalago de Recomendados #####");
            Table.PrintLine();
            Table.PrintRow("ID", "NOME", "GENERO");
            Table.PrintLine();
            int c = 1;
            foreach (var item in distEucl.User.ListaAvaliados)
            {   
                Table.PrintRow( c.ToString() ,item.Nome, Enum.GetName(item.Genero));
                // System.Console.WriteLine($"{c} - {item.Nome} | {Enum.GetName(item.Genero)}");
                c++;
            }
            Table.PrintLine();
            return distEucl.User.ListaAvaliados.Count;
        }

        public static int SelecionarPrograma(){
            int tam = ListarProgramas();
            int opx = int.Parse(Console.ReadLine());
            if(opx >= 1 && opx <= tam){
                return opx;
            }else{
                Console.Clear();
                Logger.Warn("Opção invalida ...\n");
                Thread.Sleep(1500);
                return SelecionarPrograma();
            }
        }

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