using System;
using System.Collections.Generic;
using UCLFlix.Enums;
using UCLFlix.Interfaces;

namespace UCLFlix.Classes
{
    public abstract class Programa : IAvaliacao
    {
        public string Nome { get; protected set; }
        public Genero Genero { get; protected set; }
        public int Ano { get; protected set; }
        public int Like { get; protected set; }
        public int Deslike { get; protected set; }
        public static List<Programa> repositorioProgramas = new List<Programa>();

        public Programa(string nome, Genero genero, int ano)
        {
            Nome = nome;
            Genero = genero;
            Ano = ano;
            Like = 0;
            Deslike = 0;
        }

        public void DarLike()
        {
            Like++;
        }

        public void DarDeslike()
        {
            Deslike++;
        }
    }
}