using System;
using UCLFlix.Enums;

namespace UCLFlix.Classes
{
    public class Serie : Programa
    {
        public int Temporadas { get; protected set; }

        public Serie(string nome, string descricao, Genero genero, int temporadas) 
            : base(nome, descricao, genero, DateTime.Today.Year)
        {
            Temporadas = temporadas;
        }

        public Serie(string nome, string descricao, Genero genero, int temporadas, int ano) 
            : base(nome, descricao, genero, ano)
        {
            Temporadas = temporadas;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + Genero + Environment.NewLine;
            retorno += "Nome: " + Nome + Environment.NewLine;
            retorno += "Descrição: " + Descricao + Environment.NewLine;
            retorno += "Ano: " + Ano + Environment.NewLine;
            retorno += "Temporadas: " + Temporadas + Environment.NewLine;
            retorno += "Likes: " + Like + "Dislikes: " + Dislike;
            return retorno;
        }
    }
}