using System;
using UCLFlix.Views;
using UCLFlix.Database;
using System.Collections.Generic;
using UCLFlix.Classes;
using UCLFlix.Enums;

namespace UCLFlix
{
    [Serializable]
    class Usuario {
        public string nome;
        public int idade;

        public Usuario(string nome, int idade){
            this.nome = nome;
            this.idade = idade;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CarregarRepositorio();
            ExibirCatalogo();
        }

        static void CarregarRepositorio()
        {
            Programa.repositorioProgramas.AdicionarProgramas(
                new Filme(nome:"O Poderoso Chefão", genero:Genero.Drama, ano:1972),
                new Filme(nome:"Parasita", genero:Genero.Suspence, ano:2019),
                new Filme(nome:"Cidade de Deus", genero:Genero.Acao, ano:2002),
                new Filme(nome:"Bastardos Inglórios", genero:Genero.Acao, ano:2009),
                new Filme(nome:"O Auto Da Compadecida", genero:Genero.Comedia, ano:2000)
            );

            Programa.repositorioProgramas.AdicionarProgramas(
                new Serie(nome:"Round 6", genero:Genero.Drama, temporadas:1, ano:2021),
                new Serie(nome:"Sex Education", genero:Genero.Drama, temporadas:3, ano:2019),
                new Serie(nome:"The Witcher", genero:Genero.Fantasia, temporadas:1, ano:2019),
                new Serie(nome:"The Purge", genero:Genero.Acao, temporadas:2, ano:2018),
                new Serie(nome:"Brooklyn Nine-Nine", genero:Genero.Comedia, temporadas:8, ano:2013)
            );
        }

        static void ExibirCatalogo()
        {
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
