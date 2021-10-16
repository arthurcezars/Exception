using System;
using UCLFlix.Enums;
using UCLFlix.Interfaces;

namespace UCLFlix.Classes
{
    [Serializable]
    public abstract class Programa : IAvaliacao
    {
        public string Nome { get; protected set; }
        public Genero Genero { get; protected set; }
        public int Ano { get; protected set; }
        public double Nota { get; protected set; }

        public Programa(string nome, Genero genero, int ano)
        {
            Nome = nome;
            Genero = genero;
            Ano = ano;
        }

        public Programa(string nome, Genero genero, int ano, double nota)
        {
            Nome = nome;
            Genero = genero;
            Ano = ano;
            Nota = nota;
        }

        public void Avaliar(double nota)
        {
            Nota = nota;
        }

    }

}