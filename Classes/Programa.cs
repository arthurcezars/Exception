using System;
using UCLFlix.Enums;

namespace UCLFlix.Classes
{
    public abstract class Programa
    {
        public string Nome { get; protected set; }
        public string Descricao { get; protected set; }
        public Genero Genero { get; protected set; }
        public int Ano { get; protected set; }
        public int Like { get; protected set; }
        public int Dislike { get; protected set; }

        public Programa(string nome, string descricao, Genero genero, int ano)
        {
            Nome = nome;
            Descricao = descricao;
            Genero = genero;
            Ano = ano;
            Like = 0;
            Dislike = 0;
        }

        public void DarLike()
        {
            Like++;
        }

        public void DarDislike()
        {
            Dislike++;
        }
    }
}